using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Monsters.ConcretteMonsters.Rank1
{
    public class CreatorNativeDarknessR1 : MonsterFactory
    {
        public override IMonster createMonster(MonstersData mData) => new NativeDarknessR1(mData.monsterName, mData.monsterParameters["mRank"], Convert.ToInt32(mData.monsterParameters["mPrice"]),
              mData.monsterParameters, mData.monsterActionsList);
    }
}
