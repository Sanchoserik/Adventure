using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.PlayerController
{
    public class HeroAttributesController
    {
        public static void attributePlus(string attribute)
        {
            C_Hero hero = HeroController.mainHero;
          
                switch (attribute)
                {
                    case "str":
                        hero.baseStrength++;
                        break;
                    case "end":
                        hero.baseEndurance++;
                        break;
                    case "knd":
                        hero.baseKnowledge++;
                        break;
                    case "chr":
                        hero.baseCharisma++;
                        break;
                }
                hero.freeAttributePoints--;
                updateAttributes();
            
        }

        public static void attributeMinus(string attribute)
        {
            C_Hero hero = HeroController.mainHero;

            switch (attribute)
            {
                case "str":
                    {
                            hero.baseStrength--;
                            hero.freeAttributePoints++;
                        break;
                    }
                case "end":
                    {                   
                            hero.baseEndurance--;
                            hero.freeAttributePoints++;                 
                        break;
                    }
                case "knd":
                    {
                            hero.baseKnowledge--;
                            hero.freeAttributePoints++;

                        break;
                    }
                case "chr":
                    {
                            hero.baseCharisma--;
                            hero.freeAttributePoints++;
                        break;
                    }
            }
            updateAttributes();
        }

        public static void updateAttributes()
        {
            updateStrength();
            updateEndurance();
            updateKnowledge();
            updateCharisma();
            refreshTotalValues();
        }

        private static void refreshTotalValues()
        {
            C_Hero hero = HeroController.mainHero;

            refreshTotalDefValues();

            hero.totalStrength = hero.baseStrength + hero.bonusStrength + (hero.baseStrength + hero.bonusStrength) * hero.bonusStrengthPercent / 100;
            hero.totalEndurance = hero.baseEndurance + hero.bonusEndurance + (hero.baseEndurance + hero.bonusEndurance) * hero.bonusEndurancePercent / 100;
            hero.totalKnowledge = hero.baseKnowledge + hero.bonusKnowledge + (hero.baseKnowledge + hero.bonusKnowledge) * hero.bonusKnowledgePercent / 100;
            hero.totalCharisma = hero.baseCharisma + hero.bonusCharisma + (hero.baseCharisma + hero.bonusCharisma) * hero.bonusCharismaPercent / 100;

            hero.baseMaxHP = hero.baseHP + hero.totalEndurance * 5 + (hero.baseHP + hero.totalEndurance * 5) * hero.totalEndurance / 10 / 100;
            hero.totalMaxHP = hero.baseMaxHP + hero.bonusHPValue + (hero.baseMaxHP + hero.bonusHPValue) * hero.bonusHPPercent / 100;

            hero.baseMaxENE = hero.baseENE + hero.totalKnowledge * 3;
            hero.totalMaxENE = hero.baseMaxENE + hero.bonusENEValue + (hero.baseMaxENE + hero.bonusENEValue) * hero.bonusENEPercent / 100;

            hero.totalPhysAtk = hero.basePhysAtk + hero.bonusPhysAtk + (hero.basePhysAtk + hero.bonusPhysAtk) * hero.bonusPhysAtkPercent / 100;
            hero.totalCritChance = hero.baseCritChance + hero.bonusCritChance;
            hero.totalAP = hero.baseAP + hero.bonusAP;

        }

        private static void updateStrength()
        {
            C_Hero hero = HeroController.mainHero;

            hero.bonusPhysAtk = hero.totalStrength * 5;
            hero.bonusPhysAtkPercent = hero.totalStrength / 10 * 3 / 100;
        }

        private static void updateEndurance()
        {
            C_Hero hero = HeroController.mainHero;

            hero.baseMaxHP = hero.baseHP + hero.totalEndurance * 5 + (hero.baseHP + hero.totalEndurance * 5) * hero.totalEndurance / 10 / 100;

            hero.bonusTalismanPower = hero.totalEndurance / 5 * 15;
        }

        private static void updateKnowledge()
        {
            C_Hero hero = HeroController.mainHero;

            hero.baseMaxENE = hero.baseENE + hero.totalKnowledge * 3;

            hero.bonusMagAtkValue = hero.totalKnowledge * 3;
            hero.bonusMagAtkPercent = hero.totalKnowledge / 10 * 2 / 100;
            hero.bonusTalismanPowerPercent = hero.totalKnowledge / 10 / 100;
        }

        private static void updateCharisma()
        {
            C_Hero hero = HeroController.mainHero;

            hero.critDamageMod = hero.totalCharisma * 2 / 100;
            hero.bonusCritChance = hero.totalCharisma / 10;
        }

        public static void refreshTotalDefValues()
        {
            C_Hero hero = HeroController.mainHero;

            hero.totalAirDef.combineValues(hero.airDef, hero.bonusAirDef);
            hero.totalLightningDef.combineValues(hero.lightningDef, hero.bonusLightningDef);
            hero.totalEarthDef.combineValues(hero.earthDef, hero.bonusEarthDef);
            hero.totalWaterDef.combineValues(hero.waterDef, hero.bonusWaterDef);
            hero.totalFireDef.combineValues(hero.fireDef, hero.bonusFireDef);
            hero.totalLifeDef.combineValues(hero.lifeDef, hero.bonusLifeDef);
            hero.totalDeathDef.combineValues(hero.deathDef, hero.bonusDeathDef);
            hero.totalLightDef.combineValues(hero.lightDef, hero.bonusLightDef);
            hero.totalDarknessDef.combineValues(hero.darknessDef, hero.bonusDarknessDef);
            hero.totalPhysDef.combineValues(hero.physDef, hero.bonusPhysDef);
        }

        public static void defenceValuePlus(string defValue)
        {
            C_Hero hero = HeroController.mainHero;

            switch (defValue)
            {
                case "physical": { hero.physDef.changeValue(1); break; }
                case "fire": { hero.fireDef.changeValue(1); break; }
                case "air": { hero.airDef.changeValue(1); break; }
                case "lightning": { hero.lightningDef.changeValue(1); break; }
                case "earth": { hero.earthDef.changeValue(1); break; }
                case "water": { hero.waterDef.changeValue(1); break; }
                case "life": { hero.lifeDef.changeValue(1); break; }
                case "death": { hero.deathDef.changeValue(1); break; }
                case "light": { hero.lightDef.changeValue(1); break; }
                case "darkness": { hero.darknessDef.changeValue(1); break; }
            }
        }

        public static void defenceValueMinus(string defValue)
        {
            C_Hero hero = HeroController.mainHero;

            switch (defValue)
            {
                case "physical": { hero.physDef.changeValue(-1); break; }
                case "fire": { hero.fireDef.changeValue(-1); break; }
                case "air": { hero.airDef.changeValue(-1); break; }
                case "lightning": { hero.lightningDef.changeValue(-1); break; }
                case "earth": { hero.earthDef.changeValue(-1); break; }
                case "water": { hero.waterDef.changeValue(-1); break; }
                case "life": { hero.lifeDef.changeValue(-1); break; }
                case "death": { hero.deathDef.changeValue(-1); break; }
                case "light": { hero.lightDef.changeValue(-1); break; }
                case "darkness": { hero.darknessDef.changeValue(-1); break; }
            }
        }


        public static void levelPlus()
        {
            C_Hero hero = HeroController.mainHero;

            hero.level++;
            hero.currExp = 0;
            hero.nextLevelExp = (int)(hero.nextLevelExp * 0.2) + hero.nextLevelExp;
            hero.freeSkillPoints++;
            hero.freeAttributePoints += 4;
        }

        public static void levelMinus()
        {
            C_Hero hero = HeroController.mainHero;

            if (hero.freeSkillPoints >= 1 && hero.freeAttributePoints >= 4 && hero.level > 1)
            {
                hero.nextLevelExp = 100;
                int differenceExp = 0;
                for (int i = 2; i <= hero.level; ++i)
                {
                    differenceExp = (int)(hero.nextLevelExp * 0.2);
                    hero.nextLevelExp = differenceExp + hero.nextLevelExp;
                }
                hero.nextLevelExp -= differenceExp;
                hero.currExp = 0;

                hero.freeSkillPoints--;
                hero.freeAttributePoints -= 4;
                hero.level--;

            }
        }

        public static string getDefParamState(DefenceParam defenceParam, Dictionary<string, string> messages)
        {
            switch (defenceParam.intValue)
            {
                case 0: return messages["nDef"];
                case 1: return messages["sDef"];
                case 2: return messages["mDef"];
                case 3: return messages["gDef"];
                case 4: return messages["uDef"];
                default: return "NoVal";
            }
        }
        
    }
}
