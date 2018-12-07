using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Assets.Code.Skills
{

    public class LevelData
    {
        [XmlAttribute("pAP")]
        public short apCost;
        [XmlAttribute("pEne")]
        public int eneCost;
    }
}
