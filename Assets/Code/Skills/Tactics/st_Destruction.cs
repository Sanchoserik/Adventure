using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.Skills.ActionScripts;

namespace Assets.Skills.Tactics
{
    class st_Destruction : A_Skill
    {
        as_Destruction script = new as_Destruction();

        public st_Destruction()
        {
            flag = 4;
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
