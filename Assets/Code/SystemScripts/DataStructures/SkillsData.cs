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

        public SkillsData(string _sName, string _sScriptName ,short _sLevels,
            Dictionary<int, string> _sAPCost, Dictionary<int, string> _sEneCost, List<Dictionary<string, string>> _sValues)
        {
            skillName = _sName;
            skillScriptName = _sScriptName;
            skillLevels = _sLevels;
            skillAPCost = _sAPCost;
            skillEneCost = _sEneCost;
            skillValues = _sValues;
        }
    }
}
