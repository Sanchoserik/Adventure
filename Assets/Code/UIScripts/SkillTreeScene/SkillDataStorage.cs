using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.UIScripts.SkillTreeScene
{

    public class SkillDataStorage
    {
        //skill main data
        public int skillLevels; 
        public int skillCurentLevel; 
        public string skillName; 
        public string skillScriptName; 
        public Dictionary<int, string> skillAPCost; 
        public Dictionary<int, string> skillEneCost; 
        public List<Dictionary<string, string>> skillValues; 
        //skill Localisation data
        public string skillLocalisedName; // skill localised name
        public List<string> skillLocalisedLevelDescription; // skill level description
        public string skillMainDescription; // skil description
        public List<string> skillTargetsDescription; // localised skill targets 

        // Create a constructor that will accept multiple arguments that can be assigned to our variables. 
        public SkillDataStorage(short _levels, string _name, string _scname, Dictionary<int, string> _lcAP,
            Dictionary<int, string> _lcEne, List<Dictionary<string, string>> _vValues)
        {
            skillLevels = _levels;
            skillName = _name;
            skillScriptName = _scname;
            skillAPCost = _lcAP;
            skillEneCost = _lcEne;
            skillValues = _vValues;         
        }//end fun
    }//end class
}
