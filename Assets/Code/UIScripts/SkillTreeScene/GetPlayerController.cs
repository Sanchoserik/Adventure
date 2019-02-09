using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Code.UIScripts.SkillTreeScene
{
    class GetPlayerController : MonoBehaviour
    {
        private C_Hero hero;

        private void Start()
        {
            getHeroFromEditor();
            Debug.Log(hero.level);
        }

        private void getHeroFromEditor()
        {
            int xx = 20;
            Scene heroEditor = UnityEngine.SceneManagement.SceneManager.GetSceneByName("");
            int z = 30;

            //for (int i = 0; i < heroEditorRootData.Length; ++i)
            //{
            //    if (heroEditorRootData[i].name.Equals("PlayerController"))
            //    {
            //        PlayerController plC = heroEditorRootData[i].GetComponent<PlayerController>();
            //        hero = plC.hero;
            //    }
            //}
        }
    }
}
