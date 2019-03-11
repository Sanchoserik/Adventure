using Assets.Code.Skills;
using Assets.PlayerController;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.SkillTreeScene
{
    public class ShowSkillDescr : MonoBehaviour
    {       
        public GameObject skillTreeParent; // Contains all skill prefabs
        
        //text UI objects
        public Text skillName; 
        public Text skillDescription; 
        public Text skillLevelDescription;
        public Text skillAPCost;
        public Text skillEnergyCost;
        public Text skillDuration;
        public Text skillTargets;
        public Text skillAvailability;
        public Text heroSkillPoints;

        private bool skillLoaded = false;
        private bool skillSelected = false;
        private bool visualValuesUpdated = true;

        private GameObject newSkill;
        private List<SkillDataStorage> data; // all skills data from loader xml file
        private List<A_Skill> skillTree;

        void Start()
        {         
            skillTree =  HeroController.mainHero.heroSkills.skillsList;
            data = HeroController.skillDataStorage;
            loadSkillLevels(skillTreeParent);
            heroSkillPoints.text = HeroController.mainHero.skillPoints.ToString();         
        }

        void Update()
        {
            //load skill once
            if (!skillLoaded && skillSelected)
            {
                loadSkillData(newSkill);
                skillLoaded = true;
                skillSelected = false;
            }
            if (!visualValuesUpdated)
            {
                updateTextValues(newSkill);
            }
        }

        //Update skillPoints UI value and skillAvailability UI value
        private void updateTextValues(GameObject _skill)
        {
            heroSkillPoints.text = HeroController.mainHero.skillPoints.ToString();

            A_Skill skill = skillTree.Find(x => x.skillName.Equals(_skill.name));
            skillAvailability.text = HeroSkillsController.getSkillAvailability(skill);
        }

        //LOAD LEVEL DATA
        void loadSkillData(GameObject _skill) 
        {
            this.skillLevelDescription.text = ""; 
            skillDuration.text = "";
            skillAvailability.text = "";

            SkillDataStorage _data = data.Find(x => x.skillName == _skill.name); //concrette skill storage

            skillName.text = _data.skillLocalisedName;
            skillDescription.text = _data.skillMainDescription;

            string skillLevelDescription = _data.skillLocalisedLevelDescription[_data.skillCurentLevel-1];
            List<string> skillValues = new List<string>();

            //every value is separated by $$ 
            //then divide values count by 2 to get actual values count 
            int _valCount = 0;
                for (int i = 0; i < skillLevelDescription.Length; ++i)
                    if (skillLevelDescription.Substring(i, 1).Equals("$"))
                        ++_valCount;                
                _valCount /= 2; 

                string _substr = skillLevelDescription; // temp full string
                for (int i = 0; i < _substr.Length; ++i)
                {
                    string _subChar = _substr.Substring(i, 1); //next char
                    if (_subChar.Equals("$"))
                    {
                        string _val = _substr.Substring(i + 1, _substr.Length - i - 1); // from $val to the end of curr string
                                                                                       
                        for (int j = 0; j < _val.Length; ++j)
                        {
                            string _subJ = _val.Substring(j, 1);
                            if (_subJ.Equals("$"))
                            {
                                string newVal = _val.Substring(0, j); // get value name
                                _substr = _val.Substring(j + 1, _val.Length - j - 1); // set new main string from $val$ to the end of current string 
                                skillValues.Add(newVal); // add value name to list
                                i = -1; // for i++ 

                                break; // end of $val$ go to next $val$ 
                            }
                        }
                    }
                }
                
                _substr = skillLevelDescription;
                foreach (string _val in skillValues)
                {
                    if (_data.skillValues[_data.skillCurentLevel-1].ContainsKey(_val))
                        _substr = _substr.Replace("$" + _val + "$", _data.skillValues[_data.skillCurentLevel-1][_val]);
                    else Debug.Log("not a key " + _val);
                }
                this.skillLevelDescription.text += _substr + "\n";

            //get APCost EnergyCost and Targets
            int _intkey = _data.skillCurentLevel;
            if (_data.skillAPCost.ContainsKey(_intkey)) 
            {
                skillAPCost.text = _data.skillAPCost[_data.skillCurentLevel];
                skillEnergyCost.text = _data.skillEneCost[_data.skillCurentLevel];
                skillTargets.text = _data.skillTargetsDescription[_data.skillCurentLevel-1]; //list
            }
            // get skill duration "Time" if exist
            if (_data.skillValues[_data.skillCurentLevel - 1].ContainsKey("Time"))
            {
                skillDuration.text = _data.skillValues[_data.skillCurentLevel - 1]["Time"];
            }

            //get skillAvailability
            skillAvailability.text = HeroSkillsController.getSkillAvailability(skillTree.Find(x => x.skillName.Equals(_data.skillName)));                    
        }  
        //CHANGE SKILL
        public void changeSkill(GameObject _newSkill)
        {
            skillSelected = true;
            skillLoaded = false;
            newSkill = _newSkill;
        }
        //CHANGE SKILL BRANCH
        public void changeSkillBranch(SkillButtonChangerData data)
        {
            switch (data._name)
            {
                case "T": //tactician
                    {
                        data._panel.SetActive(true);
                        GameObject _w = GameObject.Find("WarriorSkills"); if (_w != null) _w.SetActive(false);
                        GameObject _a = GameObject.Find("AssassinSkills"); if (_a != null) _a.SetActive(false);
                        GameObject _b = GameObject.Find("BruiserSkills"); if (_b != null) _b.SetActive(false);
                        break;
                    }
                case "W": //warrior
                    {
                        data._panel.SetActive(true);
                        GameObject _t = GameObject.Find("TacticianSkills"); if (_t != null) _t.SetActive(false);
                        GameObject _a = GameObject.Find("AssassinSkills"); if (_a != null) _a.SetActive(false);
                        GameObject _b = GameObject.Find("BruiserSkills"); if (_b != null) _b.SetActive(false);
                        break;
                    }
                case "A": //assassin
                    {
                        data._panel.SetActive(true);
                        GameObject _w = GameObject.Find("WarriorSkills"); if (_w != null) _w.SetActive(false);
                        GameObject _t = GameObject.Find("TacticianSkills"); if (_t != null) _t.SetActive(false);
                        GameObject _b = GameObject.Find("BruiserSkills"); if (_b != null) _b.SetActive(false);
                        break;
                    }
                case "B": //bruiser
                    {
                        data._panel.SetActive(true);
                        GameObject _w = GameObject.Find("WarriorSkills"); if (_w != null) _w.SetActive(false);
                        GameObject _a = GameObject.Find("AssassinSkills"); if (_a != null) _a.SetActive(false);
                        GameObject _t = GameObject.Find("TacticianSkills"); if (_t != null) _t.SetActive(false);
                        break;
                    }
            }
        }
        
        private void loadSkillLevels(GameObject parent)
        {   // parent - skilltree
            foreach (Transform child in parent.transform) // skill branches
            {
                foreach (Transform childskill in child.transform) //skills
                {
                    getLevelCount(childskill);
                }
            }        
        }
        
        private void getLevelCount(Transform _skill)
        {
            string _sName = _skill.name;
            A_Skill skill = skillTree.Find(x => x.skillName.Equals(_sName));

            Text t = _skill.GetComponentInChildren<Text>();            
            if (t != null)
            {
                t.text = skill.skillLevel + "/" + skill.skillMaxLevel;
                data.Find(x => x.skillName == _sName).skillCurentLevel = skill.skillLevel; // 0 is first level 
            }
        }

        //CHANGE SKILL LEVEL
        public void skillLevelUp(GameObject _skill)
        {
            if(HeroController.mainHero.skillPoints > 0)
            {
                string _sName = _skill.name;
                A_Skill _s = skillTree.Find(x => x.skillName == _sName);
                // skills are default level 1 
                if ( (_s.skillLevel + 1 <= _s.skillMaxLevel) || (!_s.isLearned && _s.skillMaxLevel == 1))
                {
                    string _availability = HeroSkillsController.getSkillAvailability(_s);

                    if (_availability.Equals("Available"))
                    {                                  
                        HeroSkillsController.setSkillAsLearned(_s);
                        HeroSkillsController.getNewAvailableSKills(skillTree, _sName);                        
                        --HeroController.mainHero.skillPoints;
                        visualValuesUpdated = false;
                    }
                    else if (_availability.Equals("Learned"))
                    {
                        ++_s.skillLevel;
                        refreshSkill(_skill, _sName, _s);
                        --HeroController.mainHero.skillPoints;
                        visualValuesUpdated = false;
                    }                  
                }
            }
        }

        public void skillLevelDown(GameObject _skill)
        {
            string _sName = _skill.name;
            A_Skill _s = skillTree.Find(x => x.skillName == _sName);
            if (_s.skillLevel - 1 >= 0)
            {
                if (_s.skillLevel - 1 >= 1)
                {
                    --_s.skillLevel;
                    refreshSkill(_skill, _sName, _s);
                    ++HeroController.mainHero.skillPoints;
                    visualValuesUpdated = false;
                }
                else if (_s.skillLevel - 1 == 0 && !_s.skillName.Equals("Rearm")) // Rearm is starting point for skills learning
                {                   
                    HeroSkillsController.setSkillAsNotLearned(_s);                    
                    HeroSkillsController.cascadeSkillRemoval(skillTree, _s);
                    loadSkillLevels(skillTreeParent); // Need to refresh all skills
                    visualValuesUpdated = false;
                }
            }

        }

        private void refreshSkill(GameObject _skill, string _sName, A_Skill _s)
        {
            Text t = _skill.GetComponentInChildren<Text>();                                         
            t.text = _s.skillLevel + "/" + _s.skillMaxLevel;
            loadSkillData(_skill);
        }

        //get heroskill levels
        void getHeroLevels(Transform _skill) // + skills level list
        { }
    }
}