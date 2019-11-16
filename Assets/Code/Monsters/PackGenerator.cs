using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.Monsters.ConcretteMonsters.Factories;
using Assets.Code.SystemScripts;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Monsters
{
    public class PackGenerator
    {
        private enum MonstersList
        {
            NativeAirR1, NativeDarknessR1, NativeDeathR1, NativeEarthR1, NativeFireR1, 
            NativeLifeR1, NativeLightningR1, NativeLightR1, NativePhysR1, NativeWaterR1
        }

        public enum PackTypes
        { 
           Fighters, Casters, Balanced, Boss  
        }

        private readonly Dictionary<MonstersList, IMonsterFactory> mFactories;      
        private readonly List<MonstersData> monstersDataList = ResourcesManager.monstersData;

        public List<A_Monster> generatedPack;

        public PackGenerator()
        {
            generatedPack = new List<A_Monster>();
            mFactories = new Dictionary<MonstersList, IMonsterFactory>();

            foreach (MonstersList monst in Enum.GetValues(typeof(MonstersList)))
            {     
                var factory = (IMonsterFactory)Activator.CreateInstance(Type.GetType("Assets.Code.Monsters.ConcretteMonsters.Factories.Creator" + Enum.GetName(typeof(MonstersList), monst)));
                mFactories.Add(monst, factory);
            }
        }
           
        public void generatePack(int packCost,
            PackTypes packType,  int maxRank, 
            int battlefieldSizeX, int battlefieldSizeY 
            )
        {
            switch (packType.ToString())
            {
                case "Fighters": {
                        List<MonstersData> selectedMTypes = selectMTypes(maxRank, packType);
                        generateFightersPack(packCost, battlefieldSizeX, battlefieldSizeY, selectedMTypes);
                        break;
                    }
            }
        }

        private void generateFightersPack(int packCost, int battlefieldSizeX, int battlefieldSizeY, List<MonstersData> selectedMTypes)
        {
            Random random = new Random();
            
            List<A_Monster> generatedMosters = new List<A_Monster>();

            int minumumCost = Convert.ToInt32(selectedMTypes[0].monsterParameters["mPrice"]);
            foreach (MonstersData data in selectedMTypes)
            {
                if (minumumCost > Convert.ToInt32(data.monsterParameters["mPrice"]))
                    minumumCost = Convert.ToInt32(data.monsterParameters["mPrice"]);
            }

            while (packCost >= minumumCost)
            {
                int randIndex = random.Next(0, selectedMTypes.Count - 1);
                int mPrice = Convert.ToInt32(selectedMTypes[randIndex].monsterParameters["mPrice"]);

                if (packCost >= mPrice)
                {
                    MonstersList s1 = (MonstersList)Enum.Parse(typeof(MonstersList), selectedMTypes[randIndex].monsterName);

                    generatedMosters.Add(mFactories[(MonstersList)Enum.Parse(typeof(MonstersList), 
                        selectedMTypes[randIndex].monsterName)].createMonster(selectedMTypes[randIndex])); 
                    packCost -= mPrice;
                }
                
            }
            generatedPack = generatedMosters;
        }

        private List<MonstersData> selectMTypes(int maxRank, PackTypes packType)
        {
            List<MonstersData> mData = new List<MonstersData>();

            foreach (MonstersData data in monstersDataList)
            {
                if (Convert.ToInt32(data.monsterParameters["mRank"]) <= maxRank &&
                    data.monsterParameters["mType"].Equals("Fighter"))
                {
                    mData.Add(data);
                }
            }

            return mData;
        }


        private A_Monster addMonster(MonstersList monster, MonstersData mData) => mFactories[monster].createMonster(mData);

    }
}
