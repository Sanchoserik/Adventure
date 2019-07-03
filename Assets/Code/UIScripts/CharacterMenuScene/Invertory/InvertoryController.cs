using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Assets.PlayerController;
using Assets.Code.Items;
using Assets.Code.Items.Potions;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.UIScripts.MainInvertoryScene
{
    public class InvertoryController : MonoBehaviour
    {
        public GameObject slotPrefab;
        public Transform mainHolder;
        public Sprite[] itemsSpriteSheet;

        InventorySystem invSystem;

        private void Start()
        {
            //TEST
            //1 get inventory
            invSystem = HeroController.mainHero.inventorySystem;
            //TEST FABRIC
            ItemFabric itemFabric = new ItemFabric();
            List<ItemsData> alldata = SystemScripts.ResourcesManager.itemsData;

            invSystem.addItem(itemFabric.createPotionAirUpMix1S(alldata.Find(x => x.potionName.Equals("AirUpMix1S"))));
            invSystem.addItem(itemFabric.createPotionHealP1S(alldata.Find(x => x.potionName.Equals("HealP1S"))));
            invSystem.addItem(itemFabric.createPotionHealP2M(alldata.Find(x => x.potionName.Equals("HealP2M"))));
            invSystem.addItem(itemFabric.createPotionHealP2M(alldata.Find(x => x.potionName.Equals("HealP2M"))));
            invSystem.addItem(itemFabric.createPotionHealP3G(alldata.Find(x => x.potionName.Equals("HealP3G"))));
            invSystem.addItem(itemFabric.createPotionHealP4U(alldata.Find(x => x.potionName.Equals("HealP4U"))));
            invSystem.addItem(itemFabric.createPotionHealP4U(alldata.Find(x => x.potionName.Equals("HealP4U"))));
            
            //2 get items in first category    
            //displayInvertory("Potions");
        }

        private void Update()
        {
            // refresh dispaly               
        }

        public void displayInvertory(string category)
        {
            //refresh item panel
            foreach (Transform item in mainHolder.GetComponentInChildren<Transform>())
            {
                if (item.tag.Equals("Item"))
                    Destroy(item.gameObject);
            }

            switch (category)
            {
                case "Potions": { getCategory("Potions");  break; }
                case "Elixirs": { getCategory("Elixirs"); break; }
                case "Mixtures": { getCategory("Mixtures"); break; }
            }
        }
        //select all items from category
        private void getCategory(string category)
        {
            foreach (List<A_Item> itemType in invSystem.mainItemsStorage)
            {
                if (itemType[0].category.Equals(category))
                    getItems(itemType.Count,itemType[0].GetType().Name);
            }
        }
        //Instantiate selected items
        private void getItems(int itemCount, string itemTypeName)
        {
            GameObject instance = Instantiate(slotPrefab, mainHolder);            
            //Prefab instance has 2 child - Index 0 is <Image> - itemIcon - Index 1 is <Text> - itemCountText
            Transform component = instance.transform.GetChild(0);
            Image itemIcon = component.GetComponentInChildren<Image>();
            itemIcon.enabled = true;
            itemIcon.sprite = itemsSpriteSheet[getSpite(itemTypeName)];

            component = instance.transform.GetChild(1);
            Text itemCountText = component.GetComponentInChildren<Text>();
            itemCountText.text = itemCount.ToString();

            UIItem uiitem = instance.GetComponent<UIItem>();

            //TEMP set all objects as HealP1S
            foreach (List<A_Item> stack in invSystem.mainItemsStorage)
            {
                if (stack[0].GetType().Name.Equals(itemTypeName))
                {
                    uiitem.item = stack[0];
                    break;
                }
            }
            
        }

        private int getSpite(string name)
        {
            switch (name)
            {
                case "HealP1S": { return 12;}
                case "HealP2M": { return 1; }
                case "HealP3G": { return 2; }
                case "HealP4U": { return 3; }
                case "EneP1S": { return 0; }
                case "EneP2M": { return 1; }
                case "EneP3G": { return 2; }
                case "EneP4U": { return 3; }
                case "HealReP1S": { return 8; }
                case "HealReP2M": { return 9; }
                case "HealReP3G": { return 10; }
                case "HealReP4U": { return 11; }
                case "EneReP1S": { return 8; }
                case "EneReP2M": { return 9; }
                case "EneReP3G": { return 10; }
                case "EneReP4U": { return 11; }
                case "AirhUpMix1S": { return 4; }
                case "AirUpMix2M": { return 5; }
                case "AirUpMix3G": { return 6; }
                case "AirUpMix4U": { return 7; }
                case "DarknessUpMix1S": { return 4; }
                case "DarknessUpMix2M": { return 5; }
                case "DarknessUpMix3G": { return 6; }
                case "DarknessUpMix4U": { return 7; }
                case "DeathUpMix1S": { return 4; }
                case "DeathUpMix2M": { return 5; }
                case "DeathUpMix3G": { return 6; }
                case "DeathUpMix4U": { return 7; }
                case "EarthUpMix1S": { return 4; }
                case "EarthUpMix2M": { return 5; }
                case "EarthUpMix3G": { return 6; }
                case "EarthUpMix4U": { return 7; }
                case "FireUpMix1S": { return 4; }
                case "FireUpMix2M": { return 5; }
                case "FireUpMix3G": { return 6; }
                case "FireUpMix4U": { return 7; }
                case "LifeUpMix1S": { return 4; }
                case "LifeUpMix2M": { return 5; }
                case "LifeUpMix3G": { return 6; }
                case "LifeUpMix4U": { return 7; }
                case "LightningUpMix1S": { return 4; }
                case "LightningUpMix2M": { return 5; }
                case "LightningUpMix3G": { return 6; }
                case "LightningUpMix4U": { return 7; }
                case "PhysUpMix1S": { return 4; }
                case "PhysUpMix2M": { return 5; }
                case "PhysUpMix3G": { return 6; }
                case "PhysUpMix4U": { return 7; }
                case "WaterUpMix1S": { return 4; }
                case "WaterUpMix2M": { return 5; }
                case "WaterUpMix3G": { return 6; }
                case "WaterUpMix4U": { return 7; }
            }
            return 0;
        }
    }
}
