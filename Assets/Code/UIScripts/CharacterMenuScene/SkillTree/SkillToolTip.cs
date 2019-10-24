using Assets.Code.Skills;
using Assets.Code.SystemScripts;
using Assets.Code.SystemScripts.DataStructures;
using Assets.Code.SystemScripts.LocalisationScripts;
using Assets.Code.SystemScripts.LocalisationScripts.LocalisationDataStructures;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            skillsLocalisationData = LocalisationManager.skillsLocalisationData;
            skillsData = ResourcesManager.skillsData;
        }

        public void generateToolTip(A_Skill skill, string flag)
        {
            if (!toolTipGenerated)
            {
                SkillsLocalisationData skillLocalisation = skillsLocalisationData.Find(x => x.skillName.Equals(skill.skillName));
                SkillsData skillData = skillsData.Find(x => x.skillName.Equals(skill.skillName));

                bool isAllowedToGenerateToolTip = true;
                switch (flag)
                {
                    case "LoadCurrentLevel":
                        {
                            loadCurrentLevel(skill, skillLocalisation, skillData);
                            break;
                        }
                    case "LoadNextLevel":
                        {
                            if (skill.skillLevel < skill.skillMaxLevel)
                                loadNextLevel(skill, skillLocalisation, skillData);
                            else isAllowedToGenerateToolTip = false;
                            break;
                        }
                    case "LoadPreviousLevel":
                        {
                            if (skill.skillLevel > 1)
                                loadPreviousLevel(skill, skillLocalisation, skillData);
                            else isAllowedToGenerateToolTip = false;
                            break;
                        }
                }

                if (isAllowedToGenerateToolTip)
                {
                    gameObject.SetActive(true);
                    toolTipGenerated = true;
                }
            }
        }

        private void loadCurrentLevel(A_Skill skill, SkillsLocalisationData skillLocalisation, SkillsData skillData)
        {
            Dictionary<string, string> systemMessages = LocalisationManager.systemMessagesLocalisationData.localisationValues["CharacterMenu"];

            skillName.text = skillLocalisation.skillLocalisedName;
            skillLevel.text = systemMessages["SkillLevel"] + skill.skillLevel.ToString(); // get actual level from game object
            skillAvailability.text = SkillTreeController.getSkillAvailability(skill, LocalisationManager.systemMessagesLocalisationData.localisationValues["CharacterMenu"]);
            skillAPcost.text = systemMessages["APCost"] + skillData.skillAPCost[skill.skillLevel];
            skillEneCost.text = systemMessages["EneCost"] + skillData.skillEneCost[skill.skillLevel];
            skillTargets.text = systemMessages["Targets"] + skillLocalisation.skillTargetsDescription[skill.skillLevel - 1];
            skillDuration.text = systemMessages["Duration"] + SkillTreeController.getSkillDuration(skillData, skill.skillLevel, systemMessages);
            skillGeneralDescription.text = systemMessages["SkillGeneralDescription"] + skillLocalisation.skillMainDescription;
            skillLevelDescription.text = getLocalisedText(skillLocalisation, skillData, skill.skillLevel);

        }

        private void loadNextLevel(A_Skill skill, SkillsLocalisationData skillLocalisation, SkillsData skillData)
        {           
            if (skill.skillLevel + 1 <= skill.skillMaxLevel)
            {
                Dictionary<string, string> systemMessages = LocalisationManager.systemMessagesLocalisationData.localisationValues["CharacterMenu"];

                skillName.text = skillLocalisation.skillLocalisedName;
                skillLevel.text = systemMessages["SkillLevel"] + Convert.ToString(skill.skillLevel + 1);                
                skillAvailability.text = SkillTreeController.getSkillAvailability(skill, systemMessages);
                skillAPcost.text = systemMessages["APCost"] + skillData.skillAPCost[skill.skillLevel] +" -> "
                    + "<color=#20B51B>" + skillData.skillAPCost[skill.skillLevel +1 ] + "</color>";
                skillEneCost.text = systemMessages["EneCost"] + skillData.skillEneCost[skill.skillLevel] +" -> "
                    + "<color=#20B51B>" + skillData.skillEneCost[skill.skillLevel +1 ] + "</color>";
                skillTargets.text = systemMessages["Targets"] +
                    skillLocalisation.skillTargetsDescription[skill.skillLevel-1] + "->" + "<color=#20B51B>"
                    + skillLocalisation.skillTargetsDescription[skill.skillLevel] + "</color>"; 
                skillDuration.text = systemMessages["Duration"] 
                    + SkillTreeController.getSkillDuration(skillData, skill.skillLevel, systemMessages) 
                    + " -> " + "<color=#20B51B>"
                    + SkillTreeController.getSkillDuration(skillData, (short)(skill.skillLevel + 1) ,systemMessages)
                    + "</color>";
                skillGeneralDescription.text = systemMessages["SkillGeneralDescription"] + skillLocalisation.skillMainDescription;
                skillLevelDescription.text = getLocalisedTextForNextLevel(skillLocalisation, skillData,
                    (short)(skill.skillLevel-1), skill.skillLevel, "<color=#20B51B>");
            }
        }

        private void loadPreviousLevel(A_Skill skill, SkillsLocalisationData skillLocalisation, SkillsData skillData)
        {
            //NOT TESTED
            if (skill.skillLevel - 1 > 0)
            {
                Dictionary<string, string> systemMessages = LocalisationManager.systemMessagesLocalisationData.localisationValues["CharacterMenu"];

                skillName.text = skillLocalisation.skillLocalisedName;
                skillLevel.text = systemMessages["SkillLevel"] + Convert.ToString(skill.skillLevel - 1);
                skillAvailability.text = SkillTreeController.getSkillAvailability(skill, LocalisationManager.systemMessagesLocalisationData.localisationValues["CharacterMenu"]);
                skillAPcost.text = systemMessages["APCost"] + skillData.skillAPCost[skill.skillLevel] + " -> "
                     + "<color=#FF0004>" + skillData.skillAPCost[skill.skillLevel - 1] + "</color>";
                skillEneCost.text = systemMessages["EneCost"] + skillData.skillEneCost[skill.skillLevel] + " -> "
                    + "<color=#FF0004>" + skillData.skillEneCost[skill.skillLevel - 1] + "</color>";
                skillTargets.text = systemMessages["Targets"] +
                    skillLocalisation.skillTargetsDescription[skill.skillLevel - 1] + "->" + "<color=#FF0004>"
                    + skillLocalisation.skillTargetsDescription[skill.skillLevel - 2] + "</color>";
                skillDuration.text = systemMessages["Duration"]
                    + SkillTreeController.getSkillDuration(skillData, skill.skillLevel, systemMessages)
                    + " -> " + "<color=#FF0004>"
                    + SkillTreeController.getSkillDuration(skillData, (short)(skill.skillLevel - 1), systemMessages)
                    + "</color>";
                skillGeneralDescription.text = systemMessages["SkillGeneralDescription"] + skillLocalisation.skillMainDescription;
                skillLevelDescription.text = getLocalisedTextForNextLevel(skillLocalisation, skillData,
                    (short)(skill.skillLevel - 1),(short)(skill.skillLevel -2), "<color=#FF0004>");
            }
        }

        private string getLocalisedText(SkillsLocalisationData localisation, SkillsData data, int skillLevel)
        {
            string fullDescription = localisation.skillLocalisedLevelDescription[skillLevel-1];
            foreach (KeyValuePair<string, string> pair in data.skillValues[skillLevel-1])
            {
                fullDescription = fullDescription.Replace("$" + pair.Key + "$", pair.Value);
            }

            return fullDescription;
        }

        private string getLocalisedTextForNextLevel(SkillsLocalisationData localisation, SkillsData data,
            short skillCurrentLevel, int skillAnotherLevel, string textColor)
        {
            string fullCurrentLevelDescription = localisation.skillLocalisedLevelDescription[skillCurrentLevel];
            string fullAnotherLevelDescription = localisation.skillLocalisedLevelDescription[skillAnotherLevel];
           

            foreach (KeyValuePair<string, string> pair in data.skillValues[skillAnotherLevel])
            {
                if(fullCurrentLevelDescription.Contains("$"+pair.Key+"$"))
                fullAnotherLevelDescription = fullAnotherLevelDescription.
                    Replace("$" + pair.Key + "$", "$"+pair.Key+"$1^"+" -> $"+pair.Key+"$2^");
                else
                    fullAnotherLevelDescription = fullAnotherLevelDescription.
                    Replace("$" + pair.Key + "$", "$" + pair.Key + "$2^");
            }

            foreach (KeyValuePair<string, string> pair in data.skillValues[skillCurrentLevel])
            {
                fullAnotherLevelDescription = fullAnotherLevelDescription.
                    Replace("$" + pair.Key + "$1^", pair.Value);
            }

            foreach (KeyValuePair<string, string> pair in data.skillValues[skillAnotherLevel])
            {
                fullAnotherLevelDescription = fullAnotherLevelDescription.
                    Replace("$" + pair.Key + "$2^", textColor + pair.Value+ "</color>");
            }

            return fullAnotherLevelDescription;
        }

        public void setToolTipGeneratedValue(bool val)
        {
            toolTipGenerated = val;
        }
    }
}
