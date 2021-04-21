using System;
using System.Collections.Generic;
using System.Text;
using VoxelTycoon;
using VoxelTycoon.Buildings;
using VoxelTycoon.Modding;

namespace GameControl.Util
{
    class GameHeadquarter : Mod
    {
        
        public static void LevelUp()
        {
            Headquarters hq = Company.Current.Headquarters;
            hq.SetLevel(hq.Level + 1);
        }

        public static void RenameCompany(string s)
        {
            Company.Current.Name = s;
        }
    }
}
