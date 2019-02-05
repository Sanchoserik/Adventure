﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Items;
using Assets.Effects;
using Assets.Code.Skills;
using System.Xml.Serialization;

namespace Assets.Code
{
    [Serializable]
    public class C_Hero 
    {
        public int baseMaxHP; 
        public int maxHP; 
        public int currHP;

        public int baseMaxENE; 
        public int maxENE;
        public int currENE;

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

        //bonuses from attributes
        public int bonusHP;
        public int bonusHPPercent;
        public int bonusENE;
        public double bonusPhysAtkPercent;
        public int bonusPhysAtkValue;
        public double bonusMagAtkPercent;
        public int bonusMagAtkValue;
        public double bonusTalismanPowerPercent;
        public int bonusTalismanPowerValue;
        public int bonusCritDamageMod;
        public int bonusCritChance;
        public int critChance;
        public float critDamageMod; // crit damage percent
        
        //AP - action Points
        //every 10 levels give 1 AP
        public int baseAP;
        public int bonusAP; 
        public int totalAP; 
       
        public int currAP; 

        //Invertory
        public int money;  
        public List<A_Item> mainItemsStorage; 
        public List<A_Talisman> mainTalismansStorage;
        public List<A_Talisman> inUseTalismansStorage; // 0-2 main stack 3-9 secondary stack
        
        //Effects        
        public List<A_Effect> effectsStorage; 

        //Skills
        public List<A_Skill> skillList; 
        public int skillPoints;
        public int attributePoints;
        public int level;
        public int currExp; 
        public int nextLevelExp; 

        //starting initialisation
        public C_Hero()
        {
            mainItemsStorage = new List<A_Item>();
            mainTalismansStorage = new List<A_Talisman>();
            inUseTalismansStorage = new List<A_Talisman>();
            effectsStorage = new List<A_Effect>();
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

            money = 0;
            baseAP = 4;

            critChance = 1;
            critDamageMod = 2.0f;
        }

        //
        public void attributePlus(string attribute)
        {
            switch (attribute)
            {
                case "str": { baseStrength++; break; }
                case "end": { baseEndurance++; break; }
                case "knd": { baseKnowledge++; break; }
                case "chr": { baseCharisma++; break; }
            }
            updateAttributes();
        }

        public void attributeMinus(string attribute)
        {
            switch (attribute)
            {
                case "str": { baseStrength--; break; }
                case "end": { baseEndurance--; break; }
                case "knd": { baseKnowledge--; break; }
                case "chr": { baseCharisma--; break; }
            }
            updateAttributes();
        }

        private void updateAttributes()
        {
            refreshTotalAttributes();
            updateStrength();
            updateEndurance();
            updateKnowledge();
            updateCharisma();
        }

        private void refreshTotalAttributes()
        {
            totalStrength = baseStrength + bonusStrength;
            totalEndurance = baseEndurance + bonusEndurance;
            totalKnowledge = baseKnowledge + bonusKnowledge;
            totalCharisma = baseCharisma + bonusCharisma;
        }

        private void updateStrength()
        {
            bonusPhysAtkValue = totalStrength;
            bonusPhysAtkPercent = totalStrength / 10 * 3 / 100;
        }

        private void updateEndurance()
        {
            bonusHP = totalEndurance * 5;           
            bonusHPPercent = totalEndurance / 10 / 100;
            bonusTalismanPowerValue = totalEndurance / 10 * 15;
        }

        private void updateKnowledge()
        {
            bonusMagAtkValue = totalKnowledge * 3;
            bonusENE = totalKnowledge * 3;
            bonusMagAtkPercent = totalKnowledge / 10 * 2 / 100;
            bonusTalismanPowerPercent = totalKnowledge / 10 / 100;
        }

        private void updateCharisma()
        {
            bonusCritDamageMod = totalCharisma * 2;
            bonusCritChance = totalCharisma / 10;
        }
        
        //
        public void defenceValuePlus(string defValue)
        {
            switch (defValue)
            {
                case "Physical": { physDef.changeValue(1); break; }
                case "Fire": { fireDef.changeValue(1); break; }
                case "Air": { airDef.changeValue(1); break; }
                case "Lightning": { lightningDef.changeValue(1); break; }
                case "Earth": { earthDef.changeValue(1); break; }
                case "Water": { waterDef.changeValue(1); break; }
                case "Life": { lifeDef.changeValue(1); break; }
                case "Death": { deathDef.changeValue(1); break; }
                case "Light": { lightDef.changeValue(1); break; }
                case "Darkness": { darknessDef.changeValue(1); break; }
            }
        }

        public void defenceValueMinus(string defValue)
        {
            switch (defValue)
            {
                case "Physical": { physDef.changeValue(-1); break; }
                case "Fire": { fireDef.changeValue(-1); break; }
                case "Air": { airDef.changeValue(-1); break; }
                case "Lightning": { lightningDef.changeValue(-1); break; }
                case "Earth": { earthDef.changeValue(-1); break; }
                case "Water": { waterDef.changeValue(-1); break; }
                case "Life": { lifeDef.changeValue(-1); break; }
                case "Death": { deathDef.changeValue(-1); break; }
                case "Light": { lightDef.changeValue(-1); break; }
                case "Darkness": { darknessDef.changeValue(-1); break; }
            }
        }


        //
        public void levelPlus()
        {

        }

        public void levelMinus()
        {

        }
    }
}
