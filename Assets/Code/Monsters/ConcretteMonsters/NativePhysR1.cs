using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.ConcretteMonsters
{
    public class NativePhysR1 : A_Monster, IMonster
    {
        public NativePhysR1(string mName, string mRank, int mPrice, Dictionary<string, string> mParams, List<string> actions)
           : base(mName, mRank, mPrice)
        {

        }

        public A_Monster createMonster(MonstersData mData)
        {
            return new NativePhysR1(mData.monsterName, mData.monsterParameters["mRank"], Convert.ToInt32(mData.monsterParameters["mPrice"]),
                mData.monsterParameters, mData.monsterActionsList);
        }
    }
}
