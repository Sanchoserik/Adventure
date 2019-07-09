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

        public void setSprite(Image newImage)
        {
            Image image = gameObject.GetComponent<Image>();
            image.sprite = newImage.sprite;
        }
    }

}
