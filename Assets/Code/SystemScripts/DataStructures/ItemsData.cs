using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts.DataStructures
{
    public class ItemsData
    {
        public string potionName;
        public Dictionary<string, string> potionParameters;

        public ItemsData()
        {
            potionParameters = new Dictionary<string, string>();
        }
    }
}
