using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Items
{
    public class InventorySystem
    {
        public List<A_Item> mainItemsStorage;
        public List<A_Item> mainTalismansStorage;
        public List<A_Item> inUseTalismansStorage; // native size = 10
        public List<A_Item> quickAccesItemStorage; // native size = 5

        public const int inUseTalismansSize = 10;
        public const int quickAccesItemsSize = 5; 

        public InventorySystem()
        {
            mainItemsStorage = new List<A_Item>();
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
        public void addItem(A_Item item, List<A_Item> storage)
        {
            A_Item invItem = null;
            if (item.stackable)
             invItem = returnStack(item, storage);

            if (invItem != null)
            {
                storage.Find(x => x.GetType().Name.Equals(invItem.GetType().Name)).itemCount++;
            }
            else
            {
                storage.Add(item);
            }       
        }

        public void removeItem(A_Item item, List<A_Item> storage)
        {
            A_Item invItem = storage.Find(x => x.GetType().Name.Equals(item.GetType().Name));
            invItem.itemCount--;
            if(invItem.itemCount <=0)
             storage.Remove(item);        
        }

        public void removeEmptyFromMainItemsStorage(List<A_Item> storage)
        {
            for (int i = 0; i < storage.Count; ++i)
            {
                if (storage[i].itemCount <= 0)
                    storage.RemoveAt(i);
            }
        }

        private A_Item returnStack(A_Item item,List<A_Item> storage)
        {
            foreach (A_Item invItem in storage)
            {
                if (invItem.GetType().Name.Equals(item.GetType().Name)) //get first item from stack
                {
                    return invItem;
                }
            }
            return null;
        }

    }
}
