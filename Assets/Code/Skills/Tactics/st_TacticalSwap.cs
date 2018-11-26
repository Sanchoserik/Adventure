using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using Assets.Skills.ActionScripts;

namespace Assets.Skills.Tactics
{
    class st_TacticalSwap : A_Skill
    {        
        a_TacticalSwapScript script = new a_TacticalSwapScript();

        public st_TacticalSwap()
        {
            flag = 1;
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
