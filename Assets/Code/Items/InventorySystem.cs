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
        public void addItem(A_Item item)
        {
            A_Item invItem = returnStack(item);
            if (invItem != null)
            {
                mainItemsStorage.Find(x => x.GetType().Name.Equals(invItem.GetType().Name)).itemCount++;
            }
            else
            {
                mainItemsStorage.Add(item);
            }       
        }

        public void removeItem(A_Item item)
        {
            mainItemsStorage.Remove(item);        
        }

        public void removeEmptyFromMainItemsStorage()
        {
            for (int i = 0; i < mainItemsStorage.Count; ++i)
            {
                if (mainItemsStorage[i].itemCount <= 0)
                    mainItemsStorage.RemoveAt(i);
            }
        }

        public void removeEmptyFromQAIemsStorage()
        {
            for (int i = 0; i < quickAccesItemStorage.Count; ++i)
            {
                if (quickAccesItemStorage[i].itemCount <= 0)
                    quickAccesItemStorage.RemoveAt(i);
            }
        }

        private A_Item returnStack(A_Item item)
        {
            foreach (A_Item invItem in mainItemsStorage)
            {
                if (invItem.GetType().Name.Equals(item.GetType().Name)) //get first item from stack
                {
                    return invItem;
                }
            }
            return null;
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
