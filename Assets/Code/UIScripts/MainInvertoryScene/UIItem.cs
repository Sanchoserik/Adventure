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
        private ToolTip toolTip;

        private void Awake()
        {     
           toolTip = GameObject.Find("InvHolder").transform.Find("ToolTip").GetComponent<ToolTip>();
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

        //TO DO Item context menu
        public void OnPointerClick(PointerEventData eventData)
        {

        }

    }
}
