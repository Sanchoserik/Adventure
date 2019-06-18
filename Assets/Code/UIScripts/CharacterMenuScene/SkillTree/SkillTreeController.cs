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
            loadSkillLevels(skillTrees);
        }

        private void loadSkillLevels(GameObject[] parent)
        {
            for (int i = 0; i < parent.Length; ++i)
            {
                foreach (Transform childskill in parent[i].transform) //skills
                {
                    A_Skill skill = skillTree.Find(x => x.skillName.Equals(childskill.name));
                    Text t = childskill.GetComponentInChildren<Text>();
                    t.text = skill.skillLevel + "/" + skill.skillMaxLevel;                       
                }
            }
        }

        public static string getSkillAvailability(A_Skill skill)
        {
            if (skill.isAvailableForLearning)
            {
                if (skill.isLearned)
                    return "Learned";
                else
                    return "Available";
            }
            else
                return "NotAvailable";
        }
    }
}
