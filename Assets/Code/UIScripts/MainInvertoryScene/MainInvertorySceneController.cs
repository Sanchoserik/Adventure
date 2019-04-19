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

        InventorySystem invSystem;

        private void Start()
        {
            //1 get inventory
            invSystem = HeroController.mainHero.inventorySystem;
            //1.5 Test give items
            A_Item hppotS = new HealP1S("hpS");
            A_Item hppotM = new HealP2M("hpM");
            A_Item hppotG = new HealP3G("hpG");
            invSystem.addItem(hppotS);
            invSystem.addItem(hppotM);
            invSystem.addItem(hppotM);
            invSystem.addItem(hppotG);
            invSystem.addItem(hppotG);
            invSystem.addItem(hppotG);

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
                    getItems(itemType.Count);
            }
        }
        //Instantiate selected items
        private void getItems(int itemCount)
        {                       
            GameObject instance = Instantiate(slotPrefab, mainHolder);
            Text textItemCount = instance.GetComponentInChildren<Text>();
            textItemCount.enabled = true;
            textItemCount.text = itemCount.ToString();
           // instance.GetComponentInChildren<Image>.is ;

        }
    }
}
