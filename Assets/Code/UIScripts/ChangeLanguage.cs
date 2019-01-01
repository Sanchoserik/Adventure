using Assets.Code.SystemScripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour {

    public void changeLang(string lang)
    {
        AppParameters.localisation = lang;
        // perform loc
    }
}
