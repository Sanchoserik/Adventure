using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Items
{
    public class InventorySystem
    {
        public List<List<A_Item>> mainItemsStorage;
        public List<A_Talisman> mainTalismansStorage;
        public List<A_Talisman> inUseTalismansStorage;
        public List<A_Item> quickAccesItemStorage;

        public InventorySystem()
        {
            mainItemsStorage = new List<List<A_Item>>();
            mainTalismansStorage = new List<A_Talisman>();
            inUseTalismansStorage = new List<A_Talisman>();
            quickAccesItemStorage = new List<A_Item>();
        }

        public string addItem(A_Item item)
        {
            if (checkStacks(item.GetType().ToString()))
            {
                mainItemsStorage.Find(x => x.GetType().Name.Equals(item.GetType().Name)).Add(item);
                return "found";
            }
            else
            {
                mainItemsStorage.Add(new List<A_Item> { item });
                return item.GetType().Name;
            }
           
        }

        private bool checkStacks(string itemType)
        {
            foreach (List<A_Item> items in mainItemsStorage)
            {
                if (items.GetType().Name.Equals(itemType))
                {
                    return true;
                }                 
            }
            return false;
        }
    }
}
