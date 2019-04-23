using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Assets.PlayerController;
using Assets.Code.Items;
using Assets.Code.Items.Potions;

namespace Assets.Code.UIScripts.MainInvertoryScene
{
    public class MainInvertorySceneController : MonoBehaviour
    {
        public GameObject slotPrefab;
        public Transform mainHolder;
        public Sprite[] itemsSpriteSheet;

        InventorySystem invSystem;

        private void Start()
        {
            //1 get inventory
            invSystem = HeroController.mainHero.inventorySystem;
            //1.5 Test give items
            A_Item hppotS = new HealP1S("hpS");
            A_Item hppotM = new HealP2M("hpM");
            A_Item hppotG = new HealP3G("hpG");
            A_Item enepotS = new EneP1S("eneS");
            invSystem.addItem(hppotS);
            invSystem.addItem(hppotM);
            invSystem.addItem(hppotM);
            invSystem.addItem(hppotG);
            invSystem.addItem(hppotG);
            invSystem.addItem(hppotG);
            invSystem.addItem(enepotS);
            invSystem.addItem(enepotS);

            //2 get items in first category    
            displayInvertory("Potions");
        }

        private void Update()
        {
            // refresh dispaly               
        }

        public void displayInvertory(string category)
        {
            switch (category)
            {
                case "Potions": { getCategory("Potions");  break; }
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
        }

        private int getSpite(string name)
        {
            switch (name)
            {
                case "HealP1S": { return 0;}
                case "HealP2M": { return 3; }
                case "HealP3G": { return 1; }
                case "HealP4U": { return 2; }
                case "EneP1S": { return 4; }
            }
            return 0;
        }
    }
}
