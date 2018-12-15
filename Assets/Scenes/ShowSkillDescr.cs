using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class ShowSkillDescr : MonoBehaviour {
    //text UI objects
    public Text sName;
    public Text sDescr;
    public Text sLevelDescr;

    //concrette skill loading
    bool loaded = false; // is skill loaded?]
    bool selected = false;
    string newSKill;
    List<skillData> data; // all skills data from loader xml file

    //branch switcher
    bool tactician = true; // first to load
    bool warrior = false;
    bool assassin = false;
    bool bruiser = false;

    // Use this for initialization
    void Start () {
        GameObject loader = GameObject.Find("SkillLoader");
        Loader _l = loader.GetComponent<Loader>();
        data = _l.data;   // get data list from loader     
    }
	   
	// Update is called once per frame
	void Update () {
        //load skills once
        if (!loaded && selected) // if skill not loaded load!
        {
            loadSkillData(newSKill);
            loaded = true; //set skillloaded to true
            selected = false;
        }
	}

    //button trigger on skill icon
    public void changeSkill(string _name)
    {
        selected = true;
        loaded = false;       
        newSKill = _name;
    }

    // 
    void loadSkillData(string _name)
    {
        sLevelDescr.text = ""; // cleat level data
        skillData _data = data.Find(x => x.name == _name);

        sName.text = _data.locName;
        sDescr.text = _data.sDescr;

        int sLevelIter = 0;
        foreach (string s in _data.locDescr) //simple get level data
        {
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
            int x = 10;
            string final = s;
            foreach (string _val in values)
            {
                if (_data.vValues[sLevelIter].ContainsKey(_val))
                    final = final.Replace("$" + _val + "$", _data.vValues[sLevelIter][_val]);
                else Debug.Log("not a key " + _val);
            }
            sLevelDescr.text += final + "\n";
            ++sLevelIter;
        }
    }
   
    //change skillbranch 
    public void changeSkillBranch(skillButtonChangerData data)
    {


        switch (data._name)
        {
            case "T": //tactician
                {
                    data._panel.SetActive(true);
                    GameObject _w = GameObject.Find("WarriorSkills"); if (_w != null)  _w.SetActive(false);
                    GameObject _a = GameObject.Find("AssassinSkills"); if (_a != null) _a.SetActive(false);
                    GameObject _b = GameObject.Find("BruiserSkills"); if (_b != null)  _b.SetActive(false);
                    break;
                }
            case "W": //warrior
                {
                    data._panel.SetActive(true);
                    GameObject _t = GameObject.Find("TacticianSkills"); if(_t != null) _t.SetActive(false);
                    GameObject _a = GameObject.Find("AssassinSkills"); if (_a != null) _a.SetActive(false);
                    GameObject _b = GameObject.Find("BruiserSkills"); if (_b != null)  _b.SetActive(false);
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
}
