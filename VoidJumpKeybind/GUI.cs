using UnityEngine;
using VoidManager.CustomGUI;

namespace VoidJumpKeybind
{
    internal class GUI : ModSettingsMenu
    {
        public override string Name() => "Void Jump Keybind";

        public override void Draw()
        {
            KeyCode keyCode = Configs.LeverPullConfig.Value;
            if (IMGUIPrefabs.ChangeKeybindButton("Change Keybind", ref keyCode))
            {
                Configs.LeverPullConfig.Value = keyCode;
            }
        }
    }
}
