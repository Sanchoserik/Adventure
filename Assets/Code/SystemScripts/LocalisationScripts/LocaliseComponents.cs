using Assets.Code.SystemScripts.LocalisationScripts;
using Assets.Code.SystemScripts.LocalisationScripts.LocalisationDataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Code.SystemScripts
{
    public class LocaliseComponents
    {
        public void localiseScene(InterfaceLocalisationData _data)
        {        
          Scene scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
          Dictionary<string, string> sceneValues = _data.locValues[scene.name];

            //find gameObjects in scene by keys then set Text from localisation file
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

        public void localiseItems(List<ItemsLocalisationData> _data)
        {

        }

    }
}
