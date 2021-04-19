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
            Toolbar.Current.AddButton(FontIcon.FaSolid("\uf11b"), "Game Control", new WindowToolbarAction(() => GameControlFrame()));
            
        }

        private static Frame GameControlFrame()
        {
            Dialog val = Dialog.Create();
            val.Text = "Game Control";

            val.AddButton("Money Tab", ColorHelper.FromHexString("f7cf3c"), (Action)delegate
             {
                 FrameMoney frameMoney = new FrameMoney();
             }, false);

            val.AddButton("Speed Tab", ColorHelper.FromHexString("f58d2c"), (Action)delegate
            {
                FrameSpeed frameSpeed = new FrameSpeed();
            }, false);

            val.AddButton("Close", (Action)delegate
            {

            }, true);

            val.Show();
            return (Frame)(object)val;
        }

        protected override void OnUpdate()
        {
        }


        public static void SetGameSpeed(int gSpeed)
        {
            SpeedMultiplier = gSpeed;
            TimeControls.Current.TogglePause();
            TimeControls.Current.TogglePause();
        }

    }
}
