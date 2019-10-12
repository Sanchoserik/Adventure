
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Monsters
{
    public abstract class A_Monster
    {
        public string name;
        public string rank; //minion -1  adept -2 elite -3 lord -4 prince -5

        public int monsterPrice;

        public int baseHP;
        public int bonusHP;
        public int maxHP;
        public int currentHP;

        public int baseENE;
        public int bonusENE;
        public int maxENE;
        public int currentENE;

        public string nativeElement;
        public string counterElement;

        public DefenceParam physDef;
        public DefenceParam fireDef;
        public DefenceParam airDef;
        public DefenceParam lightningDef;
        public DefenceParam earthDef;
        public DefenceParam waterDef;
        public DefenceParam lifeDef;
        public DefenceParam deathDef;
        public DefenceParam lightDef;
        public DefenceParam darknessDef;
       
        public DefenceParam bonusPhysDef;
        public DefenceParam bonusFireDef;
        public DefenceParam bonusAirDef;
        public DefenceParam bonusLightningDef;
        public DefenceParam bonusEarthDef;
        public DefenceParam bonusWaterDef;
        public DefenceParam bonusLifeDef;
        public DefenceParam bonusDeathDef;
        public DefenceParam bonusLightDef;
        public DefenceParam bonusDarknessDef;
        
        public DefenceParam totalPhysDef;
        public DefenceParam totalFireDef;
        public DefenceParam totalAirDef;
        public DefenceParam totalLightningDef;
        public DefenceParam totalEarthDef;
        public DefenceParam totalWaterDef;
        public DefenceParam totalLifeDef;
        public DefenceParam totalDeathDef;
        public DefenceParam totalLightDef;
        public DefenceParam totalDarknessDef;

        public int bonusMagATKval;
        public int bonusMagATKPercent;
        public int physATK;
        public int bonusPhysATKval;
        public int bonusPhysATKPerccent;
        
        public int baseAP;
        public int bonusAP;
        public int totalAP;
        public int currentAP;

        public List<A_MonsterAction> actionList;

        public A_Monster(string mName, string mRank, int mPrice)
        {
            name = mName;
            rank = mRank;
            monsterPrice = mPrice;

            actionList = new List<A_MonsterAction>();         
        }

        public virtual A_MonsterAction attackAdvisor()
        {
            return null;
        }

        public virtual A_MonsterAction defenceAdvisor()
        {
            return null;
        }

        public virtual A_MonsterAction suportAdvisor()
        {
            return null;
        }
    }
}
