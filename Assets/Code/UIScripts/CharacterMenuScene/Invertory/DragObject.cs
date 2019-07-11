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
        public Image itemSprite;
     
        public void setSprite(Image newImage)
        {
            itemSprite = gameObject.GetComponent<Image>();
            itemSprite.sprite = newImage.sprite;
        }

        public void setItem(A_Item newItem)
        {
            item = newItem;
        }

        public void setItemToSlot(Transform slot, int slotIndex)
        {           
            if (checkQuickAccesItems(item)) // if quickAccesPanel already has this type of item
            {
                //and remove item from UI
                foreach (Transform qaSlot in slot.parent.transform)
                {
                    A_Item qaItem = qaSlot.GetComponent<UIItem>().item;

                    if (qaItem != null)
                    if (qaItem.Equals(item))
                    {
                        qaItem = null;
                        qaSlot.GetChild(0).GetComponent<Image>().enabled = false;
                    }
                }
                removeItemFromQuickAcces(slotIndex);
            }
            
            Transform component = slot.transform.GetChild(0);
            Image slotSprite = component.GetComponent<Image>();
            slotSprite.sprite = itemSprite.sprite;
            setItemToQuickAcces(slotIndex);
            UIItem uiItem = slot.GetComponent<UIItem>();
            uiItem.item = item;
            slotSprite.enabled = true;

        }

        private bool checkQuickAccesItems(A_Item item)
        {
            InventorySystem invSystem = HeroController.mainHero.inventorySystem;
            if (invSystem.quickAccesItemStorage.Contains(item))
                return true;
            else
                return false;
        }

        private void setItemToQuickAcces(int slotIndex)
        {
            InventorySystem invSystem = HeroController.mainHero.inventorySystem;
            invSystem.quickAccesItemStorage[slotIndex] = item;         
        }

        private void removeItemFromQuickAcces(int slotIndex)
        {
            InventorySystem invSystem = HeroController.mainHero.inventorySystem;
            invSystem.quickAccesItemStorage[slotIndex] = null;
        }

        public void dropItemFromSlot(Transform slot, UIItem item)
        {        
            InventorySystem invSystem = HeroController.mainHero.inventorySystem;
            int removeIndex = invSystem.quickAccesItemStorage.IndexOf(item.item);
            invSystem.quickAccesItemStorage[removeIndex] = null;

            slot.GetComponent<Image>().enabled = false;
            slot.parent.GetComponent<UIItem>().item = null;

            item = null;
            itemSprite = null;           
        }
    }

}
