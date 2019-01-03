using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.SkillTreeScene
{
    public class ShowSkillDescr : MonoBehaviour
    {
        //
        public GameObject skillTreeParent;
        //text UI objects
        public Text sName; // for skill name
        public Text sDescr; //skill description
        public Text sLevelDescr;// levels description
        public Text sAPCost;
        public Text sEneCost;
        public Text sTime; //duration
        public Text sTargets;

        //concrette skill loading
        bool loaded = false; // is skill loaded?]
        bool selected = false;
        GameObject newSKill;
        List<skillData> data; // all skills data from loader xml file

        void Start()
        {
            GameObject loader = GameObject.Find("SkillLoader");
            Loader _l = loader.GetComponent<Loader>();
            data = _l.data;   // get data list from loader 
            loadSkillLevels(skillTreeParent); // load skill levels
        }

        void Update()
        {
            //load skills once
            if (!loaded && selected) // if skill not loaded load!
            {
                loadSkillData(newSKill);
                loaded = true; //set skillloaded to true
                selected = false;
            }
        }
        
        //CHANGE SKILL
        public void changeSkill(GameObject _newSkill)
        {
            selected = true;
            loaded = false;
            newSKill = _newSkill;
        }

        //CHANGE SKILL LEVEL
        public void skillLevelUp(GameObject _skill)
        {
            string _sName = _skill.name;
            Text t = _skill.GetComponentInChildren<Text>();
            skillData _d = data.Find(x => x.name == _sName);
            //
            if (t != null)
            {
                if ( _d.currLevel + 1 <= _d.levels )
                {
                    ++_d.currLevel;
                    t.text = _d.currLevel + "/" + _d.levels;
                    loadSkillData(_skill);
                }
            }
        }
        public void skillLevelDown(GameObject _skill)
        {
            string _sName = _skill.name;
            Text t = _skill.GetComponentInChildren<Text>();
            skillData _d = data.Find(x => x.name == _sName);
            //
            if (t != null)
            {
                if (_d.currLevel - 1 > 0)
                {
                    --_d.currLevel;
                    t.text = _d.currLevel + "/" + _d.levels;
                    loadSkillData(_skill);
                }
            }
        }

        //LOAD LEVEL DATA
        void loadSkillData(GameObject _skill) 
        {
            sLevelDescr.text = ""; // clear level data   
            sTime.text = ""; // clear skill Duration
            skillData _data = data.Find(x => x.name == _skill.name);

            sName.text = _data.locName;
            sDescr.text = _data.sDescr;

            string s = _data.locDescr[_data.currLevel-1];

                //get values count
                int _valCount = 0;
                for (int i = 0; i < s.Length; ++i)
                    if (s.Substring(i, 1).Equals("$"))
                        ++_valCount;
                //
                _valCount /= 2; //divide 

                List<string> values = new List<string>(); // xml values here
                string _substr = s; // temp full string
                for (int i = 0; i < _substr.Length; ++i)
                {
                    string _subChar = _substr.Substring(i, 1); //next char
                    if (_subChar.Equals("$"))
                    {
                        string _val = _substr.Substring(i + 1, _substr.Length - i - 1); // from $val to the end of curr string
                                                                                        //
                        for (int j = 0; j < _val.Length; ++j)
                        {
                            string _subJ = _val.Substring(j, 1);
                            if (_subJ.Equals("$"))
                            {
                                string newVal = _val.Substring(0, j); // get value name
                                _substr = _val.Substring(j + 1, _val.Length - j - 1); // set new main string from $val$ to the end of curr string 
                                values.Add(newVal); // add value name to list
                                i = -1; // for i++ 

                                break; // end of $val$ go to next $$ 
                            }
                        }

                    }
                }//end bitch
                

                string final = s;
                foreach (string _val in values)
                {
                    if (_data.vValues[_data.currLevel-1].ContainsKey(_val))
                        final = final.Replace("$" + _val + "$", _data.vValues[_data.currLevel-1][_val]);
                    else Debug.Log("not a key " + _val);
                }
                sLevelDescr.text += final + "\n";

            //get ap cost ene costs and Targets
            int _intkey = _data.currLevel; // do not decrease by 1
            string _key = _intkey.ToString();
            if (_data.lcAP.ContainsKey(_intkey)) // key are equal 
            {
                sAPCost.text = _data.lcAP[_data.currLevel];
                sEneCost.text = _data.lcEne[_data.currLevel];
                sTargets.text = _data.locTargets[_data.currLevel-1]; //list
            }
            // get skill duration "Time"
            if (_data.vValues[_data.currLevel - 1].ContainsKey("Time"))
            {
                sTime.text = _data.vValues[_data.currLevel - 1]["Time"];
            }            
        }

        //CHANGE SKILL BRANCH
        public void changeSkillBranch(skillButtonChangerData data)
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
        //load levels text to skillpanels
        void loadSkillLevels(GameObject parent)
        {   // parent - skilltree
            foreach (Transform child in parent.transform) // skill branches
            {
                foreach (Transform childskill in child.transform) //skills
                {
                    getLevelCount(childskill);
                }
            }
            
        }//end fun
        // get levels count
        void getLevelCount(Transform _skill)
        {
            string _sName = _skill.name;
            Text t = _skill.GetComponentInChildren<Text>();
            // 1 levels
            if (t != null)
            {
                t.text = "1/" + data.Find(x => x.name == _sName).levels.ToString();
                data.Find(x => x.name == _sName).currLevel = 1;// 0 is first level 
            }
        }
        //get heroskill levels
        void getHeroLevels(Transform _skill) // + skills level list
        { }
    }

 
}