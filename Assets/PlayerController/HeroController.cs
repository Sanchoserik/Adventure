using Assets.Code.SystemScripts;
using Assets.Code.SystemScripts.DataStructures;
using Assets.Code.UIScripts.SkillTreeScene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.PlayerController
{
    class HeroController : MonoBehaviour 
    {
        public static C_Hero mainHero;
        public GameObject OtherControllers;
    
        private void Awake()
        {
            if (mainHero == null) // initialisation for new game
            {
                mainHero = new C_Hero();
                mainHero.heroSkills = new HeroSkillsController(ResourcesManager.skillsData);
                HeroAttributesController.updateAttributes();
            }
            mainHero.freeSkillPoints = 100; // TEMP
            OtherControllers.SetActive(true);
        }



    }
}
