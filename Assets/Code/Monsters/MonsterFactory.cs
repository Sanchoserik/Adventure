﻿using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters
{
    public abstract class MonsterFactory
    {
        public abstract IMonster createMonster(MonstersData mData);
    }
}