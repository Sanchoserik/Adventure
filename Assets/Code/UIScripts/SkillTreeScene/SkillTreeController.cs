using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.SkillTreeScene
{
    class SkillTreeController : MonoBehaviour
    {
        private bool dataUpdated = false;
        public GameObject skillTreeControllPanel;
        private void Start()
        {
            getVisualValues();
            dataUpdated = true;
        }

        private void Update()
        {
            if (!dataUpdated)
            {
                getVisualValues();
                dataUpdated = true;
            }
        }

        private void getVisualValues()
        {
            foreach (Transform value in skillTreeControllPanel.transform)
            {
                if (value.name.Contains("Val"))
                { updateVisualValues(value); }
            }
        }

        private void updateVisualValues(Transform textValue)
        {
            Text text = textValue.GetComponent<Text>();
         
            switch (textValue.name)
            {
                case "SkillPointsVal": {text.text = HeroController.mainHero.skillPoints.ToString(); break; }
            }
        }
    }
}
