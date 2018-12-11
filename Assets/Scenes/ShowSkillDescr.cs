using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSkillDescr : MonoBehaviour {

    List<skillData> data;
    // Use this for initialization
    void Start () {
        GameObject loader = GameObject.Find("SkillLoader");
        Loader _l = loader.GetComponent<Loader>();
        data = _l.data;
        int xx = 20;
    }
	   
	// Update is called once per frame
	void Update () {
		
	}
}
