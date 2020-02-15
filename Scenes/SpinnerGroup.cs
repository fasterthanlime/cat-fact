using Godot;
using System;
using System.Collections.Generic;

public class SpinnerGroup : Control
{
    private const int NumDots = 12;

    private List<Control> Dots = new List<Control>();
    private float t = 0;
    private float speed = 1.5f;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        var template = ResourceLoader.Load("res://Scenes/Spinner.tscn") as PackedScene;

        for (int i = 0; i < NumDots; i++)
        {
            var dup = template.Instance() as Control;
            this.AddChild(dup);
            this.Dots.Add(dup);
        }
        GD.Print($"Made {this.Dots.Count} dots");

        for (int i = 0; i < this.Dots.Count; i++)
        {
            var dot = this.Dots[i];
            dot.RectPosition = new Vector2(i * 50, 0);
            GD.Print($"Rect position = {dot.RectPosition}");
        }
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        var center = RectSize * 0.5f;
        var distance = Math.Max(RectSize.x, RectSize.y) * 0.5f;
        t += delta * this.speed;

        for (int i = 0; i < this.Dots.Count; i++)
        {
            var nodeT = t + (i * 2 * Math.PI / this.Dots.Count);
            var x = Math.Cos(nodeT) * distance;
            var y = Math.Sin(nodeT) * distance;
            var dot = this.Dots[i];
            dot.RectPosition = center + new Vector2((float)x, (float)y);
        }
    }
}
