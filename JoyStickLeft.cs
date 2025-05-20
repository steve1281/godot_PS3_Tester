using Godot;
using System;

public partial class JoyStickLeft : JoyStick
{
    public override void _Input(InputEvent @event)
    {
        Vector2 velocity = new Vector2(
            Input.GetActionStrength("ui_right") - Input.GetActionStrength("ui_left"),
            Input.GetActionStrength("ui_down") - Input.GetActionStrength("ui_up")
        ).LimitLength(1);

        if (velocity != v)
        {
            v = velocity;
            label.Text = v.ToString();
            QueueRedraw();
        }
    }

}
