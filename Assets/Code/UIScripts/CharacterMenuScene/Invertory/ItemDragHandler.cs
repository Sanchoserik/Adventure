using Assets.Code.Items;
using Assets.PlayerController;
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
            dragObject.setText(gameObject.transform.parent.GetChild(1).GetComponent<Text>());
            dragObjectTransform.transform.position = Input.mousePosition;            
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            DragObject dragObject = dragObjectTransform.GetComponent<DragObject>();
            if (dragObject.item.category.Equals("Talismans")) // for talismans
            {
                if (dragObjectParentSlot.transform.parent.name.Equals("QuickAccesPanel")) // for all other items
                    dragObject.quickAccesItemsPanelHandler(transform, dragObjectParentSlot, Input.mousePosition, quickAccesPanel, HeroController.mainHero.inventorySystem.inUseTalismansStorage);
                else
                    dragObject.inventoryPanelItemsHandler(transform, Input.mousePosition, quickAccesPanel, HeroController.mainHero.inventorySystem.inUseTalismansStorage);
            }
            else
            {
                if (dragObjectParentSlot.transform.parent.name.Equals("QuickAccesPanel")) // for all other items
                    dragObject.quickAccesItemsPanelHandler(transform, dragObjectParentSlot, Input.mousePosition, quickAccesPanel, HeroController.mainHero.inventorySystem.quickAccesItemStorage);
                else
                    dragObject.inventoryPanelItemsHandler(transform, Input.mousePosition, quickAccesPanel, HeroController.mainHero.inventorySystem.quickAccesItemStorage);
            }

            dragObjectTransform.gameObject.SetActive(false);
        }
    }
}
