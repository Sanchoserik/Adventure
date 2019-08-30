using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene.HeroEditor
{
    public class HeroEditorController : MonoBehaviour
    {
        public GameObject LeftStatusPanel;
        public GameObject MainStatusPanel;

        public static Dictionary<string, Text> heroStatusValues;

        public void Start()
        {
            fillHeroStatusValues();  
            updateVisuals();   
        }

        private void fillHeroStatusValues()
        {
            if (heroStatusValues == null)
            {
                heroStatusValues = new Dictionary<string, Text>();
                foreach (Transform t in LeftStatusPanel.transform)
                {
                    if (t.tag.Equals("Value"))
                        heroStatusValues.Add(t.name, t.GetComponent<Text>());
                }
                foreach (Transform t in MainStatusPanel.transform)
                {
                    if (t.tag.Equals("Value"))
                        heroStatusValues.Add(t.name, t.GetComponent<Text>());
                }
            }
        }

        public void updateVisuals()
        {
            updateLeftStatusPanel();
            updateMainStatusPanel();
        }

        public void updateLeftStatusPanel()
        {
            C_Hero hero = HeroController.mainHero;

            heroStatusValues["LevelVal"].text = hero.level.ToString();
            heroStatusValues["ExperienceVal"].text = hero.currExp.ToString()+"/"+hero.nextLevelExp;
            heroStatusValues["AttributePointsVal"].text = hero.freeAttributePoints.ToString();
            heroStatusValues["SkillPointsVal"].text = hero.freeSkillPoints.ToString();
            heroStatusValues["HPVal"].text = hero.currentHP.ToString()+"/"+hero.totalMaxHP.ToString();
            heroStatusValues["ENEVal"].text = hero.currentENE.ToString() + "/" + hero.totalMaxENE.ToString();
            heroStatusValues["ActionPointsVal"].text = hero.totalAP.ToString();
            heroStatusValues["PhysDefVal"].text = hero.tPhysDef.strValue;
            heroStatusValues["FireDefVal"].text = hero.tFireDef.strValue;
            heroStatusValues["AirDefVal"].text = hero.tAirDef.strValue;
            heroStatusValues["LightningDefVal"].text = hero.tLightningDef.strValue;
            heroStatusValues["EarthDefVal"].text = hero.tEarthDef.strValue;
            heroStatusValues["WaterDefVal"].text = hero.tWaterDef.strValue;
            heroStatusValues["LightDefVal"].text = hero.tLightDef.strValue;
            heroStatusValues["DarknessDefVal"].text = hero.tDarknessDef.strValue;
            heroStatusValues["LifeDefVal"].text = hero.tLifeDef.strValue;
            heroStatusValues["DeathDefVal"].text = hero.deathDef.strValue;
            heroStatusValues["MoneyVal"].text = hero.money.ToString();
            
        }

        public void updateMainStatusPanel()
        {
            C_Hero hero = HeroController.mainHero;

            heroStatusValues["BaseStrengthVal"].text = hero.baseStrength.ToString();
            heroStatusValues["BaseEnduranceVal"].text = hero.baseEndurance.ToString();
            heroStatusValues["BaseKnowledgeVal"].text = hero.baseKnowledge.ToString();
            heroStatusValues["BaseCharismaVal"].text = hero.baseCharisma.ToString();
            //heroStatusValues["BonusStrengthVal"].text = hero.bonusStrength.ToString();
            //heroStatusValues["BonusEnduranceVal"].text = hero.bonusEndurance.ToString();
            //heroStatusValues["BonusKnowledgeVal"].text = hero.bonusKnowledge.ToString();
            //heroStatusValues["BonusCharismaVal"].text = hero.bonusCharisma.ToString();
            //heroStatusValues["TotalStrengthVal"].text = hero.totalStrength.ToString();
            //heroStatusValues["TotalEnduranceVal"].text = hero.totalEndurance.ToString();
            //heroStatusValues["TotalKnowledgeVal"].text = hero.bonusKnowledge.ToString();
            //heroStatusValues["TotalCharismaVal"].text = hero.totalCharisma.ToString();
            heroStatusValues["BaseHPVal"].text = hero.baseMaxHP.ToString();
            heroStatusValues["MaxHPVal"].text = hero.totalMaxHP.ToString();
            heroStatusValues["BaseENEVal"].text = hero.baseMaxENE.ToString();
            heroStatusValues["MaxENEVal"].text = hero.totalMaxENE.ToString();
         
            //heroStatusValues[""].text = hero;
        }

        //BUTTON INPUT
        public void attributePlusButton(string attribute)
        {
            switch (attribute)
            {
                case "str":
                    HeroAttributesController.attributePlus("str");
                    break;
                case "end":
                    HeroAttributesController.attributePlus("end");
                    break;
                case "knd":
                    HeroAttributesController.attributePlus("knd");
                    break;
                case "chr":
                    HeroAttributesController.attributePlus("chr");
                    break;
            }
            updateVisuals();
        }

        public void attributeMinusButton(string attribute)
        {
            switch (attribute)
            {
                case "str":
                    HeroAttributesController.attributeMinus("str");
                    break;
                case "end":
                    HeroAttributesController.attributeMinus("end");
                    break;
                case "knd":
                    HeroAttributesController.attributeMinus("knd");
                    break;
                case "chr":
                    HeroAttributesController.attributeMinus("chr");
                    break;
            }
            updateVisuals();
        }

    }

}
