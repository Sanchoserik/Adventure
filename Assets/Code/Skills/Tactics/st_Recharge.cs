using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Skills.ActionScripts;

namespace Adventure.Skills.Tactics
{
    class st_Recharge :A_Skill
    {
        a_RechargeScript script = new a_RechargeScript();

        public st_Recharge()
        {
            flag = 5;
            levels = 1; //???
            dfReader = null; //data reader read
        }
        // only for heroes
        public void callSkill(C_Hero user)
        {
            // call script 
            script.callScript(user);

        }
    }
}
