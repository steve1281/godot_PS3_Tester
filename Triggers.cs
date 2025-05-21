using Godot;
using System;

public partial class Triggers : Node2D
{
    [Export] public Sprite2D LeftTrigger { get; private set; }
    [Export] public Sprite2D RightTrigger { get; private set; }

    public override void _Input(InputEvent @event)
    {
        LeftTrigger.Modulate = Colors.White;
        RightTrigger.Modulate = Colors.White;

        if (Input.IsActionPressed("right_trigger"))
        {
            RightTrigger.Modulate = Colors.OrangeRed;
        }
        if (Input.IsActionPressed("left_trigger"))
        {
            LeftTrigger.Modulate = Colors.OrangeRed;
        }
    }
}
