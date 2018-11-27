using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.Skills.ActionScripts;

namespace Assets.Skills.Tactics
{
    class st_Overcharge : A_Skill
    {
        as_Overcharge script = new as_Overcharge();

        public st_Overcharge()
        {
            flag = 6;
            levels = 1; //???
            dfReader = null; //data reder read
        }
        // only for heroes
        public void callSkill(C_Hero user)
        {
            // call script 
            script.callScript(user);

        }
    }
}
