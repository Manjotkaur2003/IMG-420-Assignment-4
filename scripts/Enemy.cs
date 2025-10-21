using Godot;
using System;

public partial class Enemy : CharacterBody2D
{
    [Export] public float Speed = 150f;
    private NavigationAgent2D agent;
    private Node2D player;
    private PackedScene explosionScene;
    private GameManager gameManager;
    private bool gameOverTriggered = false;

    public override void _Ready()
    {
        agent = GetNode<NavigationAgent2D>("NavigationAgent2D");
        player = GetTree().GetFirstNodeInGroup("Player") as Node2D;
        explosionScene = GD.Load<PackedScene>("res://scenes/Explosion.tscn");
        gameManager = GetTree().Root.GetNode<GameManager>("/root/Main");
    }

    public override void _PhysicsProcess(double delta)
    {
        if (player == null || gameOverTriggered)
            return;

        agent.TargetPosition = player.GlobalPosition;
        Vector2 next = agent.GetNextPathPosition();
        Vector2 dir = (next - GlobalPosition).Normalized();
        Velocity = dir * Speed;
        MoveAndSlide();

        // Detect proximity (collision substitute)
        if (GlobalPosition.DistanceTo(player.GlobalPosition) < 20)
        {
            TriggerGameOver();
        }
    }

    private void TriggerGameOver()
    {
        gameOverTriggered = true;

        // Spawn explosion
        var explosion = (GPUParticles2D)explosionScene.Instantiate();
        GetTree().CurrentScene.AddChild(explosion);
        explosion.GlobalPosition = GlobalPosition;
        explosion.Emitting = true;

        gameManager.GameOver();
    }
}

