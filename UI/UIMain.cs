using System;
using VoxelTycoon;
using VoxelTycoon.Game.UI.ModernUI;
using VoxelTycoon.Modding;
using VoxelTycoon.UI;
using VoxelTycoon.UI.Windows;

namespace GameControl
{
    class UIMain : Mod
    {
        public UIMain() {}
        public static Frame ShowFrame()
        {
            Dialog val = Dialog.Create();
            string companyName = Company.Current.Name;
            double companyMoney = Company.Current.Money;
            val.Text = "Game Control\n\n" +
                      $"Company Name: {companyName}\n" +
                      $"Company Money: {companyMoney}";

            val.AddButton("Money Tab", ColorHelper.FromHexString("f7cf3c"), (Action)delegate
            {
                UIMoney.ShowFrame();
            }, false);

            val.AddButton("Speed Tab", ColorHelper.FromHexString("f58d2c"), (Action)delegate
            {
                UISpeed.ShowFrame();
            }, false);

            val.AddButton("Close", (Action)delegate
            {

            }, true);

            val.Show();
            return (Frame)(object)val;
        }
    }
}
