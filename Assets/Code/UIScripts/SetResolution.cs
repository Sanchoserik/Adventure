using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolution : MonoBehaviour {

    public void setResolution1920x1080()
    {
        Screen.SetResolution(1920, 1080, true);
    }

    public void setResolution1366x768()
    {
        Screen.SetResolution(1366, 768, true);
    }

    public void setResolution1024x768()
    {
        Screen.SetResolution(1024, 768, true);
    }
}
