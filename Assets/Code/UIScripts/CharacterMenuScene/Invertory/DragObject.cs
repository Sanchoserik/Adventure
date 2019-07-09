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
        public  A_Item item;
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
            Transform component = slot.transform.GetChild(0);
            Image slotSprite = component.GetComponent<Image>();            
            slotSprite.sprite = itemSprite.sprite;
            setItemToQuickAcces(slotIndex);
            
            UIItem uiItem = slot.GetComponent<UIItem>();
            uiItem.item = item;
            slotSprite.enabled = true;
        }

        private void setItemToQuickAcces(int slotIndex)
        {
            InventorySystem invSystem = HeroController.mainHero.inventorySystem;
            invSystem.quickAccesItemStorage[slotIndex] = item;
        }
    }

}
