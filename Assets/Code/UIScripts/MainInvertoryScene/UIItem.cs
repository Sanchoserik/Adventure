using Assets.Code.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Code.UIScripts.MainInvertoryScene
{
    public class UIItem : MonoBehaviour, IPointerClickHandler, IPointerExitHandler
    {
        public A_Item item;
        private ToolTip tooltip;

        private void Awake()
        {
            GameObject x = GameObject.Find("ToolTip2");

            int xx = 20;
            //tooltip = GameObject.Find("ItemToolTip").GetComponent<ToolTip>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            tooltip.generateItemTooltip("itemname");
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            tooltip.gameObject.SetActive(false);
        }
    }
}
