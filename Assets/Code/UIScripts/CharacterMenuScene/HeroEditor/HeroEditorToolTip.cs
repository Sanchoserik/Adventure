using Assets.Code.SystemScripts.LocalisationScripts;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene.HeroEditor
{
    public class HeroEditorToolTip : MonoBehaviour
    {
        public Text helpInfo;

        private bool toolTipGenerated;
        private Dictionary<string, Action> tooltipGenerator;

        Dictionary<string, string> systemMessages;


        private void Start()
        {
            tooltipGenerator = new Dictionary<string, Action> {
                { "BaseMaxHP", () => genBaseHP(systemMessages["BaseMaxHP"])},
                { "TotalHP", () => genTotalHP(systemMessages["TotalHP"])},
                { "BaseMaxENE", () => genBaseENE(systemMessages["BaseMaxENE"])},
                { "TotalENE", () => genTotalENE(systemMessages["TotalENE"])},
                { "TotalStr", () => genTotalStr(systemMessages["TotalStr"])},
                { "TotalEnd", () => genTotalEnd(systemMessages["TotalEnd"])},
                { "TotalKnd", () => genTotalKnd(systemMessages["TotalKnd"])},
                { "TotalChr", () => genTotalChr(systemMessages["TotalChr"])},
                { "airDef", () => genAirDef(systemMessages["airDef"])},
                { "lightningDef", () => genLightningDef(systemMessages["lightningDef"])},
                { "earthDef", () => genEarthDef(systemMessages["earthDef"])},
                { "waterDef", () => genWaterDef(systemMessages["waterDef"])},
                { "fireDef", () => genFireDef(systemMessages["fireDef"])},
                { "lifeDef", () => genLifeDef(systemMessages["lifeDef"])},
                { "deathDef", () => genDeathDef(systemMessages["deathDef"])},
                { "lightDef", () => genLightDef(systemMessages["lightDef"])},
                { "darknessDef", () => genDarknessDef(systemMessages["darknessDef"])},
                { "physDef", () => genPhysDef(systemMessages["physDef"])},
            };

            systemMessages = LocalisationManager.systemMessagesLocalisationData.localisationValues["CharacterMenu"];
            toolTipGenerated = false;
            gameObject.SetActive(false);         
        }
      
        public void generateToolTip(string flag)
        {
            if (!toolTipGenerated)
            {           
                tooltipGenerator[flag]();

                gameObject.SetActive(true);
                toolTipGenerated = true;
            }
        }

        public void setToolTipGeneratedValue(bool val)
        {
            toolTipGenerated = val;
        }

        private void genBaseHP(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$BaseHP$", hero.baseHP.ToString());
            str.Replace("$EndVal$", (hero.totalEndurance * 5).ToString());
            str.Replace("$Val$", ((hero.baseHP + hero.totalEndurance * 5) *hero.totalEndurance /10 /100).ToString());
            str.Replace("$End%$", (hero.totalEndurance / 10).ToString());

            helpInfo.text = str.ToString();
        }

        private void genTotalHP(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$BaseHP$", hero.baseMaxHP.ToString());
            str.Replace("$BonusVal$", hero.bonusHPValue.ToString());
            str.Replace("$Val$", ((hero.baseMaxHP+hero.bonusHPValue) * hero.bonusHPPercent / 100).ToString());
            str.Replace("$B%$", hero.bonusHPPercent.ToString());

            helpInfo.text = str.ToString();
        }

        private void genBaseENE(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$BaseENE$", hero.baseENE.ToString());
            str.Replace("$KndVal$", (hero.totalKnowledge * 3).ToString());
          
            helpInfo.text = str.ToString();
        }

        private void genTotalENE(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$BaseENE$", hero.baseMaxENE.ToString());
            str.Replace("$BonusVal$", hero.bonusENEValue.ToString());
            str.Replace("$Val$", ((hero.baseMaxENE + hero.bonusENEValue) * hero.bonusENEPercent / 100).ToString());
            str.Replace("$B%$", hero.bonusENEPercent.ToString());

            helpInfo.text = str.ToString();
        }

        private void genTotalStr(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$BaseStr$", hero.baseStrength.ToString());
            str.Replace("$BonusStr$", hero.bonusStrength.ToString());
            str.Replace("$Val$", ((hero.baseStrength + hero.bonusStrength) * hero.bonusStrengthPercent / 100).ToString());
            str.Replace("$B%$", hero.bonusStrengthPercent.ToString());

            helpInfo.text = str.ToString();
        }

        private void genTotalEnd(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$BaseEnd$", hero.baseEndurance.ToString());
            str.Replace("$BonusEnd$", hero.bonusEndurance.ToString());
            str.Replace("$Val$", ((hero.baseEndurance + hero.bonusEndurance) * hero.bonusEndurancePercent / 100).ToString());
            str.Replace("$B%$", hero.bonusEndurancePercent.ToString());

            helpInfo.text = str.ToString();
        }

        private void genTotalKnd(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$BaseKnd$", hero.baseKnowledge.ToString());
            str.Replace("$BonusKnd$", hero.bonusKnowledge.ToString());
            str.Replace("$Val$", ((hero.baseKnowledge + hero.bonusKnowledge) * hero.bonusKnowledgePercent / 100).ToString());
            str.Replace("$B%$", hero.bonusKnowledgePercent.ToString());

            helpInfo.text = str.ToString();
        }

        private void genTotalChr(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$BaseChr$", hero.baseCharisma.ToString());
            str.Replace("$BonusChr$", hero.bonusCharisma.ToString());
            str.Replace("$Val$", ((hero.baseCharisma + hero.bonusCharisma) * hero.bonusCharismaPercent / 100).ToString());
            str.Replace("$B%$", hero.bonusCharismaPercent.ToString());

            helpInfo.text = str.ToString();
        }

        private void genAirDef(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$base$", HeroAttributesController.getDefParamState(hero.airDef, systemMessages));
            str.Replace("$bonus$", HeroAttributesController.getDefParamState(hero.bonusAirDef, systemMessages));

            helpInfo.text = str.ToString();
        }

        private void genLightningDef(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$base$", HeroAttributesController.getDefParamState(hero.lightningDef, systemMessages));
            str.Replace("$bonus$", HeroAttributesController.getDefParamState(hero.bonusLightningDef, systemMessages));

            helpInfo.text = str.ToString();
        }

        private void genEarthDef(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$base$", HeroAttributesController.getDefParamState(hero.earthDef, systemMessages));
            str.Replace("$bonus$", HeroAttributesController.getDefParamState(hero.bonusEarthDef, systemMessages));

            helpInfo.text = str.ToString();
        }

        private void genWaterDef(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$base$", HeroAttributesController.getDefParamState(hero.waterDef, systemMessages));
            str.Replace("$bonus$", HeroAttributesController.getDefParamState(hero.bonusWaterDef, systemMessages));

            helpInfo.text = str.ToString();
        }

        private void genFireDef(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$base$", HeroAttributesController.getDefParamState(hero.fireDef, systemMessages));
            str.Replace("$bonus$", HeroAttributesController.getDefParamState(hero.bonusFireDef, systemMessages));

            helpInfo.text = str.ToString();
        }

        private void genLifeDef(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$base$", HeroAttributesController.getDefParamState(hero.lifeDef, systemMessages));
            str.Replace("$bonus$", HeroAttributesController.getDefParamState(hero.bonusLifeDef, systemMessages));

            helpInfo.text = str.ToString();
        }

        private void genDeathDef(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$base$", HeroAttributesController.getDefParamState(hero.deathDef, systemMessages));
            str.Replace("$bonus$", HeroAttributesController.getDefParamState(hero.bonusDeathDef, systemMessages));

            helpInfo.text = str.ToString();
        }

        private void genLightDef(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$base$", HeroAttributesController.getDefParamState(hero.lightDef, systemMessages));
            str.Replace("$bonus$", HeroAttributesController.getDefParamState(hero.bonusLightDef, systemMessages));

            helpInfo.text = str.ToString();
        }

        private void genDarknessDef(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$base$", HeroAttributesController.getDefParamState(hero.darknessDef, systemMessages));
            str.Replace("$bonus$", HeroAttributesController.getDefParamState(hero.bonusDarknessDef, systemMessages));

            helpInfo.text = str.ToString();
        }

        private void genPhysDef(string sysText)
        {
            C_Hero hero = HeroController.mainHero;
            StringBuilder str = new StringBuilder(sysText);

            str.Replace("$base$", HeroAttributesController.getDefParamState(hero.physDef, systemMessages));
            str.Replace("$bonus$", HeroAttributesController.getDefParamState(hero.bonusPhysDef, systemMessages));

            helpInfo.text = str.ToString();
        }

    }
}
