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

        private GameObject dragObjectParentSlot;

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
            dragObjectParentSlot = gameObject.transform.parent.gameObject;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            bool setToEmptyFromInv;
            bool moveToEmptyFromPanel;
            bool swapFromInv; // for talismans only
            bool swapFromPanel;
            bool dropFromPanel;

            string parentName = gameObject.transform.parent.parent.name;
            DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();

            if (dragObject.item.category.Equals("Talismans"))
            {


            }
            else
            {
                if (parentName.Equals("QuickAccesPanel")) // fro talismans
                {
                    //if action from quick acces panel


                }
                else //for items
                {
                    //if action from inventory
                    int slotIndex = 0;
                    foreach (Transform slot in quickAccesPanel.transform)
                    {
                        RectTransform slotRect = slot.transform as RectTransform;
                        if (RectTransformUtility.RectangleContainsScreenPoint(slotRect, Input.mousePosition))
                        {                            
                            dragObject.setItemToSlot(slot, slotIndex);
                            break;
                        }
                        ++slotIndex;
                    }
                }

            }

          
            ////set item
            //if (!gameObject.transform.parent.parent.name.Equals("QuickAccesPanel"))
            //{
            //    int slotIndex = 0;
            //    foreach (Transform slot in quickAccesPanel.transform)
            //    {
            //        RectTransform slotRect = slot.transform as RectTransform;

            //        if (RectTransformUtility.RectangleContainsScreenPoint(slotRect, Input.mousePosition))
            //        {
            //            DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();
            //            dragObject.setItemToSlot(slot, slotIndex);
            //            break;
            //        }
            //        ++slotIndex;
            //    }
            //}
            //else
            //{
            //    bool dropFlag = false;
            //    bool moveFlag = false;
            //    bool swapFlag = false;

            //    foreach (Transform slot in quickAccesPanel.transform)
            //    {
            //        RectTransform slotRect = slot.transform as RectTransform;

            //        if (RectTransformUtility.RectangleContainsScreenPoint(slotRect, Input.mousePosition))
            //        {
            //            dropFlag = false;
            //            //move or swap
            //            moveFlag = true;
            //            break;
            //        }
            //        else
            //        {
            //            dropFlag = true;
            //            moveFlag = false;                          
            //        }                   
            //    }

            //    //
            //    if (dropFlag)
            //    {
            //        DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();                    
            //        dragObject.dropItemFromSlot(gameObject.transform, gameObject.transform.parent.GetComponent<UIItem>());       
            //    }
            //    else if (moveFlag)
            //    {
                    
            //        int slotIndex = 0;
            //        foreach (Transform slot in quickAccesPanel.transform)
            //        {
            //            RectTransform slotRect = slot.transform as RectTransform;

            //            if (RectTransformUtility.RectangleContainsScreenPoint(slotRect, Input.mousePosition))
            //            {
            //                DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();
            //                dragObject.setItemToSlot(slot, slotIndex);
            //                break;
            //            }
            //            ++slotIndex;
            //        }
            //    }
            //    else if (swapFlag)
            //    {

            //    }
            //}

            dragObjectTransform.gameObject.SetActive(false);
        }

    }
}
