using Godot;
using System;

public partial class Crystal : Area2D
{
    public override void _Ready()
    {
        AddToGroup("Crystals");
    }

    public void Collect()
    {
        var gm = GetTree().Root.GetNode<GameManager>("/root/Main");
        gm.AddScore(1, GlobalPosition);
        QueueFree();
    }
}
