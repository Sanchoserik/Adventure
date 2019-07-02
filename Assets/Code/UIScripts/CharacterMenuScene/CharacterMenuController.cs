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
        public GameObject ParentMenu;
       
        private void Start()
        {
            getSkillPoints();
        }

        public void getSkillPoints()
        {
            Text skillPoints;
            skillPoints = GameObject.Find("SkillPointsVal").GetComponent<Text>();
            skillPoints.text = HeroController.mainHero.freeSkillPoints.ToString();
        }

        public void showSkillTreeButton()
        {
            foreach (Transform panel in ParentMenu.transform)
            {
                panel.gameObject.SetActive(false);
            }
            ParentMenu.transform.Find("SkillTreePanel").gameObject.SetActive(true);
        }

        public void showInvertoryButton()
        {

        }
    }
}
