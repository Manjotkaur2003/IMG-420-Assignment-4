using Godot;

public partial class ParticleManager : Node
{
    private static ParticleManager _instance;

    public override void _Ready() => _instance = this;

    public static void SpawnParticles(PackedScene scene, Vector2 position)
    {
        if (_instance == null) return;
        var p = (GPUParticles2D)scene.Instantiate();
        _instance.GetTree().CurrentScene.AddChild(p);
        p.GlobalPosition = position;
        p.Emitting = true;
    }
}
