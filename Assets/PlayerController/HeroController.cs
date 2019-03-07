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
        public static List<SkillDataStorage> skillDataStorage;
        public GameObject heroEditorController;

        private void Start()
        {
            skillDataStorage = new List<SkillDataStorage>();
            SkillsLoaderFromXML.LoadXML(skillDataStorage);

            if (loadHero)
            {
                loadHeroFromSaveFile();
            }
            else
            {
                if(mainHero.heroSkills == null)
                mainHero.heroSkills = new HeroSkillsController(skillDataStorage);
            }

            heroEditorController.SetActive(true);
        }

        private void loadHeroFromSaveFile()
        {

        }


    }
}
