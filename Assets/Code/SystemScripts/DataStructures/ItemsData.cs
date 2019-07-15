using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts.DataStructures
{
    public class ItemsData
    {
        public string itemName;
        public Dictionary<string, string> itemsParameters;

        public ItemsData()
        {
            itemsParameters = new Dictionary<string, string>();
        }
    }
}
