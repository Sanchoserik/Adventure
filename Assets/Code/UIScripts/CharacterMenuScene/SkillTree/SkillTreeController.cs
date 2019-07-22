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
        public SkillToolTip skillToolTip;
        public CharacterMenuController cmController;// = new CharacterMenuController();//TEMP

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
            if(skill.isLearned)
                levelText.text = skill.skillLevel + "/" + skill.skillMaxLevel;
            else
                levelText.text = "0/" + skill.skillMaxLevel;
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

        public void skillLevelUp(GameObject skillObject)
        {
            if (HeroController.mainHero.freeSkillPoints > 0)
            {
                string skillName = skillObject.name;
                A_Skill skill = skillTree.Find(x => x.skillName == skillName);
                // skills are default level 1 
                if ((skill.skillLevel + 1 <= skill.skillMaxLevel) || (!skill.isLearned && skill.skillMaxLevel == 1))
                { 
                    if (skill.isAvailableForLearning && !skill.isLearned)
                    {
                        HeroSkillsController.setSkillAsLearned(skill);
                        HeroSkillsController.getNewAvailableSKills(skillTree, skillName);
                        --HeroController.mainHero.freeSkillPoints;
                        refreshSkillLevelText(skillObject, skillName, skill);
                    }
                    else if (skill.isLearned)
                    {
                        ++skill.skillLevel;
                        refreshSkillLevelText(skillObject, skillName, skill);
                        --HeroController.mainHero.freeSkillPoints;                       
                    }
                    refreshSkillLevelText(skillObject, skillName, skill);
                    skillToolTip.setToolTipGeneratedValue(false);
                    skillToolTip.generateToolTip(skill, "LoadNextLevel");
                    cmController.getSkillPoints();                  
                }
            }
        }

        public void skillLevelDown(GameObject skillObject)
        {
            string skillName = skillObject.name;
            A_Skill skill = skillTree.Find(x => x.skillName == skillName);

            if (skill.skillLevel - 1 >= 0 && skill.isLearned == true)
            {
                if (skill.skillLevel - 1 >= 1)
                {
                    --skill.skillLevel;                   
                    ++HeroController.mainHero.freeSkillPoints;
                    skillToolTip.setToolTipGeneratedValue(false);
                    skillToolTip.generateToolTip(skill, "LoadPreviousLevel");
                    refreshSkillLevelText(skillObject, skillName, skill);
                }
                else if (skill.skillLevel - 1 == 0 && !skill.skillName.Equals("Rearm")) // Rearm is starting point for skills learning
                {
                    HeroSkillsController.setSkillAsNotLearned(skill);
                    HeroSkillsController.cascadeSkillRemoval(skillTree, skill);
                    initializeSkills(skillTrees); // Need to refresh all skills                    
                }                
                cmController.getSkillPoints();               
            }

        }

        private void refreshSkillLevelText(GameObject _skill, string _sName, A_Skill _s)
        {
            Text t = _skill.GetComponentInChildren<Text>();
            if (_s.isLearned)
                t.text = _s.skillLevel + "/" + _s.skillMaxLevel;
            else
                t.text = "0/" + _s.skillMaxLevel;
        }

    }
}
