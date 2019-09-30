using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.Monsters.ConcretteMonsters.Rank1;
using Assets.Code.SystemScripts;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Monsters
{
    public class PackGenerator
    {
        public enum MonstersList
        {
            NativeAirR1, NativeDarknessR1, NativeDeathR1, NativeEarthR1, NativeFireR1, NativeLifeR1, NativeLightningR1, NativeLightR1, NativePhysR1, NativeWaterR1
        }

        public readonly Dictionary<MonstersList, MonsterFactory> mFactories;
        public readonly List<MonstersData> monstersDataList = ResourcesManager.monstersData;

        public PackGenerator()
        {
            mFactories = new Dictionary<MonstersList, MonsterFactory>();

            foreach (MonstersList monst in Enum.GetValues(typeof(MonstersList)))
            {     
                var factory = (MonsterFactory)Activator.CreateInstance(Type.GetType("Assets.Code.Monsters.ConcretteMonsters.Creator" + Enum.GetName(typeof(MonstersList), monst)));
                mFactories.Add(monst, factory);
            }
        }
   
        public void generatePack()
        {
        }

        private IMonster addMonster(MonstersList monster, MonstersData mData) => mFactories[monster].createMonster(mData);

    }
}
