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

        public void generateCurrentLevelToolTip(A_Skill skill)
        {
            if (!toolTipGenerated)
            {
                SkillsLocalisationData skillLocalisation = skillsLocalisationData.Find(x => x.skillName.Equals(skill.skillName));
                SkillsData skillData = skillsData.Find(x => x.skillName.Equals(skill.skillName));
                
                skillName.text = skillLocalisation.skillLocalisedName;
                skillLevel.text = skill.skillLevel.ToString(); // get actual level from game object
                skillAvailability.text = SkillTreeController.getSkillAvailability(skill);
                skillAPcost.text = skill.actionPointsCost.ToString();
                skillEneCost.text = skill.energyCost.ToString();
                skillTargets.text = skillLocalisation.skillTargetsDescription[skill.skillLevel - 1];
                skillDuration.text = skill.skillDuration.ToString(); //TO DO if = 0 set as X 
                skillGeneralDescription.text = skillLocalisation.skillMainDescription;
                skillLevelDescription.text = getLocalisedText(skillLocalisation, skillData, skill.skillLevel);

                gameObject.SetActive(true);
                toolTipGenerated = true;
            }
        }

        private string getLocalisedText(SkillsLocalisationData localisation, SkillsData data, short skillLevel)
        {
            string fullDescription = localisation.skillLocalisedLevelDescription[skillLevel-1];
            foreach (KeyValuePair<string, string> pair in data.skillValues[skillLevel-1])
            {
                fullDescription = fullDescription.Replace("$" + pair.Key + "$", pair.Value);
            }

            return fullDescription;
        }

        public void setToolTipGeneratedValue(bool val)
        {
            toolTipGenerated = val;
        }

    }
}
