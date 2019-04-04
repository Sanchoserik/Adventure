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
    }
}
