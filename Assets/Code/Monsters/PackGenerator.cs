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
           
        public void getPack(int packCost,
            PackTypes packType, int battlefieldSizeX, int battlefieldSizeY 
            )
        {
            List<MonstersData> selectedMTypes = selectMTypes(packType);          
            
            int minimumCost = Convert.ToInt32(selectedMTypes[0].monsterParameters["mPrice"]);
            
            foreach (MonstersData data in selectedMTypes)
            {
                if (minimumCost > Convert.ToInt32(data.monsterParameters["mPrice"]))
                    minimumCost = Convert.ToInt32(data.monsterParameters["mPrice"]);
            }
             
            generatedPack = generatePack(packCost, minimumCost, selectedMTypes, packType);
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

        private List<A_Monster> generatePack(int packCost, int minimumCost, List<MonstersData> selectedMTypes, PackTypes packType)
        {
            List<A_Monster> generatedMonsters = new List<A_Monster>();
            Random random = new Random();

            int castersPrice;
            int fightersPrice;



            while (packCost >= minimumCost)
            {
                int randIndex = random.Next(0, selectedMTypes.Count - 1);
                int mPrice = Convert.ToInt32(selectedMTypes[randIndex].monsterParameters["mPrice"]);

                if (packCost >= mPrice)
                {                  
                    generatedMonsters.Add(mFactories[(MonstersList)Enum.Parse(typeof(MonstersList),
                        selectedMTypes[randIndex].monsterName)].createMonster(selectedMTypes[randIndex]));
                    packCost -= mPrice;
                }

            }
            return generatedMonsters;
        }  

        private A_Monster addMonster(MonstersList monster, MonstersData mData) => mFactories[monster].createMonster(mData);

    }
}
