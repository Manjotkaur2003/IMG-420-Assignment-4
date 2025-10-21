using Godot;
using System;

public partial class GameManager : Node
{
    private Label scoreLabel;
    private int score = 0;
    private int totalCrystals = 0;
    private bool isGameOver = false;

    private PackedScene explosionScene;
    private PackedScene sparkleScene;
    private Timer restartTimer;

    private AudioStreamPlayer pickupSound;
    private AudioStreamPlayer explosionSound;
    private AudioStreamPlayer music;

    public override void _Ready()
    {
        scoreLabel = GetNode<Label>("CanvasLayer/Label");
        totalCrystals = GetTree().GetNodesInGroup("Crystals").Count;

        explosionScene = GD.Load<PackedScene>("res://scenes/Explosion.tscn");
        sparkleScene = GD.Load<PackedScene>("res://scenes/Sparkle.tscn");

        pickupSound = GetNode<AudioStreamPlayer>("PickupSound");
        explosionSound = GetNode<AudioStreamPlayer>("ExplosionSound");
        music = GetNode<AudioStreamPlayer>("Music");

        // Restart timer
        restartTimer = new Timer();
        AddChild(restartTimer);
        restartTimer.WaitTime = 3.0;
        restartTimer.Timeout += OnRestartTimeout;

        UpdateUI();
    }

    public void AddScore(int amount, Vector2 position)
    {
        if (isGameOver) return;

        score += amount;
        UpdateUI();
        PlaySparkle(position);
        pickupSound?.Play();

        if (score >= totalCrystals)
        {
            PlayExplosion(position);
            explosionSound?.Play();
            scoreLabel.Text = "🎉 You Win! 🎉";
            restartTimer.Start();
        }
    }

    public void GameOver()
    {
        if (isGameOver) return;
        isGameOver = true;

        explosionSound?.Play();
        scoreLabel.Text = "💀 Game Over 💀";
        restartTimer.Start();
    }

    private void OnRestartTimeout() => GetTree().ReloadCurrentScene();

    private void UpdateUI() =>
        scoreLabel.Text = $"Score: {score}/{totalCrystals}";

    private void PlaySparkle(Vector2 pos)
    {
        var s = (GPUParticles2D)sparkleScene.Instantiate();
        GetTree().CurrentScene.AddChild(s);
        s.GlobalPosition = pos;
        s.Emitting = true;
    }

    private void PlayExplosion(Vector2 pos)
    {
        var e = (GPUParticles2D)explosionScene.Instantiate();
        GetTree().CurrentScene.AddChild(e);
        e.GlobalPosition = pos;
        e.Emitting = true;
    }
}

