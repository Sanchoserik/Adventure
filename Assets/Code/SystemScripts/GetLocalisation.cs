using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code.SystemScripts
{
    class GetLocalisation : MonoBehaviour
    {
        private void Start()
        {
                   
            LocaliseComponents lsc = new LocaliseComponents();
            lsc.localiseScene(LoadLocalisation.localisationData); // localise scene from ldata       
        }
    }
}
