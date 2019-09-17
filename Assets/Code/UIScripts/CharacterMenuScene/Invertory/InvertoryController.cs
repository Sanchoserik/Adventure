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
using UnityEngine.U2D;

namespace Assets.Code.UIScripts.CharacterMenuScene.Invertory
{
    
    public class InvertoryController : MonoBehaviour
    {
        public GameObject slotPrefab;
        public Transform mainHolder;
        public Transform quickAccesHolder;
    
        public SpriteAtlas itemsAtlas;

        private InventorySystem invSystem;

        private void Start()
        {
            //TEST
            //1 get inventory
            invSystem = HeroController.mainHero.inventorySystem;
            //TEST FABRIC
            ItemFabric itemFabric = new ItemFabric();
            List<ItemsData> alldata = SystemScripts.ResourcesManager.itemsData;

            invSystem.addItem(itemFabric.createPotionAirUpMix1S(alldata.Find(x => x.itemName.Equals("AirUpMix1S"))), invSystem.mainItemsStorage);
            invSystem.addItem(itemFabric.createPotionHealP1S(alldata.Find(x => x.itemName.Equals("HealP1S"))), invSystem.mainItemsStorage);
            invSystem.addItem(itemFabric.createPotionHealP2M(alldata.Find(x => x.itemName.Equals("HealP2M"))), invSystem.mainItemsStorage);
            invSystem.addItem(itemFabric.createPotionHealP2M(alldata.Find(x => x.itemName.Equals("HealP2M"))), invSystem.mainItemsStorage);
            invSystem.addItem(itemFabric.createPotionHealP3G(alldata.Find(x => x.itemName.Equals("HealP3G"))), invSystem.mainItemsStorage);
            invSystem.addItem(itemFabric.createPotionHealP4U(alldata.Find(x => x.itemName.Equals("HealP4U"))), invSystem.mainItemsStorage);
            invSystem.addItem(itemFabric.createPotionHealP4U(alldata.Find(x => x.itemName.Equals("HealP4U"))), invSystem.mainItemsStorage);

            //add talisman
            invSystem.addItem(itemFabric.createTalismanDefAir1S(alldata.Find(x => x.itemName.Equals("DefAir1S"))), invSystem.mainTalismansStorage);
            invSystem.addItem(itemFabric.createTalismanDefAir2M(alldata.Find(x => x.itemName.Equals("DefAir2M"))), invSystem.mainTalismansStorage);
            invSystem.addItem(itemFabric.createTalismanDefAir3G(alldata.Find(x => x.itemName.Equals("DefAir3G"))), invSystem.mainTalismansStorage);
            invSystem.addItem(itemFabric.createTalismanDefAir4U(alldata.Find(x => x.itemName.Equals("DefAir4U"))), invSystem.mainTalismansStorage);
            invSystem.addItem(itemFabric.createTalismanDefFire1S(alldata.Find(x => x.itemName.Equals("DefFire1S"))), invSystem.mainTalismansStorage);
            invSystem.addItem(itemFabric.createTalismanDefFire2M(alldata.Find(x => x.itemName.Equals("DefFire2M"))), invSystem.mainTalismansStorage);
            invSystem.addItem(itemFabric.createTalismanDefFire3G(alldata.Find(x => x.itemName.Equals("DefFire3G"))), invSystem.mainTalismansStorage);
            invSystem.addItem(itemFabric.createTalismanDefFire4U(alldata.Find(x => x.itemName.Equals("DefFire4U"))), invSystem.mainTalismansStorage);

        }

