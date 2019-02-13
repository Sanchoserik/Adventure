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
   
    public abstract class A_Skill
    {
        public string skillName;
        public bool isLearned;
        public short skillLevel;
        public short skillMaxLevel;

    }
}
