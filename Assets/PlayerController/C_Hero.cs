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

        //bonuses from attributes
        public int bonusHPValue;
        public double bonusHPPercent;
        public int bonusENEValue;
        public double bonusENEPercent;
        public int bonusPhysAtkValue;
        public double bonusPhysAtkPercent;
        public int bonusMagAtkValue;
        public double bonusMagAtkPercent;
        public int bonusTalismanPowerValue;
        public double bonusTalismanPowerPercent;        
        
        public int critChance;
        public int bonusCritDamagePercent;
        public int bonusCritChance;
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
            currHP = 200;
            baseMaxENE = 100;
            currENE = 100;
            level = 0;
            currExp = 0;
            nextLevelExp = 100;
            freeSkillPoints = 0;
            freeAttributePoints = 0;
          
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

            critChance = 1;
            critDamageMod = 2.0f;
        }

        //
        public void attributePlus(string attribute)
        {
            if (freeAttributePoints > 0)
            {
                switch (attribute)
                {
                    case "str":
                        {
                            if (freeAttributePoints > 0)
                            {
                                baseStrength++;
                                freeAttributePoints--;
                            }
                            break;
                        }
                    case "end":
                        {
                            if (freeAttributePoints > 0)
                            {
                                baseEndurance++;
                                freeAttributePoints--;
                            }
                            break;
                        }
                    case "knd":
                        {
                            if (freeAttributePoints > 0)
                            {
                                baseKnowledge++;
                                freeAttributePoints--;
                            }
                            break;
                        }
                    case "chr":
                        {
                            if (freeAttributePoints > 0)
                            {
                                baseCharisma++;
                                freeAttributePoints--;
                            }
                            break;
                        }
                }
                updateAttributes();
            }
        }

        public void attributeMinus(string attribute)
        {
            
                switch (attribute)
                {
                    case "str":
                        {
                            if (baseStrength > 1)
                            {
                                baseStrength--;
                                freeAttributePoints++;
                            }
                            break;
                        }
                    case "end":
                        {
                            if (baseEndurance > 1)
                            {
                                baseEndurance--;
                                freeAttributePoints++;
                            }
                            break;
                        }
                    case "knd":
                        {
                            if (baseKnowledge > 1)
                            {
                                baseKnowledge--;
                                freeAttributePoints++;
                            }
                            break;
                        }
                    case "chr":
                        {
                            if (baseCharisma > 1)
                            {
                                baseCharisma--;
                                freeAttributePoints++;
                            }
                            break;
                        }
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
            bonusHPValue = totalEndurance * 5;           
            bonusHPPercent = totalEndurance / 10 / 100;
            bonusTalismanPowerValue = totalEndurance / 10 * 15;
        }

        private void updateKnowledge()
        {
            bonusMagAtkValue = totalKnowledge * 3;
            bonusENEValue= totalKnowledge * 3;
            bonusMagAtkPercent = totalKnowledge / 10 * 2 / 100;
            bonusTalismanPowerPercent = totalKnowledge / 10 / 100;
        }

        private void updateCharisma()
        {
            critDamageMod = totalCharisma * 2;
            bonusCritChance = totalCharisma / 10;
        }
        
        //
        public void defenceValuePlus(string defValue)
        {
            switch (defValue)
            {
                case "physical": { physDef.changeValue(1); break; }
                case "fire": { fireDef.changeValue(1); break; }
                case "air": { airDef.changeValue(1); break; }
                case "lightning": { lightningDef.changeValue(1); break; }
                case "earth": { earthDef.changeValue(1); break; }
                case "water": { waterDef.changeValue(1); break; }
                case "life": { lifeDef.changeValue(1); break; }
                case "death": { deathDef.changeValue(1); break; }
                case "light": { lightDef.changeValue(1); break; }
                case "darkness": { darknessDef.changeValue(1); break; }
            }
        }

        public void defenceValueMinus(string defValue)
        {
            switch (defValue)
            {
                case "physical": { physDef.changeValue(-1); break; }
                case "fire": { fireDef.changeValue(-1); break; }
                case "air": { airDef.changeValue(-1); break; }
                case "lightning": { lightningDef.changeValue(-1); break; }
                case "earth": { earthDef.changeValue(-1); break; }
                case "water": { waterDef.changeValue(-1); break; }
                case "life": { lifeDef.changeValue(-1); break; }
                case "death": { deathDef.changeValue(-1); break; }
                case "light": { lightDef.changeValue(-1); break; }
                case "darkness": { darknessDef.changeValue(-1); break; }
            }
        }


        //
        public void levelPlus()
        {
            level++;
            currExp = 0;
            nextLevelExp = (int)(nextLevelExp * 0.2) + nextLevelExp;
            freeSkillPoints++;
            freeAttributePoints += 4;
        }

        public void levelMinus()
        {
            if (freeSkillPoints >= 1 && freeAttributePoints >= 4 && level >1)
            {
                nextLevelExp = 100;
                int differenceExp = 0;
                for (int i = 2; i <= level; ++i)
                {
                    differenceExp = (int)(nextLevelExp * 0.2);
                    nextLevelExp = differenceExp + nextLevelExp;
                }           
                nextLevelExp -= differenceExp;
                currExp = 0;

                freeSkillPoints--;
                freeAttributePoints -= 4;
                level--;

            }
        }


    }
}
