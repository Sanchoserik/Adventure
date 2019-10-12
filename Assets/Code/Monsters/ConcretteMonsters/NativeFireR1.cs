using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.ConcretteMonsters
{
    public class NativeFireR1 : A_Monster
    {
        int overchargeIndicatorMax = 5;
        int overchargeIndicatorIncr = 1;
        int overvhargeIndicatorCurrent = 0;

        public NativeFireR1(string mName, string mRank, int mPrice, Dictionary<string, string> mParams, List<string> actions)
            : base(mName, mRank, mPrice)
        {

        }

     
    }
}
