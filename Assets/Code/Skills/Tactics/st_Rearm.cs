using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.PlayerController;
using Assets.Skills;

namespace Assets.Code.Skills.Tactics
{
    class st_Rearm : A_Skill
    {
        AS_Rearm script = new AS_Rearm();

        public st_Rearm()
        {
           
        }
        // only for heroes
        public void callSkill(C_Hero user)
        {
            // call script 
           // script.callScript(user);

        }
    }
}
