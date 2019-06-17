using Assets.Code.Skills;
using Assets.Code.SystemScripts.DataStructures;
using Assets.Code.SystemScripts.LocalisationScripts.LocalisationDataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene.SkillTree
{
    public class SkillToolTip : MonoBehaviour
    {
        Text skillName;
        Text skillLevel;
        Text skillAvailability;
        Text skillAPcost;
        Text skillEneCost;
        Text skillTargets;
        Text skillDuration;
        Text skillGeneralDescription;
        Text skillLevelDescription;

        private bool toolTipGenerated;
        private List<SkillsLocalisationData> skillsLocalisationData;
        private List<SkillsData> skillsData;

        private void Start()
        {
            toolTipGenerated = false;
            gameObject.SetActive(false);
            skillsLocalisationData = SystemScripts.LoadLocalisation.skillsLocalisationData;
            skillsData = SystemScripts.ResourcesManager.skillsData;
        }

        public void generateToolTip(A_Skill skill)
        {

        }

        private string getLocalisedText(SkillsLocalisationData localisation, SkillsData data)
        {
            //string fullDescription = localisation.itemLocalisedDescription;
            //foreach (KeyValuePair<string, string> pair in data.potionParameters)
            //{
            //    fullDescription = fullDescription.Replace("$" + pair.Key + "$", pair.Value);
            //}

            return ""; //fullDescription;
        }

        public void setToolTipGeneratedValue(bool val)
        {
            toolTipGenerated = val;
        }
    }
}
