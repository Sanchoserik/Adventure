using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts.DataStructures
{
    public class MonstersData
    {
        public string monsterName;
        public Dictionary<string, string> monsterParameters;
        public List<string> monsterActionsList;

        public MonstersData()
        {
            monsterParameters = new Dictionary<string, string>();
            monsterActionsList = new List<string>();
        }
    }
}
