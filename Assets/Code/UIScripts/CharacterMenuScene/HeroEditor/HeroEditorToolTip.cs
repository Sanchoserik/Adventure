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

        private void Start()
        {
            toolTipGenerated = false;
            gameObject.SetActive(false);
           
        }

        public void generateToolTip(string flag)
        {
            if (!toolTipGenerated)
            {
                Dictionary<string,string> systemMessages = LocalisationManager.systemMessagesLocalisationData.localisationValues["CharacterMenu"];

                switch (flag)
                {
                    case "BaseMaxHP":
                        genBaseHP(systemMessages["BaseMaxHP"]);
                        break;
                    case "TotalHP":
                        genTotalHP(systemMessages["TotalHP"]);
                        break;
                    case "BaseMaxENE":
                        genBaseENE(systemMessages["BaseMaxENE"]);
                        break;
                    case "TotalENE":
                        genTotalENE(systemMessages["TotalENE"]);
                        break;

                }

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

    }
}
