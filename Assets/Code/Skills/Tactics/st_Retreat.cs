using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.Skills.ActionScripts;

namespace Assets.Skills.Tactics
{
    public class st_Retreat : A_Skill
    {
        as_Retreat script = new as_Retreat();

        public st_Retreat()
        {
            flag = 9;
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
