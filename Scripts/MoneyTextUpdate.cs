using Godot;
using System;

public partial class MoneyTextUpdate : Label {
    public override void _Process(double delta) {
        Text = $"Money: {Globals.Money}";
    }
}
