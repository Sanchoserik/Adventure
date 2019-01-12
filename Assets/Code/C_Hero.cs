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

        //base hero defence values // actualy = 0
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
        //changing value      // can be changed by some effects
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
        public int totalStrength; // 1 str give +1 To allPhysAtkDamage 10 str give +2% to all PhysAtkDamage 
        public int totalEndurance; // 1 end Gives 1 HP 10 end give 1% HP
        public int totalKnowledge; // 1 kn gives +1 Talisman Power and +1 Energy 10 kn give 1% to all magical damage and + 1% Energy
        public int totalCharisma; // 1 Chr gives 1% to critical strike dmg 5 chr gives +1% critical strike chanse

        //bonuses from params
        public int pbonusHP;
        public int pbonusSP;
        public int pbonusPhysAtkStrength;
        public int pbonusMagAtkStrength;
        public int pbonusTalismanStrength;
        public int pbonusCritChance;
        public int critChance;
        public float critDamageMod; // crit damage percent
        

        //AP - action Points
        //every 10 ltvels give 1 AP
        public int baseAP;
        public int bonusAP; // ap from something
        public int totalAP; //
        //
        public int currAP; // current ap for battles



        // invertory
        public int money;  // gold
        // public int blood; // blood count
        //public int vsoul; // soul strength //???

        public List<A_Item> inv_items; // main invertory

        public List<A_Talisman> inv_talismans; // talismans in invertory
        public List<A_Talisman> in_useTalismans; // talismans in use stack
        //effects
        public List<A_Effect> global_card_stack; // global cards eff
        public List<A_Effect> eff_stack; // battle eff
        //skills tree with current skill levels
        public List<A_Skill> skillList; //skill list
        public int skillPoints;
        public int attributePoints;
        public int level;
        public int currExp; //current expirience
        public int nextLevelExp; // exp for next levelup


        //starting initialisation
        public C_Hero()
        {
            inv_items = new List<A_Item>();
            inv_talismans = new List<A_Talisman>();
            eff_stack = new List<A_Effect>();
            skillList = new List<A_Skill>();

            baseMaxHP = 200;
            currHP = 200;
            baseMaxENE = 100;
            currENE = 100;
            level = 0;
            currExp = 0;
            nextLevelExp = 100;
            skillPoints = 0;
            attributePoints = 0;
            //initialize skillslist
            baseStrength = 1;
            baseEndurance = 1;
            baseKnowledge = 1;
            baseCharisma = 1;
            // defence params
            physDef = new DefenceParam();
            fireDef = new DefenceParam();
            airDef = new DefenceParam();
            lightninhDef = new DefenceParam();
            earthDef = new DefenceParam();
            waterDef = new DefenceParam();
            lifeDef = new DefenceParam();
            deathDef = new DefenceParam();
            lightDef = new DefenceParam();
            darknessDef = new DefenceParam();

            money = 0;
            baseAP = 4;

            critChance = 1;
            critDamageMod = 2.0f;
        }

    }
}
