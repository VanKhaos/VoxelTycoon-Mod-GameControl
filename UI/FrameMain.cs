
using System;
using VoxelTycoon;
using VoxelTycoon.Buildings;
using VoxelTycoon.Game.UI;
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

            val.AddButton("Headquarter", ColorHelper.FromHexString("32a852"), (Action)delegate
            {
                FrameHeadquarter.ShowFrame();
            }, false);

            val.AddButton("Money", ColorHelper.FromHexString("f7cf3c"), (Action)delegate
            {
                FrameMoney.ShowFrame();
            }, false);

            val.AddButton("Game Speed", ColorHelper.FromHexString("f58d2c"), (Action)delegate
            {
                FrameSpeed.ShowFrame();
            }, false);

            val.AddButton("Unlock research", ColorHelper.FromHexString("94038a"), (Action)delegate
            {
                LazyManager<ResearchManager>.Current.CompleteAll();
            }, false);


            val.AddButton("DEV BUTTON", (Action)delegate
            {
                Headquarters hq = Company.Current.Headquarters;
                hq.SetLevel(Company.Current.Headquarters.Level + 2);

            }, true);


            val.AddButton("Close", (Action)delegate
            {

            }, true);

            val.Show();
            return (Frame)(object)val;
        }
    }
}
