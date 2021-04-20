using HarmonyLib;
using System;
using UnityEngine;
using VoxelTycoon;
using VoxelTycoon.Game.UI.ModernUI;
using VoxelTycoon.Modding;
using VoxelTycoon.UI;
using VoxelTycoon.UI.Windows;

namespace GameControl
{
    // Main Class
    public class GameControl : Mod
    {
        private static int speedMultiplier = 1;
        public static int SpeedMultiplier { get => speedMultiplier; set => speedMultiplier = value; }

        protected override void Initialize()
        {
            Harmony val = (Harmony)(object)new Harmony("de.gamecontrol.patch");
            val.PatchAll();
        }

        protected override void OnGameStarted()
        {
            SpeedMultiplier = 1;
            Toolbar.Current.AddButton(FontIcon.FaSolid("\uf11b"), "Game Control", new WindowToolbarAction(() => FrameMain.ShowFrame()));
        }

    }
}
