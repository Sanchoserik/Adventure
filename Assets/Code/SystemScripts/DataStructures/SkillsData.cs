using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts.DataStructures
{
    public class SkillsData
    {
        public short skillLevels;
        public short skillCurentLevel;
        public string skillName;
        public string skillScriptName;
        public Dictionary<int, string> skillAPCost;
        public Dictionary<int, string> skillEneCost;
        public List<Dictionary<string, string>> skillValues;

        SkillsData()
        {

        }
    }
}
