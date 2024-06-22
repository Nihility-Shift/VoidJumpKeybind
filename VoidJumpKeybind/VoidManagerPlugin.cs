using VoidManager.MPModChecks;

namespace VoidJumpKeybind
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.Client;

        public override string Author => "18107";

        public override string Description => "Adds a keybind for the pilot to activate the void jump lever";
    }
}