        public void displayInvertory(string category)
        {
            //refresh item panel
            foreach (Transform item in mainHolder.GetComponentInChildren<Transform>())
            {
                if (item.tag.Equals("Item"))
                    Destroy(item.gameObject);
            }

            foreach (Transform item in quickAccesHolder.GetComponentInChildren<Transform>())
            {
                if (item.tag.Equals("Item"))
                    Destroy(item.gameObject);
            }

            switch (category)
            {
                case "Potions": { getCategory("Potions");  break; }
                case "Elixirs": { getCategory("Elixirs"); break; }
                case "Mixtures": { getCategory("Mixtures"); break; }
                case "Talismans": { getCategory("Talismans"); break; }
            }
        }
        //select all items from category
        private void getCategory(string category)
        {
            if (category.Equals("Talismans"))
            {
                //get talismans
                foreach (A_Item talisman in invSystem.mainTalismansStorage)
                    getTalismans(talisman);

                instantiateTalismansInUsePanel();
            }
            else
            {
                foreach (A_Item itemType in invSystem.mainItemsStorage)
                {
                    if (itemType.category.Equals(category))
                        getItems(itemType.itemCount, itemType.GetType().Name);

                }
                instantiateQuickAccesItems();          
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
            component = instance.transform.GetChild(1);
            Text itemCountText = component.GetComponentInChildren<Text>();
            itemCountText.text = itemCount.ToString();

            UIItem uiItem = instance.GetComponent<UIItem>();
            
            foreach (A_Item stack in invSystem.mainItemsStorage)
            {
                if (stack.GetType().Name.Equals(itemTypeName))
                {
                    uiItem.item = stack;
                    break;
                }
            }
            
            itemIcon.sprite = itemsAtlas.GetSprite(uiItem.item.GetType().Name);
        }
       
        private void getTalismans(A_Item talisman)
        {
            GameObject instance = Instantiate(slotPrefab, mainHolder);
            //Prefab instance has 2 child - Index 0 is <Image> - itemIcon - Index 1 is <Text> - itemCountText
            Transform component = instance.transform.GetChild(0);
            Image itemIcon = component.GetComponentInChildren<Image>();
            itemIcon.enabled = true;
            component = instance.transform.GetChild(1);
            Text itemCountText = component.GetComponentInChildren<Text>();
            itemCountText.enabled = true;
            itemCountText.text = getItemText(talisman);

            UIItem uiItem = instance.GetComponent<UIItem>();
            uiItem.item = talisman;

            itemIcon.sprite = itemsAtlas.GetSprite(uiItem.item.GetType().Name);
        }

        private void instantiateQuickAccesItems()
        {
            foreach (A_Item item in invSystem.quickAccesItemStorage)
            {
                GameObject instance = Instantiate(slotPrefab, quickAccesHolder);
                Transform component = instance.transform.GetChild(0);
                Image itemIcon = component.GetComponentInChildren<Image>();

                if (item != null)
                {
                    itemIcon.enabled = true;
                    itemIcon.sprite = itemsAtlas.GetSprite(item.GetType().Name);

                    component = instance.transform.GetChild(1);
                    Text itemCountText = component.GetComponentInChildren<Text>();
                    itemCountText.enabled = true;
                    UIItem uiitem = instance.GetComponent<UIItem>();

                    foreach (A_Item stack in invSystem.quickAccesItemStorage)
                    {
                        if (stack.GetType().Name.Equals(item.GetType().Name))
                        {
                            uiitem.item = stack;
                            break;
                        }
                    }

                }
                else
                {
                    itemIcon.enabled = false;
                    component = instance.transform.GetChild(1);
                    Text itemCountText = component.GetComponentInChildren<Text>();
                    itemCountText.enabled = false;
                }
            }
        }

        private void instantiateTalismansInUsePanel()
        {
            foreach (A_Item item in invSystem.inUseTalismansStorage)
            {
                GameObject instance = Instantiate(slotPrefab, quickAccesHolder);
                Transform component = instance.transform.GetChild(0);
                Image itemIcon = component.GetComponentInChildren<Image>();

                if (item != null)
                {
                    itemIcon.enabled = true;
                    itemIcon.sprite = itemsAtlas.GetSprite(item.GetType().Name);

                    component = instance.transform.GetChild(1);
                    Text itemCountText = component.GetComponentInChildren<Text>();
                    itemCountText.enabled = true;
                    UIItem uiitem = instance.GetComponent<UIItem>();
                    uiitem.item = item;                   
                }
                else
                {
                    itemIcon.enabled = false;
                    component = instance.transform.GetChild(1);
                    Text itemCountText = component.GetComponentInChildren<Text>();
                    itemCountText.enabled = false;
                }
            }
        }

        private string getItemText(A_Item item)
        {
            if (item.stackable)
            {
               return item.itemCount.ToString();
            }
            else
            {
                item.talismanCalculateMaxPower(); //recalculate tpower
                return item.talismanGetPower();
            }            
        }
        
    }

    //enum with items names - just in case
    //enum ItemsEnum
    //{
    //    DefAir1S, DefAir2M, DefAir3G, DefAir4U,
    //    DefDarkness1S, DefDarkness2M, DefDarkness3G, DefDarkness4U,
    //    DefDeath1S, DefDeath2M, DefDeath3G, DefDeath4U,
    //    DefEarth1S, DefEarth2M, DefEarth3G, DefEarth4U,
    //    DefFire1S, DefFire2M, DefFire3G, DefFire4U,
    //    DefLife1S, DefLife2M, DefLife3G, DefLife4U,
    //    DefLight1S, DefLight2M, DefLight3G, DefLight4U,
    //    DefLightning1S, DefLightning2M, DefLightning3G, DefLightning4U,
    //    DefPhys1S, DefPhys2M, DefPhys3G, DefPhys4U,
    //    DefWater1S, DefWater2M, DefWater3G, DefWater4U,
    //    // end Talisman Enum
    //    HealP1S, HealP2M, HealP3G, HealP4U,
    //    EneP1S, EneP2M, EneP3G, EneP4U,
    //    // Potions
    //    AirUp1S, AirUp2M, AirUp3G, AirUp4U,
    //    DarknessUp1S, DarknessUp2M, DarknessUp3G, DarknessUp4U,
    //    DeathUp1S, DeathUp2M, DeathUp3G, DeathUp4U,
    //    EarthUp1S, EarthUp2M, EarthUp3G, EarthUp4U,
    //    FireUp1S, FireUp2M, FireUp3G, FireUp4U,
    //    LifeUp1S, LifeUp2M, LifeUp3G, LifeUp4U,
    //    LightUp1S, LightUp2M, LightUp3G, LightUp4U,
    //    LightningUp1S, LightningUp2M, LightningUp3G, LightningUp4U,
    //    PhysUp1S, PhysUp2M, PhysUp3G, PhysUp4U,
    //    WaterUp1S, WaterUp2M, WaterUp3G, WaterUp4U,
    //    // Mixtures
    //    HealRe1S, HealRe2M, HealRe3G, HealRe4U,
    //    EneRe1S, EneRe2M, EneRe3G, EneRe4U
    //    // Elixirs
    //    //end Items Enum
    //}

}
