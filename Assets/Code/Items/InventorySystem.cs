using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Items
{
    public class InventorySystem
    {
        public List<List<A_Item>> mainItemsStorage;
        public List<A_Item> mainTalismansStorage;
        public List<A_Item> inUseTalismansStorage; // native size = 10
        public List<A_Item> quickAccesItemStorage; // native size = 5

        public const int inUseTalismansSize = 10;
        public const int quickAccesItemsSize = 5; 

        public InventorySystem()
        {
            mainItemsStorage = new List<List<A_Item>>();
            mainTalismansStorage = new List<A_Item>();

            //initialize empty
            inUseTalismansStorage = new List<A_Item>();
            for (int i = 0; i < inUseTalismansSize; ++i)
            {
                inUseTalismansStorage.Add(null);
            }

            quickAccesItemStorage = new List<A_Item>();
            for (int i = 0; i < quickAccesItemsSize; ++i)
            {
                quickAccesItemStorage.Add(null);
            }
        }

        //for items storage
        public void addItem(A_Item item)
        {
            if (checkStacks(item.GetType().Name))
            {
                foreach (List<A_Item> stack in mainItemsStorage)
                {
                    if (stack[0].GetType().Name.Equals(item.GetType().Name))
                    {
                        stack.Add(item);
                        break;
                    }
                }
              
            }
            else
            {
                mainItemsStorage.Add(new List<A_Item> { item });             
            }  
        }

        public void removeItem(A_Item item)
        {
            if (checkStacks(item.GetType().Name))
            {
                foreach (List<A_Item> items in mainItemsStorage)
                {
                    if (items[0] != null && items[0].Equals(item))
                    {
                        items.Remove(item);                        
                    }
                }
            }
            removeEmptyItemStacks();
        }

        private bool checkStacks(string itemType)
        {
            foreach (List<A_Item> items in mainItemsStorage)
            {
                if (items[0] != null && items[0].GetType().Name.Equals(itemType)) //get first item from stack
                {
                    return true;
                }                 
            }
            return false;
        }

        private void removeEmptyItemStacks()
        {
            for (int i = 0; i < mainItemsStorage.Count; ++i)
            {
                if (mainItemsStorage[i].Count == 0)
                    mainItemsStorage.RemoveAt(i);
            }
        }
        
        //for talismans storage
        public void addTalisman(A_Item item)
        {
            mainTalismansStorage.Add(item);
        }

        public void removeTalisman(A_Item item)
        {
            mainTalismansStorage.Remove(item);
        }


    }
}
