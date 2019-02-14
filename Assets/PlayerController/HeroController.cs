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

        private void Start()
        {
            if (loadHero)
            {
                loadHeroFromSaveFile(); }
            heroEditorController.SetActive(true);
        }

        private void loadHeroFromSaveFile()
        {

        }


    }
}
