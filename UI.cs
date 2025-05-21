using Godot;
using System;

public partial class UI : Control
{
    [Export] public Button ExitButton { get; private set; }

    public override void _Ready()
    {
        ExitButton.Pressed += HandleExitButtonPressed;
    }

    private void HandleExitButtonPressed()
    {
        ExitButton.Pressed -= HandleExitButtonPressed;
        GetTree().Quit();
    }
}
