using Godot;
using System;

public class Text : RichTextLabel
{
    public override void _Ready()
    {
        // this will be replaced by the HTTP Request when it completes
        Text = "";
    }
}