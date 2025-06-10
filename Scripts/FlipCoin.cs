using Godot;
using System;

public partial class FlipCoin : Button {
    private void _on_button_up() {
        int BetAmount = int.Parse(GetNode<LineEdit>("/root/Root/CenterContainer/Control/CoinFlipContainer/BetAmountTextbox").Text);

        int WinOrLose = new Random().Next(0, 2);

        if (WinOrLose == 0) {
            Globals.Money -= BetAmount;
        } else if (WinOrLose == 1) {
            Globals.Money += BetAmount;
        }
    }
}
