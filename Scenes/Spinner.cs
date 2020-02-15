using Godot;
using System;

[Tool]
public class Spinner : Control
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    private float _radius = 40;

    [Export]
    public float radius {
        get { return _radius; }
        set { _radius = value; Update(); }
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public override void _Draw() {
        // DrawCircle(new Vector2(this.radius, this.radius), this.radius, new Color("#000"));
        var radius = Math.Min(this.RectSize.x/2, this.RectSize.y/2);
        DrawCircle(new Vector2(radius, radius), radius, new Color("#000000"));
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
