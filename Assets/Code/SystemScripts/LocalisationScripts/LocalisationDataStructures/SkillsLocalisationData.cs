using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts.LocalisationScripts.LocalisationDataStructures
{
    public class SkillsLocalisationData
    {
        public string skillLocalisedName;        
        public string skillMainDescription; //general skil description
        public List<string> skillTargetsDescription;
        public List<string> skillLocalisedLevelDescription; // skill concrette level description

        public SkillsLocalisationData(string _sLocalisedName, string _sMainDescr, List<string> _levelsdescr, List<string> _sTargetsDescr)
        {
            skillLocalisedName = _sLocalisedName;
            skillMainDescription = _sMainDescr;
            skillTargetsDescription = _sTargetsDescr;
            skillLocalisedLevelDescription = _levelsdescr;
        }
    }
}
