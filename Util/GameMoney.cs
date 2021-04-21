using VoxelTycoon;
using VoxelTycoon.Modding;

namespace GameControl.Util
{
    class GameMoney : Mod
    {
        public static void CustomMoney(string input)
        {
            double doubleVal = double.Parse(input);
            double maxVal = 5000001.0;
            double minVal = -5000001.0;

            if(doubleVal < maxVal && doubleVal > minVal)
            {
                Company.Current.AddMoney(doubleVal, BudgetItem.Other, true);
            }
            
        }
    }
}
