using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene
{
    public class CharacterMenuController : MonoBehaviour
    {
        public GameObject AdvancedStatusPanel;
  
        private void Start()
        {
            
        }

        public void showSkillTreeButton()
        {
            foreach (Transform panel in AdvancedStatusPanel.transform)
            {
                panel.gameObject.SetActive(false);
            }
            AdvancedStatusPanel.transform.Find("SkillTreePanel").gameObject.SetActive(true);
        }

        public void showInvertoryButton()
        {
            foreach (Transform panel in AdvancedStatusPanel.transform)
            {
                panel.gameObject.SetActive(false);
            }
            AdvancedStatusPanel.transform.Find("InvertoryPanel").gameObject.SetActive(true);
        }

        public void showHeroStatusButton()
        {
            foreach (Transform panel in AdvancedStatusPanel.transform)
            {
                panel.gameObject.SetActive(false);
            }
            AdvancedStatusPanel.transform.Find("StatusPanel").gameObject.SetActive(true);
        }
    }
}
