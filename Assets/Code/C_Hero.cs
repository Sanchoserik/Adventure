using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Items;
using Assets.Effects;
using Assets.Code.Skills;

namespace Assets.Code
{
    public class C_Hero
    {
        public int baseMaxHP; // base max
        public int maxHP; // all max
        public int currHP; // curr

        public int baseMaxENE; // base max
        public int maxENE; // all max
        public int currENE;

        //base hero defence values
        public DefenceParam physDef;
        public DefenceParam fireDef;
        public DefenceParam airDef;
        public DefenceParam lightninhDef;
        public DefenceParam earthDef;
        public DefenceParam waterDef;
        public DefenceParam lifeDef;
        public DefenceParam deathDef;
        public DefenceParam lightDef;
        public DefenceParam darknessDef;
        //changing value
        public DefenceParam chPhysDef;
        public DefenceParam chFireDef;
        public DefenceParam chAirDef;
        public DefenceParam chLightninhDef;
        public DefenceParam chEarthDef;
        public DefenceParam chWaterDef;
        public DefenceParam chLifeDef;
        public DefenceParam chDeathDef;
        public DefenceParam chLightDef;
        public DefenceParam chDarknessDef;
        //Total hero def values  totalDefValue = defVal + chDefVal;
        public DefenceParam tPhysDef;
        public DefenceParam tFireDef;
        public DefenceParam tAirDef;
        public DefenceParam tLightninhDef;
        public DefenceParam tEarthDef;
        public DefenceParam tWaterDef;
        public DefenceParam tLifeDef;
        public DefenceParam tDeathDef;
        public DefenceParam tLightDef;
        public DefenceParam tDarknessDef;

        //base params
        public int baseStrength;
        public int baseEndurance;
        public int baseKnowledge;
        public int baseCharisma;
        //bonus params 
        public int bonusStrength;
        public int bonusEndurance;
        public int bonusKnowledge;
        public int bonusCharisma;
        //total params
        public int totalStrength;
        public int totalEndurance;
        public int totalKnowledge;
        public int totalCharisma;

        //bonuses from params
        public int pbonusHP;
        public int pbonusSP;
        public int pbonusPhysAtkp;
        public int pbonusMagAtkp;
        public int pbonusTalismanStrength;
        public int pbonusCritChance;
        public int pbonusAP;

        //AP - action Points
        public int baseAP;
        public int bonusAP; // ap from items
        public int totalAP; //
        //
        public int currAP; // current ap for battles



        // invertory
        public int gold;  // gold
        public int blood; // blood count
        public int vsoul; // soul strength

        public List<A_Item> inv_items; // main invertory

        public List<A_Talisman> inv_talismans; // talismans in invertory
        public List<A_Talisman> in_useTalismans; // talismans in use stack

        public List<A_Effect> global_card_stack; // global cards eff
        public List<A_Effect> eff_stack; // battle eff

        public List<A_Skill> skillList; //skill list

        public C_Hero()
        {
            inv_items = new List<A_Item>();
            inv_talismans = new List<A_Talisman>();
            eff_stack = new List<A_Effect>();
            skillList = new List<A_Skill>();
        }

    }
}
