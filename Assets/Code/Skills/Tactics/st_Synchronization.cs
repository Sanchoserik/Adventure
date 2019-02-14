﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Skills.ActionScripts;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.PlayerController;

namespace Assets.Code.Skills.Tactics
{
    class st_Synchronization : A_Skill
    {
       AS_Synchronization script = new AS_Synchronization();

        public st_Synchronization()
        {
          
        }
        // only for heroes
        public void callSkill(C_Hero user)
        {
            // call script 
            script.callScript(user);

        }
    }
}
