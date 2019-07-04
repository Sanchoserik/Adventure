using Assets.Code.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene.Invertory
{
    public class UIItem : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
    {
        public A_Item item;
        private ItemToolTip toolTip;
  
        private void Awake()
        {
            toolTip = GameObject.Find("ToolTipHolder").transform.Find("ItemsGeneralToolTip").GetComponent<ItemToolTip>();          
        }
     
        public void OnPointerExit(PointerEventData eventData)
        {
            toolTip.setToolTipGeneratedValue(false);
            toolTip.gameObject.SetActive(false);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            toolTip.generateItemTooltip(item);
        }


    }
}
