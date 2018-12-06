using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Monsters;

namespace Assets.Code.Skills
{
    public class A_Skill
    {
        public int flag; // skill flag for unknown purposes
        public string dataFileName; //  ???
        public dataFileReader dfReader; // ???

        [XmlAttribute("name")]
        public string SName; // skill name
        [XmlAttribute("pAP")]
        public short APCost; // action points cost
        [XmlAttribute("pEne")]
        public int ENECost; // energy cost
        [XmlAttribute("levels")]
        public short levels; //levels count
        [XmlAttribute("scname")]
        public string ASName; // action script name

     
    }
}
