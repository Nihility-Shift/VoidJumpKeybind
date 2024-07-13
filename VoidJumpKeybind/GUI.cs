using VoidManager.CustomGUI;
using VoidManager.Utilities;

namespace VoidJumpKeybind
{
    internal class GUI : ModSettingsMenu
    {
        public override string Name() => "Void Jump Keybind";

        public override void Draw()
        {
            GUITools.DrawChangeKeybindButton("Change Void Jump Keybind", ref Configs.LeverPullConfig);
        }
    }
}
