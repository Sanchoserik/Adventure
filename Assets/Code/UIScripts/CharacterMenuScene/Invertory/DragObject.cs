using Assets.Code.Items;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene.Invertory
{
    public class DragObject : MonoBehaviour
    {        
        public A_Item item;
        public string text;
        public Image itemSprite;
     
        public void setSprite(Image newImage)
        {
            itemSprite = gameObject.GetComponent<Image>();
            itemSprite.sprite = newImage.sprite;
        }

        public void setText(Text newText)
        {
           // text = newText.text;
        }

        public void setItem(A_Item newItem)
        {
            item = newItem;
        }

        //for items
        public void quickAccesItemsPanelHandler(Transform dragObject, GameObject dragObjectParent, Vector3 mousePosition, GameObject qaPanel)
        {
            //1. move item to another QA slot
            //2. swap items in QA slots
            //3. drop item from QA panel
            int indexOfActiveSlot = 0;
            GameObject activeSlot = getActiveQASlot(qaPanel, mousePosition, out indexOfActiveSlot);
            if (activeSlot != null)
            {
                if (checkSlotForEmptyness(activeSlot)) // if active slot is filled then swap items
                {
                    swapItemsInSlots(activeSlot, dragObjectParent, indexOfActiveSlot, qaPanel);
                }
                else // else move item to empty slot
                {
                    removeItemFromPanel(qaPanel);
                    setItemToSlot(indexOfActiveSlot, activeSlot);
                }
            }
            else
            {
                dropItemFromSlot(dragObject, item);
            }
        }

        public void inventoryPanelItemsHandler(Transform dragObject, Vector3 mousePosition, GameObject qaPanel)
        {
            //1. set item to empty QA slot or Replace filled QA slot
            //get slot we drag into and its index
            int indexOfActiveSlot = 0;
            GameObject activeSlot = getActiveQASlot(qaPanel, mousePosition,out indexOfActiveSlot);
            if (activeSlot != null)
            {
                removeItemFromPanel(qaPanel);
                setItemToSlot(indexOfActiveSlot,activeSlot);
            }
        }

        private GameObject getActiveQASlot(GameObject qaPanel, Vector3 mousePosition,out int index)
        {
            index = 0;
            foreach (Transform slot in qaPanel.transform)
            {
                RectTransform slotRect = slot.transform as RectTransform;
                if (RectTransformUtility.RectangleContainsScreenPoint(slotRect, Input.mousePosition))
                {
                    return slot.gameObject;
                
                }
                ++index;
            }
            return null; // 
        }

        private void setItemToSlot(int indexOfActiveSlot, GameObject activeSlot)
        {
            InventorySystem invSystem = HeroController.mainHero.inventorySystem;
            invSystem.quickAccesItemStorage[indexOfActiveSlot] = item;

            activeSlot.transform.GetChild(0).gameObject.GetComponent<Image>().enabled = true;
            activeSlot.transform.GetChild(0).GetComponent<Image>().sprite = itemSprite.sprite;
           
            activeSlot.GetComponent<UIItem>().item = item;
        }

        private void swapItemsInSlots(GameObject activeSlot, GameObject parentSlot, int indexOfActiveSlot, GameObject qaPanel)
        {
            int indexOfParentSlot = 0;           
            foreach (Transform slot in qaPanel.transform)
            {
               if(slot.GetComponent<UIItem>().item != null)
                if (parentSlot.GetComponent<UIItem>().item.GetType().Name.Equals(slot.GetComponent<UIItem>().item.GetType().Name))
                {
                    break;
                }
                indexOfParentSlot++;
            }

            A_Item tempItem = activeSlot.GetComponent<UIItem>().item;
            Sprite tempSprite = activeSlot.transform.GetChild(0).GetComponent<Image>().sprite;
           
            setItemToSlot(indexOfActiveSlot, activeSlot);

            item = tempItem;
            itemSprite.sprite = tempSprite;

            setItemToSlot(indexOfParentSlot, parentSlot);

            InventorySystem inv = HeroController.mainHero.inventorySystem;
        }

        private void removeItemFromPanel(GameObject qaPanel)
        {
            int removeIndex = 0;
            foreach (Transform qaSlot in qaPanel.transform)
            {
                if(qaSlot.GetComponent<UIItem>().item != null)
                    if (qaSlot.GetComponent<UIItem>().item.GetType().Name.Equals(item.GetType().Name))
                    {
                        qaSlot.GetChild(0).gameObject.GetComponent<Image>().enabled = false;
                        qaSlot.GetChild(1).gameObject.GetComponent<Text>().enabled = false;
                        qaSlot.GetComponent<UIItem>().item = null;

                        InventorySystem invSystem = HeroController.mainHero.inventorySystem;
                        invSystem.quickAccesItemStorage[removeIndex] = null;
                        break;
                    }
                ++removeIndex;
                
            }
        }

        private bool checkQuickAccesItems(A_Item item)
        {
            InventorySystem invSystem = HeroController.mainHero.inventorySystem;
            if (invSystem.quickAccesItemStorage.Contains(item))
                return true;
            else
                return false;
        }

        private bool checkSlotForEmptyness(GameObject activeSlot)
        {
            A_Item item = activeSlot.GetComponent<UIItem>().item;
            if (item != null)
                return true;
            else
                return false;
        }

        public void dropItemFromSlot(Transform slot, A_Item slotItem)
        {        
            InventorySystem invSystem = HeroController.mainHero.inventorySystem;
            int removeIndex = invSystem.quickAccesItemStorage.IndexOf(slotItem);
            invSystem.quickAccesItemStorage[removeIndex] = null;

            slot.GetComponent<Image>().enabled = false;
            slot.parent.GetComponent<UIItem>().item = null;                      
        }
        //for talismans
        public void quickAccesTalismansPanelHandler(Transform dragObject, GameObject dragObjectParent)
        {

        }

        public void inventoryPanelTalismansHandler(Transform dragObject, GameObject dragObjectParent)
        {

        }



    }


}

