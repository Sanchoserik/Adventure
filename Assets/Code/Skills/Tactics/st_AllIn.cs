﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Skills.ActionScripts;
using Assets.Code.Skills.ActionScripts.ASTactics;

namespace Assets.Code.Skills.Tactics
{
    class st_AllIn : A_Skill
    {
        AS_AllIn script = new AS_AllIn();

        //additional attributes
        [XmlElement("v1")]
        public int addAP;
        [XmlElement("v2")]
        public int Time;
        //
        public st_AllIn()
        {
            flag = 1;   
        }
        // only for heroes
        public void callSkill(C_Hero user)
        {
            // call script 
            script.callScript(user);
        }
    }
}
