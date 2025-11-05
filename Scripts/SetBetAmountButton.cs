using Godot;
using System;

public partial class SetBetAmountButton : Button {
    [Export] public float MoneyPercentage = 100f;
    private void _on_button_up() {
        float NewBetAbout = (float)Math.Floor(Globals.Money * (MoneyPercentage / 100));
        GetNode<LineEdit>("/root/Gambling/Minigames/BetAmount/BetAmountTextbox").Text = NewBetAbout.ToString();
    }
}
