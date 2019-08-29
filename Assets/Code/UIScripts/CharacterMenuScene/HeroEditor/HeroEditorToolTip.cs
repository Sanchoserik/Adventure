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
                    case "BaseMaxHP": genBaseHP(systemMessages["BaseMaxHP"]);
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

    }
}
