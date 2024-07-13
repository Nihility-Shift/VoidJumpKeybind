using BepInEx;
using CG;
using CG.Game;
using CG.Input;
using CG.Ship.Modules;
using HarmonyLib;
using Photon.Pun;

namespace VoidJumpKeybind
{
    [HarmonyPatch(typeof(VoidDriveModule))]
    internal class VoidDriveModulePatch
    {
        private static bool isKeyPressed = false;

        [HarmonyPostfix]
        [HarmonyPatch("FixedUpdate")]
        static void FixedUpdate(VoidDriveModule __instance)
        {
            TakeoverChair chair = ClientGame.Current.PlayerShip?.GetModule<Helm>()?.Chair as TakeoverChair;
            if (chair == null || chair.IsAvailable || PhotonNetwork.LocalPlayer != chair.photonView.Owner ||
                ServiceBase<InputService>.Instance.CursorVisibilityControl.IsCursorShown)
            {
                if (isKeyPressed)
                {
                    isKeyPressed = false;
                    __instance.VoidJumpLever.EndClick();
                }
                return;
            }

            if (Configs.LeverPullConfig.Value == UnityEngine.KeyCode.None || isKeyPressed == UnityInput.Current.GetKey(Configs.LeverPullConfig.Value)) return;

            isKeyPressed = !isKeyPressed;

            if (isKeyPressed)
            {
                __instance.VoidJumpLever.StartClick();
            }
            else
            {
                __instance.VoidJumpLever.EndClick();
            }
        }
    }
}
