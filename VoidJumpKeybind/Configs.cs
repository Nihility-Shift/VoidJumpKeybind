using BepInEx.Configuration;
using UnityEngine;

namespace VoidJumpKeybind
{
    internal class Configs
    {
        internal const KeyCode LeverPullDefaultKey = KeyCode.Y;
        internal static ConfigEntry<KeyCode> LeverPullConfig;

        internal static void Load(BepinPlugin plugin)
        {
            LeverPullConfig = plugin.Config.Bind("VoidJumpKeybind", "PullLever", LeverPullDefaultKey, "");
        }
    }
}
