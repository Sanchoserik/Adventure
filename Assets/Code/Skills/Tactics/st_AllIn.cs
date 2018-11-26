using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Assets.Skills.ActionScripts;

namespace Assets.Skills.Tactics
{
    class st_AllIn : A_Skill
    {
        a_AllInScript script = new a_AllInScript();

        public st_AllIn()
        {
            flag = 10; 
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
