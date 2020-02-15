using Godot;
using System;

[Tool]
public class Spinner : Control
{
    [Export]
    public Color color
    {
        get { return _color; }
        set { _color = value; Update(); }
    }

    private Color _color = new Color(1, 1, 1);

    public override void _Draw()
    {
        var radius = Math.Min(this.RectSize.x / 2, this.RectSize.y / 2);
        DrawCircle(new Vector2(0, 0), radius, this.color);
    }
}
