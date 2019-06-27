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
        public static bool loadHero = false;
        public static C_Hero mainHero = new C_Hero();
        public GameObject heroEditorController;
        private List<SkillsData> skillsData;

        private void Start()
        {
            skillsData = ResourcesManager.skillsData;

            if (loadHero)
            {
                loadHeroFromSaveFile();
            }
            else
            {
                if(mainHero.heroSkills == null)
                mainHero.heroSkills = new HeroSkillsController(skillsData);
                mainHero.freeSkillPoints = 20; // TEMP
            }

            heroEditorController.SetActive(true);
        }

        private void loadHeroFromSaveFile()
        {

        }


    }
}
