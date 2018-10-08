using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Skills.ActionScripts;

namespace Adventure.Skills.Tactics
{
    class st_CriticalBalance : A_Skill
    {
        a_CriticalBalanceScript script = new a_CriticalBalanceScript();

        public st_CriticalBalance()
        {
            flag = 8;
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
