using Assets.Code.Skills;
using Assets.Code.SystemScripts.DataStructures;
using Assets.Code.SystemScripts.LocalisationScripts.LocalisationDataStructures;
using Assets.PlayerController;
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
        public Text skillName;
        public Text skillLevel;
        public Text skillAvailability;
        public Text skillAPcost;
        public Text skillEneCost;
        public Text skillTargets;
        public Text skillDuration;
        public Text skillGeneralDescription;
        public Text skillLevelDescription;

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

        public void generateToolTip(A_Skill skill, string flag)
        {
            if (!toolTipGenerated)
            {
                SkillsLocalisationData skillLocalisation = skillsLocalisationData.Find(x => x.skillName.Equals(skill.skillName));
                SkillsData skillData = skillsData.Find(x => x.skillName.Equals(skill.skillName));

                switch (flag)
                {
                    case "loadCurrentLevel": { loadCurrentLevel(skill, skillLocalisation, skillData); break; }
                    case "LoadNextLevel": { break; }
                    case "LoadPreviousLevel": { break; }
                }

                gameObject.SetActive(true);
                toolTipGenerated = true;
            }
        }

        private void loadCurrentLevel(A_Skill skill, SkillsLocalisationData skillLocalisation, SkillsData skillData)
        {

            skillName.text = skillLocalisation.skillLocalisedName;
            skillLevel.text = skill.skillLevel.ToString(); // get actual level from game object
            skillAvailability.text = SkillTreeController.getSkillAvailability(skill);
            skillAPcost.text = skillData.skillAPCost[skill.skillLevel];
            skillEneCost.text = skillData.skillEneCost[skill.skillLevel];
            skillTargets.text = skillLocalisation.skillTargetsDescription[skill.skillLevel - 1];
            skillDuration.text = skill.skillDuration.ToString(); //TO DO if = 0 set as X 
            skillGeneralDescription.text = skillLocalisation.skillMainDescription;
            skillLevelDescription.text = getLocalisedText(skillLocalisation, skillData, skill.skillLevel);

        }

        private void loadNextLevel(A_Skill skill, SkillsLocalisationData skillLocalisation, SkillsData skillData)
        {
            if (skill.skillLevel + 1 <= skill.skillMaxLevel)
            {
                skillName.text = skillLocalisation.skillLocalisedName;
                skillLevel.text = Convert.ToString(skill.skillLevel + 1);                
                skillAvailability.text = SkillTreeController.getSkillAvailability(skill);
                skillAPcost.text = skillData.skillAPCost[skill.skillLevel+1];
                skillEneCost.text = skillData.skillEneCost[skill.skillLevel+1];
                skillTargets.text = skillLocalisation.skillTargetsDescription[skill.skillLevel]; 
                skillDuration.text = skill.skillDuration.ToString(); //TO DO if = 0 set loacalisation message as Don't Have Duration or smth 
                skillGeneralDescription.text = skillLocalisation.skillMainDescription;
                skillLevelDescription.text = getLocalisedText(skillLocalisation, skillData, (short)(skill.skillLevel +1));
            }
        }

        private void loadPreviousLevel(A_Skill skill, SkillsLocalisationData skillLocalisation, SkillsData skillData)
        {
            if (skill.skillLevel - 1 > 0)
            {
                skillName.text = skillLocalisation.skillLocalisedName;
                skillLevel.text = Convert.ToString(skill.skillLevel - 1);
                skillAvailability.text = SkillTreeController.getSkillAvailability(skill);
                skillAPcost.text = skillData.skillAPCost[skill.skillLevel - 1];
                skillEneCost.text = skillData.skillEneCost[skill.skillLevel - 1];
                skillTargets.text = skillLocalisation.skillTargetsDescription[skill.skillLevel - 2];
                skillDuration.text = skill.skillDuration.ToString(); //TO DO if = 0 set loacalisation message as Don't Have Duration or smth 
                skillGeneralDescription.text = skillLocalisation.skillMainDescription;
                skillLevelDescription.text = getLocalisedText(skillLocalisation, skillData, (short)(skill.skillLevel - 1));
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
