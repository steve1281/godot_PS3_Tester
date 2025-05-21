using Godot;
using System;

public partial class RightPad : Node
{
    [Export] public Sprite2D Triangle { get; private set; }
    [Export] public Sprite2D Square { get; private set; }
    [Export] public Sprite2D Circle { get; private set; }
    [Export] public Sprite2D Cross { get; private set; }

    public override void _Ready()
    {
    }

    public override void _Input(InputEvent @event)
    {
        Triangle.Modulate = Colors.White;
        Square.Modulate = Colors.White;
        Circle.Modulate = Colors.White;
        Cross.Modulate = Colors.White;

        if (Input.IsActionPressed("triangle_button"))
        {
            Triangle.Modulate = Colors.OrangeRed;
        }
        if (Input.IsActionPressed("square_button"))
        {
            Square.Modulate = Colors.OrangeRed;
        }
        if (Input.IsActionPressed("circle_button"))
        {
            Circle.Modulate = Colors.OrangeRed;
        }
        if (Input.IsActionPressed("cross_button"))
        {
            Cross.Modulate = Colors.OrangeRed;
        }
    }

}
