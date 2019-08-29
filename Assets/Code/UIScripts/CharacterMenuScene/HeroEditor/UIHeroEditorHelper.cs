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
        public string helperFlag;

        private void Awake()
        {
            toolTip = GameObject.Find("ToolTipHolder").transform.Find("HeroEditiorHelpToolTip").GetComponent<HeroEditorToolTip>();
        }


        public void OnPointerExit(PointerEventData eventData)
        {
            toolTip.setToolTipGeneratedValue(false);
            toolTip.gameObject.SetActive(false);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            toolTip.generateToolTip(helperFlag);
        }

       
    }
}
