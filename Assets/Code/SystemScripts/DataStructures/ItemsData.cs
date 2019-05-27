using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts.DataStructures
{
    public class ItemsData
    {
        public Dictionary<string, string> potionsParameters;

        public ItemsData()
        {
            potionsParameters = new Dictionary<string, string>();
        }
    }
}
