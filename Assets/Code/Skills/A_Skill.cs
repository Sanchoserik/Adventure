using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Monsters;
using UnityEngine;

namespace Assets.Code.Skills
{
    [XmlRoot("skill")]
    public class A_Skill
    {
        public int flag; // skill flag for unknown purposes

        [XmlAttribute("name")]
        public string SName; // skill name        
        [XmlAttribute("levels")]
        public short levels; //levels count
        [XmlAttribute("scname")]
        public string ASName; // action script name

    }
}
