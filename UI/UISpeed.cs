using System;
using VoxelTycoon;
using VoxelTycoon.Game.UI.ModernUI;
using VoxelTycoon.Modding;
using VoxelTycoon.UI;
using VoxelTycoon.UI.Windows;

namespace GameControl
{
    class UISpeed : Mod
    {
        public static Frame ShowFrame()
        {
            Dialog val = Dialog.Create();
            val.Text = "Game Control | Speed Tab\n\n" +
                      $"Current Speed Multiplier: {GameControl.SpeedMultiplier}x";

            val.AddButton("1X", (Action)delegate
            {
                GameControl.SetGameSpeed(1);
            }, true);

            val.AddButton("2X", (Action)delegate
            {
                GameControl.SetGameSpeed(2);
            }, true);

            val.AddButton("4X", (Action)delegate
            {
                GameControl.SetGameSpeed(4);
            }, true);

            val.AddButton("6X", (Action)delegate
            {
                GameControl.SetGameSpeed(6);
            }, true);

            val.AddButton("Close", (Action)delegate
            { }, true);

            val.Show();
            return (Frame)(object)val;
        }


    }
}
