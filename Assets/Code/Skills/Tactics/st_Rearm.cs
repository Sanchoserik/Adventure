using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.Skills;

namespace Assets.Code.Skills.Tactics
{
    class st_Rearm : A_Skill
    {
        as_Rearm script = new as_Rearm();

        public st_Rearm()
        {
            flag = 7;
            levels = 1; // ?? 
            dfReader = new dataFileReader(); // data reader
        }
        // only for heroes
        public void callSkill(C_Hero user)
        {
            // call script 
           // script.callScript(user);

        }
    }
}
