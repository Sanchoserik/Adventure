using Assets.Code.SystemScripts.LocalisationScripts;
using Assets.Code.SystemScripts.LocalisationScripts.LocalisationDataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Code.SystemScripts.LocalisationScripts
{
    public class LocaliseComponents
    {
        public void localiseScene(InterfaceLocalisationData _data)
        {        
          Scene scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
          Dictionary<string, string> sceneValues = _data.localisationValues[scene.name];

            //find gameObjects in scene by keys then set Text from localisation file
            //but this method can't find inactive gameObjects... 
            foreach (string key in sceneValues.Keys)
            {
                GameObject obj = GameObject.Find(key);

                if (obj != null)
                {
                    Text _t = obj.GetComponent<Text>();
                    _t.text = sceneValues[key];
                }
            }
        }
    }
}
