using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Skills.ActionScripts;
using Assets.Code.Skills.ActionScripts.ASTactics;

namespace Assets.Skills.Tactics
{
    class st_AllIn : A_Skill
    {
        as_AllIn script = new as_AllIn();

        public st_AllIn()
        {
            flag = 1; 
            levels = 1; // 
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
