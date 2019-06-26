using Assets.Code.Skills;
using Assets.Code.SystemScripts.DataStructures;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene.SkillTree
{
    public class SkillTreeController : MonoBehaviour
    {
        public GameObject[] skillTrees = new GameObject[4];

        private List<A_Skill> skillTree;

        private void Start()
        {
            skillTree = HeroController.mainHero.heroSkills.skillsList;
            initializeSkills(skillTrees);
        }
  
        private void initializeSkills(GameObject[] parent)
        {
            for (int i = 0; i < parent.Length; ++i)
            {
                foreach (Transform childSkill in parent[i].transform) //skills
                {
                    setSkillsLevels(childSkill);
                    setUISkills(childSkill);
                }
            }
        }

        private void setSkillsLevels(Transform childSkill)
        {
            A_Skill skill = skillTree.Find(x => x.skillName.Equals(childSkill.name));
            Text levelText = childSkill.GetComponentInChildren<Text>();
            levelText.text = skill.skillLevel + "/" + skill.skillMaxLevel;
        }

        private void setUISkills(Transform childSkill)
        {
            A_Skill skill = skillTree.Find(x => x.skillName.Equals(childSkill.name));
            Transform skillIcon = childSkill.transform.Find("Icon");
            UISkill UIskill = skillIcon.GetComponent<UISkill>();
            UIskill.skill = skill;

            Transform skillNextLevel = childSkill.transform.Find("Plus");
            UISkillNextLevel skillNext = skillNextLevel.GetComponent<UISkillNextLevel>();
            skillNext.skill = skill;

            Transform skillPreviousLevel = childSkill.transform.Find("Minus");
            UISkillPreviousLevel skillPrevious = skillPreviousLevel.GetComponent<UISkillPreviousLevel>();
            skillPrevious.skill = skill;
        }

        public static string getSkillAvailability(A_Skill skill, Dictionary<string,string> systemMessages)
        {            
            if (skill.isAvailableForLearning)
                {
                if (skill.isLearned)
                    return "<color=#20B51B>" + systemMessages["SkillLearned"] + "</color>";
                else if (HeroController.mainHero.freeSkillPoints > 0)
                    return "<color=#FFFF00>" + systemMessages["SkillAvailable"] + "</color>";
                else
                    return "<color=#FFB600>" + systemMessages["SkillAvailableButNoSkillPoints"] + "</color>";
                }
                else
                    return "<color=#FF0004>" + systemMessages["SkillIsNotAvailable"] + "</color>";                        
        }

        public static string getSkillDuration(SkillsData skillData, short level, Dictionary<string, string> systemMessages)
        {
            if (!skillData.skillValues[level-1].ContainsKey("Time"))
                return systemMessages["ThereIsnoDuration"];
            else
                return skillData.skillValues[level-1]["Time"];
        }
    }
}
