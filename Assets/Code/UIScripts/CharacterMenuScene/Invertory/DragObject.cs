using Assets.Code.Items;
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
        A_Item item;
        Image itemSprite;

        public void setSprite(Image newImage)
        {
            itemSprite = gameObject.GetComponent<Image>();
            itemSprite.sprite = newImage.sprite;
        }

        public void setItemToSlot(Transform slot)
        {
            Transform component = slot.transform.GetChild(0);
            Image slotSprite = component.GetComponent<Image>();            
            slotSprite.sprite = itemSprite.sprite;
            slotSprite.enabled = true;
        }
    }

}
