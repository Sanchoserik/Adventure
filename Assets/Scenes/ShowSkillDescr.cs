using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSkillDescr : MonoBehaviour {

    public Text sName;
    public Text sDescr;
    public Text sLevelDescr;

    bool loaded = false; // is skill loaded?]
    bool selected = false;
    string newSKill;

    List<skillData> data; // all skills data
    // Use this for initialization
    void Start () {
        GameObject loader = GameObject.Find("SkillLoader");
        Loader _l = loader.GetComponent<Loader>();
        data = _l.data;       
    }
	   
	// Update is called once per frame
	void Update () {
        if (!loaded && selected) // if skill not loaded load!
        {
            loadSkillData(newSKill);
            loaded = true; //set skillloaded to true
            selected = false;
        }
	}

    //button trigger
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
        foreach (string s in _data.locDescr) //simple get level data
        {
            sLevelDescr.text += s + "\n";
            //sLevelDescr.text
        }
    }
}
