using GameControl.Util;
using System;
using System.Collections.Generic;
using System.Text;
using VoxelTycoon;
using VoxelTycoon.Buildings;
using VoxelTycoon.Modding;
using VoxelTycoon.UI;
using VoxelTycoon.UI.Windows;

namespace GameControl
{
    class FrameHeadquarter : Mod
    {
        public static Frame ShowFrame()
        {
            Dialog val = Dialog.Create();
            Action<String> myAction = new Action<String>(a => { });

            val.Text = "Game Control | Headquarter\n\n" +
                       "";

            val.AddButton("Rename", ColorHelper.FromHexString("3d0c87"), (Action)delegate
            {
                InputDialog input = InputDialog.ShowFor("Rename your Company", $"{Company.Current.Name}", new Action<String>(a => {
                                                            GameHeadquarter.RenameCompany(a.ToString());
                                                        }));
            }, true);

            val.AddButton("Level Up", ColorHelper.FromHexString("041887"), (Action)delegate
            {
                GameHeadquarter.LevelUp();
            }, false);

            val.AddButton("Close", (Action)delegate { }, true);

            val.Show();
            return (Frame)(object)val;
        }
    }
}
