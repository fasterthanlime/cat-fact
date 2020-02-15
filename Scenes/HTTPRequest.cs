using Godot;
using Newtonsoft.Json;
using System;

class CatFact
{
    public string text { get; set; }
}

public class HTTPRequest : Godot.HTTPRequest
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        this.Owner.GetNode<Control>("UI/Title").Visible = false;

        var res = this.Request("https://cat-fact.herokuapp.com/facts/random");
        if (res != Error.Ok)
        {
            GD.Print($"HTTP request error {res}");
        }
        else
        {
            GD.Print("HTTP request went fine");
        }
    }

    public void OnCompleted(int result, int status, string[] headers, byte[] body)
    {
        var bodyString = System.Text.Encoding.UTF8.GetString(body);
        var catFact = JsonConvert.DeserializeObject<CatFact>(bodyString);
        this.Owner.GetNode<Godot.RichTextLabel>("UI/Text").Text = catFact.text;
        this.Owner.GetNode<Control>("UI/Title").Visible = true;
        this.Owner.GetNode<Control>("UI/SpinnerGroup").Visible = false;
    }
}