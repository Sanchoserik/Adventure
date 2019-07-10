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
            if (!gameObject.transform.parent.parent.name.Equals("QuickAccesPanel"))
            {            
                foreach (Transform slot in quickAccesPanel.transform)
                {
                    RectTransform slotRect = slot.transform as RectTransform;

                    if (RectTransformUtility.RectangleContainsScreenPoint(slotRect, Input.mousePosition))
                    {
                        DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();
                        dragObject.setItemToSlot(slot, slotIndex);
                        break;
                    }
                    ++slotIndex;
                }
            }
            else
            {
                bool dropFlag = false;
                bool moveFlag = false;

                foreach (Transform slot in quickAccesPanel.transform)
                {
                    RectTransform slotRect = slot.transform as RectTransform;

                    if (RectTransformUtility.RectangleContainsScreenPoint(slotRect, Input.mousePosition))
                    {
                        dropFlag = false;
                        moveFlag = true;
                        break;
                    }
                    else
                    {
                        dropFlag = true;
                        moveFlag = false;                          
                    }
                    ++slotIndex;
                }
                if(dropFlag)
                {
                    DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();
                    dragObject.dropItemFromSlot(gameObject.transform);       
                }
                if (moveFlag)
                {
                    int xx = 15;
                }
            }

            dragObjectTransform.gameObject.SetActive(false);

        }
    }
}
