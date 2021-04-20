using VoxelTycoon;
using VoxelTycoon.Modding;

namespace GameControl.Util
{
    class GameMoney : Mod
    {
        public static void CustomMoney(string input)
        {
            double doubleVal = 0;
            doubleVal = double.Parse(input);
            if(doubleVal < 1000001 || doubleVal > -1000001)
            {
                Company.Current.AddMoney(doubleVal, BudgetItem.Other, true);
            }
            
        }
    }
}
