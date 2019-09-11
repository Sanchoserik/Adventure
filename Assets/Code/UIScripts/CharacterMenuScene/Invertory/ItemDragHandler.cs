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

            dragObjectParentSlot = gameObject.transform.parent.gameObject;
            dragObject.setItem(gameObject.GetComponentInParent<UIItem>().item);
            dragObject.setSprite(gameObject.GetComponent<Image>());
            dragObjectTransform.transform.position = Input.mousePosition;            
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();
            if (dragObject.item.category.Equals("Talismans")) // for talismans
            {
                if (dragObjectParentSlot.name.Equals("QuickAccesPanel"))
                    dragObject.quickAccesTalismansPanelHandler(transform, dragObjectParentSlot);
                else
                    dragObject.inventoryPanelTalismansHandler(transform, dragObjectParentSlot);
            }
            else
            {
                if (dragObjectParentSlot.transform.parent.name.Equals("QuickAccesPanel")) // for all other items
                    dragObject.quickAccesItemsPanelHandler(transform, dragObjectParentSlot);
                else
                    dragObject.inventoryPanelItemsHandler(transform, Input.mousePosition, quickAccesPanel);
            }

            dragObjectTransform.gameObject.SetActive(false);
        }
    }
}

//public void OnEndDrag(PointerEventData eventData)
//{
//    string parentName = gameObject.transform.parent.parent.name;
//    DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();

//    if (dragObject.item.category.Equals("Talismans")) //for talismans
//    {


//    }
//    else //for items
//    {
//        if (parentName.Equals("QuickAccesPanel"))
//        {
//            //if action from quick acces panel
//            foreach (Transform slot in quickAccesPanel.transform)
//            {
//                RectTransform slotRect = slot.transform as RectTransform;

//                if (RectTransformUtility.RectangleContainsScreenPoint(slotRect, Input.mousePosition))
//                {
//                    //move or swap item to slot
//                    dragItemSetToSlot(dragObject);
//                    break;
//                }
//                else
//                {
//                    //drop item from slot                           
//                    dragObject.dropItemFromSlot(gameObject.transform, gameObject.transform.parent.GetComponent<UIItem>());
//                    break;
//                }
//            }

//        }
//        else //for items
//        {
//            //if action from inventory
//            dragItemSetToSlot(dragObject);
//        }

//        dragObjectTransform.gameObject.SetActive(false);
//    }



//}

//private void dragItemSetToSlot(DragObject dragObject)
//{
//    int slotIndex = 0;

//    List<A_Item> items = new List<A_Item>();
//    foreach (Transform slot in quickAccesPanel.transform)
//    {
//        items.Add(slot.GetComponent<UIItem>().item);
//    }

//    foreach (Transform slot in quickAccesPanel.transform)
//    {              
//        RectTransform slotRect = slot.transform as RectTransform;
//        if (RectTransformUtility.RectangleContainsScreenPoint(slotRect, Input.mousePosition))
//        {
//            if (gameObject.transform.parent.parent.name.Equals("QuickAccesPanel"))
//                dragObject.swapItemsFromQAPanel(slot, slotIndex, dragObjectParentSlot.transform);                
//            else                       
//                dragObject.setItemToSlotandRemove(slot, slotIndex, dragObjectParentSlot.transform);

//            break;
//        }
//        ++slotIndex;
//    }
//}
