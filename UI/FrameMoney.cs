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
            double money = 500000.00;

            val.Text = "Game Control | Money Tab\n\n" +
                       $"Company Money: {Company.Current.Value}";

            val.AddPositiveButton("+ 500.000", (Action)delegate
            {
                Company.Current.AddMoney(money, BudgetItem.Other, true);
            }, false);

            val.AddNegativeButton("- 500.000", (Action)delegate
            {
                Company.Current.AddMoney(-money, BudgetItem.Other, true);
            }, false);

            val.AddButton("Close", (Action)delegate
            {

            }, true);

            val.Show();
            return (Frame)(object)val;
        }
    }
}
