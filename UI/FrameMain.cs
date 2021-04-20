using System;
using VoxelTycoon;
using VoxelTycoon.Modding;
using VoxelTycoon.Researches;
using VoxelTycoon.UI;
using VoxelTycoon.UI.Windows;

namespace GameControl
{
    class FrameMain : Mod
    {
        public FrameMain() {}
        public static Frame ShowFrame()
        {
            Dialog val = Dialog.Create();
            string companyName = Company.Current.Name;
            double companyMoney = Company.Current.Money;
            val.Text = "Game Control\n\n" +
                      $"Company Name: {companyName}\n";

            val.AddButton("Money Tab", ColorHelper.FromHexString("f7cf3c"), (Action)delegate
            {
                FrameMoney.ShowFrame();
            }, false);

            val.AddButton("Unlock All", ColorHelper.FromHexString("94038a"), (Action)delegate
            {
                LazyManager<ResearchManager>.Current.CompleteAll();
            }, false);

            val.AddButton("Speed Tab", ColorHelper.FromHexString("f58d2c"), (Action)delegate
            {
                FrameSpeed.ShowFrame();
            }, false);

            val.AddButton("Close", (Action)delegate
            {

            }, true);

            val.Show();
            return (Frame)(object)val;
        }
    }
}
