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
    class st_IronDefence : A_Skill
    {
        as_IronDefence script = new as_IronDefence();

        public st_IronDefence()
        {
            flag = 5;
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
