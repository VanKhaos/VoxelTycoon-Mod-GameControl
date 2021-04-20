using HarmonyLib;
using VoxelTycoon.Game.UI.ModernUI;

namespace GameControl.Util
{
    class GameSpeed
    {
        [HarmonyPatch(typeof(TimeControls))]
        [HarmonyPatch("ToFloat")]
        internal class TimeControls_ToFloat_GameControlPatch
        {
            private static void Postfix(ref float __result)
            {
                __result *= GameControl.SpeedMultiplier;
            }
        }
        public static void SetGameSpeed(int gSpeed)
        {
            GameControl.SpeedMultiplier = gSpeed;
            TimeControls.Current.TogglePause();
            TimeControls.Current.TogglePause();
        }
    }
}
