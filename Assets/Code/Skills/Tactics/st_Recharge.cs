using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.Skills.ActionScripts;

namespace Assets.Code.Skills.Tactics
{
    class st_Recharge :A_Skill
    {
        as_Recharge script = new as_Recharge();

        public st_Recharge()
        {
            flag = 8;
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
