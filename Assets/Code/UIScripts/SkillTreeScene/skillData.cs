using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.UIScripts.SkillTreeScene
{
    public class skillData
    {
        public short levels; // level count
        public short currLevel; // current level
        public string name; // skill name
        public string scName; //scriptname
        public Dictionary<int, string> lcAP; // ap price
        public Dictionary<int, string> lcEne; // ene price
        public List<Dictionary<string, string>> vValues; // level values

        //localisation
        public string locName; // skill localised name
        public List<string> locDescr; // skill level description
        public string sDescr; // skil description
        public List<string> locTargets; // localised skill targets 

        // Create a constructor that will accept multiple arguments that can be assigned to our variables. 
        public skillData(short _levels, string _name, string _scname, Dictionary<int, string> _lcAP,
            Dictionary<int, string> _lcEne, List<Dictionary<string, string>> _vValues)
        {
            levels = _levels;
            name = _name;
            scName = _scname;
            lcAP = _lcAP;
            lcEne = _lcEne;
            vValues = _vValues;         
        }//end fun
    }//end class
}
