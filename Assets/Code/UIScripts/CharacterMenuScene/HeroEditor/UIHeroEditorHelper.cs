using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Code.UIScripts.CharacterMenuScene.HeroEditor
{
    public class UIHeroEditorHelper : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
    {

        private HeroEditorToolTip toolTip;

        private void Awake()
        {
            toolTip = GameObject.Find("ToolTipHolder").transform.Find("HeroEditiorHelpToolTip").GetComponent<HeroEditorToolTip>();
        }


        public void OnPointerExit(PointerEventData eventData)
        {
            throw new NotImplementedException();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            throw new NotImplementedException();
        }

       
    }
}
