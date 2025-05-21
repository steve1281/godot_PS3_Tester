using Godot;
using System;

public partial class Sticks : Node2D
{
    [Export] public Sprite2D LeftStick { get; private set; }
    [Export] public Sprite2D RightStick { get; private set; }

    public override void _Input(InputEvent @event)
    {
        LeftStick.Modulate = Colors.White;
        RightStick.Modulate = Colors.White;

        if (Input.IsActionPressed("right_stick"))
        {
            RightStick.Modulate = Colors.OrangeRed;
        }
        if (Input.IsActionPressed("left_stick"))
        {
            LeftStick.Modulate = Colors.OrangeRed;
        }
    }
}
