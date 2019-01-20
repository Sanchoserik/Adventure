using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Code.SystemScripts
{
    public class LocaliseComponents : MonoBehaviour
    {
        public void localiseScene(LocalisationData _data)
        {
          Scene scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
          Dictionary<string, string> sceneValues = _data.locValues[scene.name];

            //find gameObjects in scene by keys then set Text from localisation file
            foreach (string key in sceneValues.Keys)
            {
                GameObject obj = GameObject.Find(key);
                
                Text _t = obj.GetComponent<Text>();
                _t.text = sceneValues[key];
            }
           
        }
    }
}
