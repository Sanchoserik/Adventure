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
            
            if (!gameObject.transform.parent.parent.name.Equals("QuickAccesPanel"))
            {
                int slotIndex = 0;
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
                }
                if(dropFlag)
                {
                    DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();                    
                    dragObject.dropItemFromSlot(gameObject.transform, gameObject.transform.parent.GetComponent<UIItem>());       
                }
                if (moveFlag)
                {
                    
                    int slotIndex = 0;
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
            }

            dragObjectTransform.gameObject.SetActive(false);
        }

    }
}
