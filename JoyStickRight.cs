using Godot;
using System;

public partial class JoyStickRight : JoyStick
{

    public override void _Input(InputEvent @event)
    {
        Vector2 velocity = new Vector2(
            Input.GetActionStrength("right_joy_right") - Input.GetActionStrength("right_joy_left"),
            Input.GetActionStrength("right_joy_down") - Input.GetActionStrength("right_joy_up")
        ).LimitLength(1);

        if (velocity != v)
        {
            v = velocity;
            label.Text = v.ToString();
            QueueRedraw();
        }
    }
}
