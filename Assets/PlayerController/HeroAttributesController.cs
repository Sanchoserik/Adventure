﻿using System;
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

            if (hero.freeAttributePoints > 0)
            {
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
        }

        public static void attributeMinus(string attribute)
        {
            C_Hero hero = HeroController.mainHero;

            switch (attribute)
            {
                case "str":
                    {
                        if (hero.baseStrength > 1)
                        {
                            hero.baseStrength--;
                            hero.freeAttributePoints++;
                        }
                        break;
                    }
                case "end":
                    {
                        if (hero.baseEndurance > 1)
                        {
                            hero.baseEndurance--;
                            hero.freeAttributePoints++;
                        }
                        break;
                    }
                case "knd":
                    {
                        if (hero.baseKnowledge > 1)
                        {
                            hero.baseKnowledge--;
                            hero.freeAttributePoints++;
                        }
                        break;
                    }
                case "chr":
                    {
                        if (hero.baseCharisma > 1)
                        {
                            hero.baseCharisma--;
                            hero.freeAttributePoints++;
                        }
                        break;
                    }
            }
            updateAttributes();
        }

        private static void updateAttributes()
        {           
            updateStrength();
            updateEndurance();
            updateKnowledge();
            updateCharisma();
            refreshTotalAttributes();
        }

        private static void refreshTotalAttributes()
        {
            C_Hero hero = HeroController.mainHero;
            hero.totalStrength = hero.baseStrength + hero.bonusStrength;
            hero.totalEndurance = hero.baseEndurance + hero.bonusEndurance;
            hero.totalKnowledge = hero.baseKnowledge + hero.bonusKnowledge;
            hero.totalCharisma = hero.baseCharisma + hero.bonusCharisma;
        }

        private static void updateStrength()
        {
            C_Hero hero = HeroController.mainHero;

            hero.bonusPhysAtkValue = hero.totalStrength * 5;
            hero.bonusPhysAtkPercent = hero.totalStrength / 10 * 3 / 100;
        }

        private static void updateEndurance()
        {
            C_Hero hero = HeroController.mainHero;

            hero.bonusHPValue = hero.totalEndurance * 5;
            hero.bonusHPPercent = hero.totalEndurance / 10 / 100;
            hero.bonusTalismanPowerValue = hero.totalEndurance / 5 * 15;
        }

        private static void updateKnowledge()
        {
            C_Hero hero = HeroController.mainHero;

            hero.bonusMagAtkValue = hero.totalKnowledge * 3;
            hero.bonusENEValue = hero.totalKnowledge * 3;
            hero.bonusMagAtkPercent = hero.totalKnowledge / 10 * 2 / 100;
            hero.bonusTalismanPowerPercent = hero.totalKnowledge / 10 / 100;
        }

        private static void updateCharisma()
        {
            C_Hero hero = HeroController.mainHero;

            hero.critDamageMod = hero.totalCharisma * 2/100;
            hero.bonusCritChance = hero.totalCharisma / 10;
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


    }
}
