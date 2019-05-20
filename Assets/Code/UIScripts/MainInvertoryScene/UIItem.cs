using Assets.Code.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Code.UIScripts.MainInvertoryScene
{
    public class UIItem : MonoBehaviour, IPointerClickHandler, IPointerExitHandler, IPointerEnterHandler
    {
        public A_Item item;
        private ToolTip tooltip;

        private void Awake()
        {     
           tooltip = GameObject.Find("InvHolder").transform.Find("ToolTip").GetComponent<ToolTip>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
           
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            tooltip.gameObject.SetActive(false);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            tooltip.generateItemTooltip("itemname");
        }
    }
}
