﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Code.SystemScripts
{
    public class LocaliseScene : MonoBehaviour
    {
        public void localiseScene(LocalisationData _data)
        {
          Scene scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            Dictionary<string, string> sceneValues = _data.locValues[scene.name];

            foreach (string key in sceneValues.Keys)
            {
              
            }


        }
    }
}
