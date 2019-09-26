using Assets.Code.Monsters.ConcretteMonsters.Rank1;
using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters
{
    public class MonsterFactory
    {
        public A_Monster createNativeAirR1(MonstersData mData)
        {
            return new nativeAirR1(mData.monsterName, "R1", 10);
        }

        public A_Monster createNativeDarknessR1(MonstersData mData)
        {
            return new nativeDarknessR1(mData.monsterName, "R1", 10);
        }

        public A_Monster createNativeDeathR1(MonstersData mData)
        {
            return new nativeDeathR1(mData.monsterName, "R1", 10);
        }

        public A_Monster createNativeEarthR1(MonstersData mData)
        {
            return new nativeEarthR1(mData.monsterName, "R1", 10);
        }

        public A_Monster createNativeFireR1(MonstersData mData)
        {
            return new nativeFireR1(mData.monsterName, "R1", 10);
        }

        public A_Monster createNativeLifeR1(MonstersData mData)
        {
            return new nativeLifeR1(mData.monsterName, "R1", 10);
        }

        public A_Monster createNativeLightningR1(MonstersData mData)
        {
            return new nativeLightningR1(mData.monsterName, "R1", 10);
        }

        public A_Monster createNativeLightR1(MonstersData mData)
        {
            return new nativeLightR1(mData.monsterName, "R1", 10);
        }

        public A_Monster createNativePhysR1(MonstersData mData)
        {
            return new nativePhysR1(mData.monsterName, "R1", 10);
        }

        public A_Monster createNativeWaterR1(MonstersData mData)
        {
            return new nativeWaterR1(mData.monsterName, "R1", 10);
        }

    }
}
