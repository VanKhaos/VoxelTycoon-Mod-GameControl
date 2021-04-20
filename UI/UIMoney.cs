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
    class UIMoney : Mod
    {
        public static Frame ShowFrame()
        {
            Dialog val = Dialog.Create();

            double moneyX = 500000.00;


            val.Text = "Game Control | Money Tab\n\n" +
                       $"Company Money: {Company.Current.Money}";

            val.AddPositiveButton("+ 500.000", (Action)delegate
            {
                Company.Current.AddMoney(moneyX, (BudgetItem)0, true);
            }, false);

            val.AddNegativeButton("- 500.000", (Action)delegate
            {
                Company.Current.AddMoney(-moneyX, (BudgetItem)0, true);
            }, false);

            val.AddButton("Close", (Action)delegate
            {

            }, true);

            val.Show();
            return (Frame)(object)val;
        }
    }
}
