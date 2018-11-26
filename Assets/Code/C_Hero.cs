using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Items;
using Assets.Effects;

namespace Assets
{
    public class C_Hero
    {
        public int baseMaxHP; // base max
        public int maxHP; // all max
        public int currHP; // curr

        public int baseMaxENE; // base max
        public int maxENE; // all max
        public int currENE;
        
        // s-20 m-50 g-80 u-100
        public int baseFireDef;
        public int baseAirDef;
        public int baseLightningDef;
        public int baseEarthDef;
        public int baseWaterDef;
        public int baseLifeDef;
        public int baseDeathDef;
        public int baseLightDef;
        public int baseDarknessDef;
        //from items
        public int bonusFireDef;
        public int bonusAirDef;
        public int bonusLightningDef;
        public int bonusEarthDef;
        public int bonusWaterDef;
        public int bonusLifeDef;
        public int bonusDeathDef;
        public int bonusLightDef;
        public int bonusDarknessDef;
        //total
        public int totalFireDef;
        public int totalAirDef;
        public int totalLightningDef;
        public int totalEarthDef;
        public int totalWaterDef;
        public int totalLifeDef;
        public int totalDeathDef;
        public int totalLightDef;
        public int totalDarknessDef;

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
        //bonus def from params
        public int pbonusFireDef;
        public int pbonusAirDef;
        public int pbonusLightningDef;
        public int pbonusEarthDef;
        public int pbonusWaterDef;
        public int pbonusLifeDef;
        public int pbonusDeathDef;
        public int pbonusLightDef;
        public int pbonusDarknessDef;
        //

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
        
        public C_Hero()
        {
            inv_items = new List<A_Item>();
            inv_talismans = new List<A_Talisman>();
            eff_stack = new List<A_Effect>();
        }

    }
}
