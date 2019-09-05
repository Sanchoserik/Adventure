using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.Items;
using Assets.Effects;
using Assets.Code.Skills;
using System.Xml.Serialization;
using Assets.Code.UIScripts.SkillTreeScene;

namespace Assets.PlayerController
{
    [Serializable]
    public class C_Hero
    {
        public int baseHP;
        public int baseMaxHP;       // baseHP + HP from Endurance
        public int bonusHPValue;    // bonus from cads
        public int bonusHPPercent;  // bonus from cards to (baseMaxHP+bonusHPvalue)%
        public int totalMaxHP;      // baseMax+bonusVal+bonus%  
        public int currentHP;

        public int baseENE; //100
        public int baseMaxENE;
        public int bonusENEValue;
        public int bonusENEPercent;
        public int totalMaxENE;
        public int currentENE;

        //base hero defence values // actualy = 0
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
        // bonus values
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
        //Total hero def values  totalDefValue = defVal + chDefVal;
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
        //bonus params percent
        public int bonusStrengthPercent;
        public int bonusEndurancePercent;
        public int bonusKnowledgePercent;
        public int bonusCharismaPercent;
        //total params
        public int totalStrength;
        public int totalEndurance;
        public int totalKnowledge;
        public int totalCharisma;

        //bonus to phys damage and skills phys damage
        public int basePhysAtk;        
        public int bonusPhysAtk;
        public int bonusPhysAtkPercent;
        public int totalPhysAtk;
        
        //bonus to skills mag damage
        public int bonusMagAtkValue;
        public int bonusMagAtkPercent;

        public int bonusTalismanPower;
        public int bonusTalismanPowerPercent;        
        
        //crit chance
        public int baseCritChance;        
        public int bonusCritChance;
        public int totalCritChance;        
        public float critDamageMod;
        public int bonusCritDamagePercent;

        //AP - action Points
        public int baseAP;
        public int bonusAP;
        public int totalAP;
        public int currentAP;

        //Invertory
        public int money;
        public InventorySystem inventorySystem; 

        //Effects        
        public List<A_Effect> effectsStorage;

        //Skills
        public HeroSkillsController heroSkills;

        //Level Data
        public int freeSkillPoints;
        public int freeAttributePoints;
        public int level;
        public int currExp; 
        public int nextLevelExp;
       
        //starting initialisation
        public C_Hero()
        {
            inventorySystem = new InventorySystem();
            effectsStorage = new List<A_Effect>();       

            baseHP = 200;
            currentHP = 200;
            baseENE = 100;
            currentENE = 100;
            level = 0;
            currExp = 0;
            nextLevelExp = 100;
            freeSkillPoints = 1;
            freeAttributePoints = 4;

            basePhysAtk = 25;

            baseStrength = 1;
            baseEndurance = 1;
            baseKnowledge = 1;
            baseCharisma = 1;
           
            physDef = new DefenceParam();
            fireDef = new DefenceParam();
            airDef = new DefenceParam();
            lightningDef = new DefenceParam();
            earthDef = new DefenceParam();
            waterDef = new DefenceParam();
            lifeDef = new DefenceParam();
            deathDef = new DefenceParam();
            lightDef = new DefenceParam();
            darknessDef = new DefenceParam();

            bonusPhysDef = new DefenceParam();
            bonusFireDef = new DefenceParam();
            bonusAirDef = new DefenceParam();
            bonusLightningDef = new DefenceParam();
            bonusEarthDef = new DefenceParam();
            bonusWaterDef = new DefenceParam();
            bonusLifeDef = new DefenceParam();
            bonusDeathDef = new DefenceParam();
            bonusLightDef = new DefenceParam();
            bonusDarknessDef = new DefenceParam();

            totalPhysDef = new DefenceParam();
            totalFireDef = new DefenceParam();
            totalAirDef = new DefenceParam();
            totalLightningDef = new DefenceParam();
            totalEarthDef = new DefenceParam();
            totalWaterDef = new DefenceParam();
            totalLifeDef = new DefenceParam();
            totalDeathDef = new DefenceParam();
            totalLightDef = new DefenceParam();
            totalDarknessDef = new DefenceParam();

            money = 0;
            baseAP = 4;

            baseCritChance = 1;
            critDamageMod = 2.0f;
        }

    
    }
}
