using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene.HeroEditor
{
    public class HeroEditorController : MonoBehaviour
    {
        public GameObject LeftStatusPanel;
        public GameObject MainStatusPanel;

        public static Dictionary<string, Text> heroStatusValues;

        public void Start()
        {
            fillHeroStatusValues();  
            displayHeroStatus();   
        }

        public void Update()
        {
            
        }

        private void fillHeroStatusValues()
        {
            if (heroStatusValues != null)
            {
                foreach (Transform t in LeftStatusPanel.transform)
                {
                    if (t.tag.Equals("Value"))
                        heroStatusValues.Add(t.name, t.GetComponent<Text>());
                }
                foreach (Transform t in MainStatusPanel.transform)
                {
                    if (t.tag.Equals("Value"))
                        heroStatusValues.Add(t.name, t.GetComponent<Text>());
                }
            }
        }

        public void displayHeroStatus()
        {
            
        }

        public void updateLeftStatusPanel()
        {

        }

        public void updateMainStatusPanel()
        {

        }
        
    }

}
