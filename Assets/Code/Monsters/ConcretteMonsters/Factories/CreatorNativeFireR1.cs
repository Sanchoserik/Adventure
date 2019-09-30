﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Monsters.ConcretteMonsters.Factories
{
    public class CreatorNativeFireR1 : IMonsterFactory
    {
        public IMonster createMonster(MonstersData mData) => new NativeFireR1(mData.monsterName, mData.monsterParameters["mRank"], Convert.ToInt32(mData.monsterParameters["mPrice"]),
                mData.monsterParameters, mData.monsterActionsList);
    }
}