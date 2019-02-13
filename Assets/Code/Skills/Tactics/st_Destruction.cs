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
    class st_Destruction : A_Skill
    {
        AS_Destruction script = new AS_Destruction();

        public st_Destruction()
        {
           
        }
        // only for heroes
        public void callSkill(C_Hero user)
        {
            // call script 
            script.callScript(user);

        }
    }
}
