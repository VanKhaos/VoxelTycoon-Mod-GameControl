using System;
using VoxelTycoon;
using VoxelTycoon.Modding;
using VoxelTycoon.UI.Windows;

namespace GameControl
{
    class FrameMoney : Mod
    {
        public FrameMoney()
        {
            Dialog val = Dialog.Create();
            Company current = Company.Current;
            
            
            val.Text = "Game Control | Money Tab\n\n" +
                       $"Current Money: ";

            val.AddPositiveButton("+ 500.000", (Action)delegate
            {
                current.AddMoney(500000.0, (BudgetItem)0, true);
            }, false);

            val.AddNegativeButton("- 500.000", (Action)delegate
            {
                current.AddMoney(-500000.0, (BudgetItem)0, true);
            }, false);

            val.AddButton("Close", (Action)delegate
            {
                
            }, true);

            val.Show();
        }
    }
}
