using BepInEx.Configuration;
using UnityEngine;

namespace VoidJumpKeybind
{
    internal class Configs
    {
        internal static ConfigEntry<KeyCode> LeverPullConfig;

        internal static void Load(BepinPlugin plugin)
        {
            LeverPullConfig = plugin.Config.Bind("VoidJumpKeybind", "PullLever", KeyCode.Y);
        }
    }
}
