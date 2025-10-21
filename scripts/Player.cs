using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export] public float Speed = 200f;
    private AnimatedSprite2D sprite;

    public override void _Ready()
    {
        sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
        AddToGroup("Player");
    }

    public override void _PhysicsProcess(double delta)
    {
        Vector2 dir = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
        Velocity = dir * Speed;
        MoveAndSlide();

        if (dir != Vector2.Zero)
        {
            sprite.Modulate = new Color(0.2f, 0.8f, 1f);
        }
        else
        {
            sprite.Modulate = new Color(0.5f, 0.5f, 1f);
        }
    }

    private void _on_body_entered(Node2D body)
    {
        if (body is Crystal crystal)
        {
            crystal.Collect();
            GetTree().Root.GetNode<GameManager>("/root/Main").AddScore(1);
        }
    }
}
