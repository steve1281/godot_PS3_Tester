using Godot;
using System;

public partial class Shoulder : Node2D
{
    [Export] public Sprite2D LeftShoulder { get; private set; }
    [Export] public Sprite2D RightShoulder { get; private set; }

    public override void _Input(InputEvent @event)
    {
        LeftShoulder.Modulate = Colors.White;
        RightShoulder.Modulate = Colors.White;

        if (Input.IsActionPressed("right_shoulder"))
        {
            RightShoulder.Modulate = Colors.OrangeRed;
        }
        if (Input.IsActionPressed("left_shoulder"))
        {
            LeftShoulder.Modulate = Colors.OrangeRed;
        }
    }
}
