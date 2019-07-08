using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene.Invertory
{
    public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
    {       
        public Transform dragDropObject;
        public GameObject quickAccesPanel;

        public void Awake()
        {
            dragDropObject = GameObject.Find("InvertoryPanel").transform.Find("DragDropObject");
        }

        public void OnDrag(PointerEventData eventData)
        {
            dragDropObject.gameObject.SetActive(true);
            if (dragDropObject.GetComponent<Image>().sprite == null)
            {
                dragDropObject.GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
            }
            dragDropObject.transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {          

            dragDropObject.gameObject.SetActive(false);
        }
    }
}
