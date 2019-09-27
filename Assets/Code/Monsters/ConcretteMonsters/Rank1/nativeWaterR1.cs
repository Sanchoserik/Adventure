using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.ConcretteMonsters.Rank1
{
    public class NativeWaterR1 : A_Monster, IMonster
    {
        public NativeWaterR1(string mName, string mRank, int mPrice, Dictionary<string, string> mParams, List<string> actions)
           : base(mName, mRank, mPrice)
        {

        }

        public A_Monster createMonster(MonstersData mData)
        {
            return new NativeWaterR1(mData.monsterName, mData.monsterParameters["mRank"], Convert.ToInt32(mData.monsterParameters["mPrice"]),
                mData.monsterParameters, mData.monsterActionsList);
        }
    }
}
