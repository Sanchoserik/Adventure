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

        public GameObject[] plusButtons;
        public GameObject[] minusButtons;

        private bool updated = false;
        private int buttonCounterStr = 0;
        private int buttonCounterEnd = 0;
        private int buttonCounterKnd = 0;
        private int buttonCounterChr = 0;

        public static Dictionary<string, Text> heroStatusValues;


        public void Start()
        {
            heroStatusValues = null;
            updated = false;
            fillHeroStatusValues();  
            updateVisuals();   
        }

        public void Update()
        {
            if (!updated)
                updateButtons();
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
            heroStatusValues["PhysDefVal"].text = hero.totalPhysDef.strValue;
            heroStatusValues["FireDefVal"].text = hero.totalFireDef.strValue;
            heroStatusValues["AirDefVal"].text = hero.totalAirDef.strValue;
            heroStatusValues["LightningDefVal"].text = hero.totalLightningDef.strValue;
            heroStatusValues["EarthDefVal"].text = hero.totalEarthDef.strValue;
            heroStatusValues["WaterDefVal"].text = hero.totalWaterDef.strValue;
            heroStatusValues["LightDefVal"].text = hero.totalLightDef.strValue;
            heroStatusValues["DarknessDefVal"].text = hero.totalDarknessDef.strValue;
            heroStatusValues["LifeDefVal"].text = hero.totalLifeDef.strValue;
            heroStatusValues["DeathDefVal"].text = hero.deathDef.strValue;
            heroStatusValues["MoneyVal"].text = hero.money.ToString();
            heroStatusValues["PhysAtkVal"].text = hero.totalPhysAtk.ToString();
            heroStatusValues["BonusMagAtkVal"].text = hero.bonusMagAtkValue.ToString();
            heroStatusValues["BonusMagAtkPercentVal"].text = hero.bonusMagAtkPercent.ToString();
            heroStatusValues["BonusTPowerVal"].text = hero.bonusTalismanPower.ToString();
            heroStatusValues["BonusTPowerPercentVal"].text = hero.bonusTalismanPowerPercent.ToString();
            heroStatusValues["CritChanceVal"].text = hero.totalCritChance.ToString();
            heroStatusValues["CritDmgModVal"].text = hero.critDamageMod.ToString();
            heroStatusValues["BonusCritDmgPercentVal"].text = hero.bonusCritDamagePercent.ToString();
        }

        public void updateMainStatusPanel()
        {
            C_Hero hero = HeroController.mainHero;

            heroStatusValues["BaseStrengthVal"].text = hero.baseStrength.ToString();
            heroStatusValues["BaseEnduranceVal"].text = hero.baseEndurance.ToString();
            heroStatusValues["BaseKnowledgeVal"].text = hero.baseKnowledge.ToString();
            heroStatusValues["BaseCharismaVal"].text = hero.baseCharisma.ToString();           
            heroStatusValues["BaseHPVal"].text = hero.baseMaxHP.ToString();
            heroStatusValues["MaxHPVal"].text = hero.totalMaxHP.ToString();
            heroStatusValues["BaseENEVal"].text = hero.baseMaxENE.ToString();
            heroStatusValues["MaxENEVal"].text = hero.totalMaxENE.ToString();         
        }

        //BUTTON INPUT
        public void attributePlusButton(string attribute)
        {
            if (HeroController.mainHero.freeAttributePoints > 0)
            {
                switch (attribute)
                {
                    case "str":
                        HeroAttributesController.attributePlus("str");
                        buttonCounterStr++;
                        break;
                    case "end":
                        buttonCounterEnd++;
                        HeroAttributesController.attributePlus("end");
                        break;
                    case "knd":
                        buttonCounterKnd++;
                        HeroAttributesController.attributePlus("knd");
                        break;
                    case "chr":
                        buttonCounterChr++;
                        HeroAttributesController.attributePlus("chr");
                        break;
                        //TEMP CASE 10
                    case "str10":
                        for (int i = 0; i < 10; ++i)
                        {
                            HeroAttributesController.attributePlus("str");
                            buttonCounterStr++;
                        }
                        break;
                    case "end10":
                        for (int i = 0; i < 10; ++i)
                        {
                            HeroAttributesController.attributePlus("end");
                            buttonCounterEnd++;
                        }
                        break;
                    case "knd10":
                        for (int i = 0; i < 10; ++i)
                        {
                            HeroAttributesController.attributePlus("knd");
                            buttonCounterKnd++;
                        }
                        break;
                    case "chr10":
                        for (int i = 0; i < 10; ++i)
                        {
                            HeroAttributesController.attributePlus("chr");
                            buttonCounterChr++;
                        }
                        break;
                }

                updateVisuals();
                updated = false;
            }
        }

        public void attributeMinusButton(string attribute)
        {
            switch (attribute)
            {
                case "str":
                    if (HeroController.mainHero.baseStrength > 0)
                    {
                        HeroAttributesController.attributeMinus("str");
                        buttonCounterStr--;
                    }
                    break;
                case "end":
                    if (HeroController.mainHero.baseEndurance > 0)
                    {
                        HeroAttributesController.attributeMinus("end");
                        buttonCounterEnd--;
                    }
                        break;
                case "knd":
                    if (HeroController.mainHero.baseKnowledge > 0)
                    {
                        HeroAttributesController.attributeMinus("knd");
                        buttonCounterKnd--;
                    }
                        break;
                case "chr":
                    if (HeroController.mainHero.baseCharisma > 0)
                    {
                        HeroAttributesController.attributeMinus("chr");
                        buttonCounterChr--;
                    }
                        break;
                //TEMP CASE 10
                case "str10":
                    for(int i=0;i<10;++i)
                        if (HeroController.mainHero.baseStrength > 0)
                        {
                            HeroAttributesController.attributeMinus("str");
                            buttonCounterStr--;
                        }
                    break;
                case "end10":
                    for (int i = 0; i < 10; ++i)
                        if (HeroController.mainHero.baseEndurance > 0)
                        {
                            HeroAttributesController.attributeMinus("end");
                            buttonCounterEnd--;
                        }
                    break;
                case "knd10":
                    for (int i = 0; i < 10; ++i)
                        if (HeroController.mainHero.baseKnowledge > 0)
                        {
                            HeroAttributesController.attributeMinus("knd");
                            buttonCounterKnd--;
                        }
                    break;
                case "chr10":
                    for (int i = 0; i < 10; ++i)
                        if (HeroController.mainHero.baseCharisma > 0)
                        {
                            HeroAttributesController.attributeMinus("chr");
                            buttonCounterChr--;
                        }
                    break;
            }

            updateVisuals();
            updated = false;
        }

        private void updateButtons()
        {
            //activate pluss attribute buttons
            if (HeroController.mainHero.freeAttributePoints > 0)
            {
                for (int i = 0; i < plusButtons.Length;++i)
                {
                    plusButtons[i].SetActive(true);
                }
            }

            //if counters > 0 activate minus buttons
            //else deactivate minus button
            if (buttonCounterStr > 0)
            {
                minusButtons[0].SetActive(true);
                if (buttonCounterStr >= 10)
                    minusButtons[4].SetActive(true);
                else
                    minusButtons[4].SetActive(false);
            }
            else
            {
                minusButtons[0].SetActive(false);
                minusButtons[4].SetActive(false);
            }
            if (buttonCounterEnd > 0)
            {
                minusButtons[1].SetActive(true);
                if (buttonCounterEnd >= 10)
                    minusButtons[5].SetActive(true);
                else
                    minusButtons[5].SetActive(false);
            }
            else
            {
                minusButtons[1].SetActive(false);
                minusButtons[5].SetActive(false);
            }
            if (buttonCounterKnd > 0)
            {
                minusButtons[2].SetActive(true);
                if (buttonCounterKnd >= 10)
                    minusButtons[6].SetActive(true);
                else
                    minusButtons[6].SetActive(false);
            }
            else
            {
                minusButtons[2].SetActive(false);
                minusButtons[6].SetActive(false);
            }
            if (buttonCounterChr > 0)
            {
                minusButtons[3].SetActive(true);
                if (buttonCounterChr >= 10)
                    minusButtons[7].SetActive(true);
                else
                    minusButtons[7].SetActive(false);
            }
            else
            {
                minusButtons[3].SetActive(false);
                minusButtons[7].SetActive(false);
            }
            updated = true;
        }

        public void resetSession()
        {
            buttonCounterStr = 0;
            buttonCounterEnd = 0;
            buttonCounterKnd = 0;
            buttonCounterChr = 0;
            updated = false;
        }
    }

}
