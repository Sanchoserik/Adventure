using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Skills.ActionScripts;

namespace Adventure.Skills.Tactics
{
    class st_IronDefence : A_Skill
    {
        a_IronDefenceScript script = new a_IronDefenceScript();

        public st_IronDefence()
        {
            flag = 9;
            levels = 1; //???
            dfReader = null; //from data reader read
        }
        // only for heroes
        public void callSkill(C_Hero user)
        {
            // call script 
            script.callScript(user);

        }
    }
}
