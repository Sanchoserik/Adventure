using Assets.Code.Skills;
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

        public static string getSkillAvailability(A_Skill skill)
        {
            //TO DO replace this text messages with some localisation function
            if (skill.isAvailableForLearning)
                {
                if (skill.isLearned)
                    return "Learned";
                else if (HeroController.mainHero.freeSkillPoints > 0)
                    return "Available";
                else
                    return "Available but NOT enough skillPoints";
                }
                else
                    return "NotAvailable";                        
        }


    }
}
