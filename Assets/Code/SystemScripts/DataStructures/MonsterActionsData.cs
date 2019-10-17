using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts.DataStructures
{
    public class MonsterActionsData
    {
        public string actionName;
        public Dictionary<string, string> actionParameters;

        public MonsterActionsData()
        {
            actionParameters = new Dictionary<string, string>();
        }
    }
}
