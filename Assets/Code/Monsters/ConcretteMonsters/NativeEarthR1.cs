using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.ConcretteMonsters
{
    public class NativeEarthR1 : A_Monster, IMonster
    {
        public NativeEarthR1(string mName, string mRank, int mPrice, Dictionary<string, string> mParams, List<string> actions)
            : base(mName, mRank, mPrice)
        {

        }

    }
}
