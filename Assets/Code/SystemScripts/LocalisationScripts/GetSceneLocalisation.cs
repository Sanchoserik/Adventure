using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code.SystemScripts.LocalisationScripts
{
    class GetSceneLocalisation : MonoBehaviour
    {
        private void Start()
        {                  
            LocaliseComponents lsc = new LocaliseComponents();
            lsc.localiseScene(LocalisationManager.interfaceLocalisationData);   
        }
    }
}
