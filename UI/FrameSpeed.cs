using GameControl.Util;
using System;
using VoxelTycoon;
using VoxelTycoon.Modding;
using VoxelTycoon.UI;
using VoxelTycoon.UI.Windows;

namespace GameControl
{
    class FrameSpeed : Mod
    {
        public static Frame ShowFrame()
        {
            Dialog val = Dialog.Create();
            val.Text = "Game Control | Speed Tab\n\n" +
                      $"Current Speed Multiplier: {GameControl.SpeedMultiplier}x";

            val.AddButton("1X", ColorHelper.FromHexString("169403"), (Action)delegate
            {
                GameSpeed.SetGameSpeed(1);
            }, true);

            val.AddButton("2X", ColorHelper.FromHexString("869403"), (Action)delegate
            {
                GameSpeed.SetGameSpeed(2);
            }, true);

            val.AddButton("4X", ColorHelper.FromHexString("037e94"), (Action)delegate
            {
                GameSpeed.SetGameSpeed(4);
            }, true);

            val.AddButton("6X", ColorHelper.FromHexString("945f03"), (Action)delegate
            {
                GameSpeed.SetGameSpeed(6);
            }, true);

            val.AddButton("10X", ColorHelper.FromHexString("940303"), (Action)delegate
            {
                GameSpeed.SetGameSpeed(10);
            }, true);


            val.Show();
            return (Frame)(object)val;
        }


    }
}
