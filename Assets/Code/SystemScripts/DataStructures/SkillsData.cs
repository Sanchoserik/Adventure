using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts.DataStructures
{
    public class SkillsData
    {
        public int skillLevels;
        public int skillCurentLevel;
        public string skillName;
        public string skillAScriptName;
        public Dictionary<int, string> skillAPCost;
        public Dictionary<int, string> skillEneCost;
        public Dictionary<int, string> skillCooldown;
        public List<Dictionary<string, string>> skillValues;

        public SkillsData(string sName, string sScriptName ,int sLevels,
            Dictionary<int, string> sAPCost, Dictionary<int, string> sEneCost,
            Dictionary<int, string> sCooldown, List<Dictionary<string, string>> sValues)
        {
            skillName = sName;
            skillAScriptName = sScriptName;
            skillLevels = sLevels;
            skillAPCost = sAPCost;
            skillEneCost = sEneCost;
            skillCooldown = sCooldown;
            skillValues = sValues;
        }
    }
}
