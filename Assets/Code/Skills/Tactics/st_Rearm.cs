using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.Skills;

namespace Assets.Code.Skills.Tactics
{
    class st_Rearm : A_Skill
    {
        as_Rearm script = new as_Rearm();

        public st_Rearm()
        {
            flag = 7;
        }
        // only for heroes
        public void callSkill(C_Hero user)
        {
            // call script 
           // script.callScript(user);

        }
    }
}
