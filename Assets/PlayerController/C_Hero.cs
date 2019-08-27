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
        public int baseMaxHP;
        public int bonusHPValue;
        public int bonusHPPercent;
        public int totalMaxHP;       
        public int currentHP;

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
        // this valus can be changed by some effects
        public DefenceParam chPhysDef;
        public DefenceParam chFireDef;
        public DefenceParam chAirDef;
        public DefenceParam chLightningDef;
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
        public DefenceParam tLightningDef;
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
        public int bonusCritDamagePercent;
        public int bonusCritChance;
        public int totalCritChance;        
        public float critDamageMod;

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

            baseMaxHP = 200;
            currentHP = 200;
            baseMaxENE = 100;
            currentENE = 100;
            level = 0;
            currExp = 0;
            nextLevelExp = 100;
            freeSkillPoints = 0;
            freeAttributePoints = 0;

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

            chPhysDef = new DefenceParam();
            chFireDef = new DefenceParam();
            chAirDef = new DefenceParam();
            chLightningDef = new DefenceParam();
            chEarthDef = new DefenceParam();
            chWaterDef = new DefenceParam();
            chLifeDef = new DefenceParam();
            chDeathDef = new DefenceParam();
            chLightDef = new DefenceParam();
            chDarknessDef = new DefenceParam();

            tPhysDef = new DefenceParam();
            tFireDef = new DefenceParam();
            tAirDef = new DefenceParam();
            tLightningDef = new DefenceParam();
            tEarthDef = new DefenceParam();
            tWaterDef = new DefenceParam();
            tLifeDef = new DefenceParam();
            tDeathDef = new DefenceParam();
            tLightDef = new DefenceParam();
            tDarknessDef = new DefenceParam();

            money = 0;
            baseAP = 4;

            baseCritChance = 1;
            critDamageMod = 2.0f;
        }

    
    }
}
