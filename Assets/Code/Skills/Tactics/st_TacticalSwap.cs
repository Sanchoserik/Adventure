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
    class st_TacticalSwap : A_Skill
    {        
        as_TacticalSwap script = new as_TacticalSwap();

        public st_TacticalSwap()
        {
            flag = 12;
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
