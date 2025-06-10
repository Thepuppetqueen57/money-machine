using Godot;
using System;

public partial class BetAmountUpdater : LineEdit {
    static bool IsNumber(string s) {
        if (s == "" || s == "-") {
            return false;
        } else {
            foreach (char c in s) {
                if (!char.IsDigit(c) && c != '-') {
                    return false;
                }
            }
        }
        return true;
    }

    public override void _Process(double delta) {
        if (IsNumber(Text)) {
            if (int.Parse(Text) > Globals.Money) {
                Text = Globals.Money.ToString();
            }

            if (int.Parse(Text) < 0) {
                Text = "0";
            }
        }
    }
}
