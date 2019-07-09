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
        public Transform dragObjectTransform;
        public GameObject quickAccesPanel;

        public void Awake()
        {
            dragObjectTransform = GameObject.Find("InvertoryPanel").transform.Find("DragDropObject");
            quickAccesPanel = GameObject.Find("InvertoryPanel").transform.Find("QuickAccesPanel").gameObject;
        }

        public void OnDrag(PointerEventData eventData)
        {
            dragObjectTransform.gameObject.SetActive(true);
            DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();
            dragObject.setItem(gameObject.GetComponentInParent<UIItem>().item);
            dragObject.setSprite(gameObject.GetComponent<Image>());           
            dragObjectTransform.transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            int slotIndex = 0;
            foreach (Transform slot in quickAccesPanel.transform)
            {               
                RectTransform slotRect = slot.transform as RectTransform;
               
                if (RectTransformUtility.RectangleContainsScreenPoint(slotRect, Input.mousePosition))
                {
                    //ON normal drag - from InvertoryPanel to QuickAcesPanel
                    DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();
                    dragObject.setItemToSlot(slot, slotIndex);

                    //ON Special drag - from QuickAccesPanel to QuickAccesPanel and itemDrop
                    break;


                }
                ++slotIndex;
            }

            dragObjectTransform.gameObject.SetActive(false);

        }
    }
}
