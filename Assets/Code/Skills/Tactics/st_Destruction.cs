﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using Assets.Skills.ActionScripts;

namespace Assets.Skills.Tactics
{
    class st_Destruction : A_Skill
    {
        a_DestructionScript script = new a_DestructionScript();

        public st_Destruction()
        {
            flag = 6;
            levels = 1;
            dfReader = null;
        }
        // only for heroes
        public void callSkill(C_Hero user)
        {
            // call script 
            script.callScript(user);

        }
    }
}