//public void setItemToSlotandRemove(Transform slot, int slotIndex, Transform dragObjectParentSlot)
//{
//    if (checkQuickAccesItems(item)) // if quickAccesPanel already has this type of item
//    {
//        int removeSlot;

//        foreach (Transform qaSlot in slot.parent.transform)
//        {
//            A_Item qaItem = qaSlot.GetComponent<UIItem>().item;

//            if (qaItem != null)
//                if (qaItem.Equals(item))
//                {
//                    removeSlot = getSlotIndex(item);

//                    removeItemFromQuickAcces(removeSlot);
//                    qaSlot.GetComponent<UIItem>().item = null;
//                    qaSlot.GetChild(0).GetComponent<Image>().sprite = null;
//                    qaSlot.GetChild(0).GetComponent<Image>().enabled = false;
//                }
//        }
//    }

//    Transform component = slot.transform.GetChild(0);
//    Image slotSprite = component.GetComponent<Image>();
//    slotSprite.sprite = itemSprite.sprite;
//    setItemToQuickAcces(slotIndex);
//    UIItem uiItem = slot.GetComponent<UIItem>();
//    uiItem.item = item;
//    slotSprite.enabled = true;

//}

//public void swapItemsFromQAPanel(Transform toSlot, int toslotIndex, Transform fromSlot)
//{
//    int fromSlotIndex;

//    foreach (Transform qaSlot in toSlot.parent.transform)
//    {
//        A_Item qaItem = qaSlot.GetComponent<UIItem>().item;

//        if (qaItem != null)
//            if (qaItem.Equals(item))
//            {
//                fromSlotIndex = getSlotIndex(item);

//                fromSlot.GetChild(0).GetComponent<Image>().sprite = qaSlot.GetChild(0).GetComponent<Image>().sprite;
//                fromSlot.GetComponent<UIItem>().item = qaSlot.GetComponent<UIItem>().item;
//                swapItemsInQuickAcces(fromSlotIndex, toslotIndex);

//                toSlot.GetChild(0).GetComponent<Image>().sprite = itemSprite.sprite;
//                toSlot.GetComponent<UIItem>().item = item;
//                toSlot.GetChild(0).GetComponent<Image>().enabled = true;
//                break;
//            }
//    }

//}
