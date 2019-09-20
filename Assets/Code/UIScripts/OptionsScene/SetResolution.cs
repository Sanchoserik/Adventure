using Assets.Code.SystemScripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolution : MonoBehaviour {

    public void setResolution1920x1080()
    {
        Screen.SetResolution(1920, 1080, true);
        AppParameters.resHeight = 1080;
        AppParameters.resHeight = 1920;

    }

    public void setResolution1366x768()
    {
        Screen.SetResolution(1366, 768, true);
        AppParameters.resHeight = 1366;
        AppParameters.resHeight = 768;

    }

    public void setResolution1024x768()
    {
        Screen.SetResolution(1024, 768, true);
        AppParameters.resHeight = 1024;
        AppParameters.resHeight = 768;

    }
}
