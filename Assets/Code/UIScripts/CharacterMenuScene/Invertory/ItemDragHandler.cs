using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Code.UIScripts.CharacterMenuScene.Invertory
{
    public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
    {
        public GameObject item;

        public void Awake()
        {
            item = GameObject.Find("DragDropObject");
        }

        public void OnDrag(PointerEventData eventData)
        {
           
            item.transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            item.transform.localPosition = Vector3.zero;
        }
    }
}
