﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Monsters.ConcretteMonsters.Factories
{
    public class CreatorNativePhysR1 : IMonsterFactory
    {
        public A_Monster createMonster(MonstersData mData) => new NativePhysR1(mData.monsterName, mData.monsterParameters["mRank"], Convert.ToInt32(mData.monsterParameters["mPrice"]),
              mData.monsterParameters, mData.monsterActionsList);
    }
}
