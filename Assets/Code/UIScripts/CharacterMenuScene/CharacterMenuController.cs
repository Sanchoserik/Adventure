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
        private Text skillPoints;

        private void Start()
        {
            getSkillPoints();
        }

        public void getSkillPoints()
        {
            skillPoints = GameObject.Find("SkillPointsVal").GetComponent<Text>();
            skillPoints.text = HeroController.mainHero.freeSkillPoints.ToString();
        }
    }
}
