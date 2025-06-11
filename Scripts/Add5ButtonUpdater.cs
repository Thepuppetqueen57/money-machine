using Godot;
using System;

public partial class Add5ButtonUpdater : Button {
    public override void _Process(double delta) {
        if (Globals.Money > 0) {
            Disabled = true;
        } else {
            Disabled = false;
        }
    }

    private void _on_button_up() {
        Globals.Money = 5;
    }
}
