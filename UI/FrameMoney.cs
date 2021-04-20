using GameControl.Util;
using System;
using VoxelTycoon;
using VoxelTycoon.Modding;
using VoxelTycoon.UI;
using VoxelTycoon.UI.Windows;

namespace GameControl
{
    class FrameMoney : Mod
    {
        public static Frame ShowFrame()
        {
            Dialog val = Dialog.Create();
            Action<String> myAction = new Action<String>(a => { });

            double money = 500000.00;

            val.Text = "Game Control | Money Tab\n\n" +
                       "";

            val.AddPositiveButton("+ 500.000", (Action)delegate
            {
                Company.Current.AddMoney(money, BudgetItem.Other, true);
            }, false);

            val.AddNegativeButton("- 500.000", (Action)delegate
            {
                Company.Current.AddMoney(-money, BudgetItem.Other, true);
            }, false);

            val.AddButton("Custom", ColorHelper.FromHexString("041887"), (Action)delegate
            {
                InputDialog input = InputDialog.ShowFor("How much do you want ?\n\n" +
                                                        "Max: 1.000.000\n" +
                                                        "Min: -1.000.000\n" +
                                                        "Enter without dot (.)", "50000", new Action<String>(a => {
                                                            GameMoney.CustomMoney(a.ToString()); 
                                                        }));                 
            }, true);


            val.AddButton("Close", (Action)delegate{}, true);

            val.Show();
            return (Frame)(object)val;
        }
    }
}
