using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Skills.ActionScripts;

namespace Adventure.Skills.Tactics
{
    class st_Overcharge : A_Skill
    {
        a_OverchargeScript script = new a_OverchargeScript();

        public st_Overcharge()
        {
            flag = 7;
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
