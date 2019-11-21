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
        private struct diversityValues
        {
            public int fightersR1;
            public int fightersR2;
            public int fightersR3;

            public int castersR1;
            public int castersR2;
            public int castersR3;

            public diversityValues(int f1, int f2, int f3, int c1, int c2, int c3)
            {
                fightersR1 = f1;
                fightersR2 = f2;
                fightersR3 = f3;

                castersR1 = c1;
                castersR2 = c2;
                castersR3 = c3;
            }
        }
        private enum MonstersList
        {
            NativeAirR1, NativeDarknessR1, NativeDeathR1, NativeEarthR1, NativeFireR1, 
            NativeLifeR1, NativeLightningR1, NativeLightR1, NativePhysR1, NativeWaterR1
        }

        public enum PackTypes
        { 
            //Low level
            Fighters, Casters,
            FightersSupCasters, CastersSupFighters, Balanced,
            //low middle level
            FightersSupAdcancedFighters, FightersSupAdvancedCasters,
            CastersSupAdvancedCasters, CastersSupAdvancedFighters,
            MoreLowLessAdvancedBalanced,
            //middle level
            AdvancedFighters, AdvancedCasters,
            AdvancedFightersSupCasters, AdvancedCastersSupFighters, AdvancedBalanced, 
            AdvancedFightersSupLowCasters, AdvancedCastersSupLowFighters, MoreAdvancedLessLowBalanced,
            AdvancedFightersSupLowFighters, AdvancedCastersSupLowCasters,
            //high middle level
            AdvancedFightersSupEliteFighters, AdvancedFightersSupEliteCasters,
            AdvancedCastersSupEliteCasters, AdvancedCastersSupEliteFighters,
            MoreAdvancedLessEliteBalanced,
            // high level
            EliteFighters, EliteCasters,
            EliteBalanced,
            EliteFightersSupAdvancedCasters, EliteCastersSupAdvancedFighters, MoreEliteLessAdvancedBalanced,
            EliteFightersSupAdvancedFighters, EliteCastersSupAdvancedCasters,

            Boss
                // For bosses: later there will be concrette pregenerated packs  
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
           
        public void getPack(int packCost, PackTypes packType 
            )
        {
            List<MonstersData> selectedMTypes = selectMTypes(packType);                          
            generatedPack = generatePack(packCost, selectedMTypes, packType);         
        }

        private List<MonstersData> selectMTypes(PackTypes packType)
        {
            List<MonstersData> mData = new List<MonstersData>();
         
            if (packType == PackTypes.Fighters || packType == PackTypes.Casters)
            {
                foreach (MonstersData data in monstersDataList)
                {

                    if (data.monsterParameters["mType"].Equals(packType.ToString()))
                    {
                        mData.Add(data);
                    }
                }
            }
            else            
            if (packType == PackTypes.Balanced || packType == PackTypes.CastersSupFighters
                || packType == PackTypes.FightersSupCasters)
            {
                foreach (MonstersData data in monstersDataList)
                    mData.Add(data);
            }
            else
            if (packType == PackTypes.Boss)
            {

            }

            //remove wrong ranks 
            checkMranks(mData, packType);

            return mData;
        }

        private void checkMranks(List<MonstersData> mData, PackTypes packType)
        {
            switch (packType)
            {
                case PackTypes.Fighters: { removeRanks(new int[] { 2, 3 }, mData); break; }
                case PackTypes.Casters: { removeRanks(new int[] { 2, 3 }, mData); break; }
                case PackTypes.Balanced: { removeRanks(new int[] { 2, 3 }, mData); break; }
                case PackTypes.FightersSupCasters: { removeRanks(new int[] { 2, 3 }, mData); break; }
                case PackTypes.CastersSupFighters: { removeRanks(new int[] { 2, 3 }, mData); break; }
            }
        }

        private void removeRanks(int[] ranks, List<MonstersData> mData)
        {
                foreach (int notAllowedRank in ranks)
                {
                 mData.RemoveAll(data => Convert.ToInt32(data.monsterParameters["mRank"]) == notAllowedRank);
                }           
        }

        private List<A_Monster> generatePack(int packCost, List<MonstersData> selectedMTypes, PackTypes packType)
        {
            List<A_Monster> generatedMonsters = new List<A_Monster>();           
            diversityValues divValues = getDiversityValues(packType);

            diversityValues actualCostValues = new diversityValues(
                getSubPackCost(packCost, divValues.fightersR1), getSubPackCost(packCost, divValues.fightersR2), getSubPackCost(packCost, divValues.fightersR3),
                getSubPackCost(packCost, divValues.castersR1), getSubPackCost(packCost, divValues.castersR2), getSubPackCost(packCost, divValues.castersR3));

            int[] costValuesArray = new int[6] {
                actualCostValues.fightersR1, actualCostValues.fightersR2, actualCostValues.fightersR3,
                actualCostValues.castersR1, actualCostValues.castersR2, actualCostValues.castersR3
            };

            for (int i = 0; i < costValuesArray.Length; ++i)
            {
                if (costValuesArray[i] > 0)
                    generateToCost(i, costValuesArray[i], selectedMTypes, generatedMonsters);

            }
            return generatedMonsters;
        }

        private void generateToCost(int selectionIndex, int subPackCost, List<MonstersData> mData, List<A_Monster> generatedMonsters)
        {
            Random random = new Random();            
            List<MonstersData> subMData = selectSubPackData(selectionIndex, mData);
            int minimumCost = Convert.ToInt32(subMData[0].monsterParameters["mPrice"]);

            foreach (MonstersData data in subMData)
            {
                if (minimumCost > Convert.ToInt32(data.monsterParameters["mPrice"]))
                    minimumCost = Convert.ToInt32(data.monsterParameters["mPrice"]);
            }

            if (subPackCost >= minimumCost)
            {
                while (subPackCost >= minimumCost)
                {
                    int randIndex = random.Next(0, subMData.Count - 1);
                    int mPrice = Convert.ToInt32(subMData[randIndex].monsterParameters["mPrice"]);
                    if (subPackCost >= mPrice)
                    {
                        generatedMonsters.Add(mFactories[(MonstersList)Enum.Parse(typeof(MonstersList),
                            subMData[randIndex].monsterName)].createMonster(subMData[randIndex]));
                        subPackCost -= mPrice;
                    }

                }
            }
            else // if val < minimum price generate one random enemy
            {
                int randIndex = random.Next(0, subMData.Count - 1);
                generatedMonsters.Add(mFactories[(MonstersList)Enum.Parse(typeof(MonstersList),
                            subMData[randIndex].monsterName)].createMonster(subMData[randIndex]));
            }
        }

        private List<MonstersData> selectSubPackData(int selectionIndex, List<MonstersData> mData)
        {         
            string rankToSelect = "";
            string typeToSelect = "";
            switch (selectionIndex)
            {
                case 0: {
                        rankToSelect = "1";
                        typeToSelect = "Fighters"; break;
                    }
                case 1:
                    {
                        rankToSelect = "2";
                        typeToSelect = "Fighters"; break;
                    }
                case 2:
                    {
                        rankToSelect = "3";
                        typeToSelect = "Fighters"; break;
                    }
                case 3:
                    {
                        rankToSelect = "1";
                        typeToSelect = "Casters"; break;
                    }
                case 4:
                    {
                        rankToSelect = "2";
                        typeToSelect = "Casters"; break;
                    }
                case 5:
                    {
                        rankToSelect = "3";
                        typeToSelect = "Casters"; break;
                    }                
            }
            return (from data in mData
                    where data.monsterParameters["mRank"].Equals(rankToSelect)
                    where data.monsterParameters["mType"].Equals(typeToSelect)
                    select data).ToList();
        }

        private int getSubPackCost(int totalCost, int subPackPercent)
            => totalCost * subPackPercent>0 ? totalCost * subPackPercent/ 100 : 0;
   
        private diversityValues getDiversityValues(PackTypes packType)
        {
            switch (packType)
            {
                case PackTypes.Fighters: { return new diversityValues(100, 0, 0, 0, 0, 0); }
                case PackTypes.Casters: { return new diversityValues(0, 0, 0, 100, 0, 0); }
                case PackTypes.Balanced: { return new diversityValues(50, 0, 0, 50, 0, 0); }
                case PackTypes.FightersSupCasters: { return new diversityValues(80, 0, 0, 20, 0, 0); }
                case PackTypes.CastersSupFighters: { return new diversityValues(20, 0, 0, 80, 0, 0); }
                default: return new diversityValues(0, 0, 0, 0, 0, 0);
            }          
        }
        private A_Monster addMonster(MonstersList monster, MonstersData mData) => mFactories[monster].createMonster(mData);

    }
}
