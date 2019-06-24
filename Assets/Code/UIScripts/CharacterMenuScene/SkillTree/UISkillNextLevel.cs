using Assets.Code.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Code.UIScripts.CharacterMenuScene.SkillTree
{
    public class UISkillNextLevel : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
    {
        public A_Skill skill;
        private SkillToolTip toolTip;

        private void Awake()
        {
            toolTip = GameObject.Find("ToolTipHolder").transform.Find("SkillGeneralToolTip").GetComponent<SkillToolTip>();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            toolTip.setToolTipGeneratedValue(false);
            toolTip.gameObject.SetActive(false);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            toolTip.generateToolTip(skill, "loadNextLevel");
        }


    }
}
