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
    class st_TacticalPreparation : A_Skill
    {
        AS_Retreat script = new AS_Retreat();

        public st_TacticalPreparation()
        {
            flag = 11;
        }
        // only for heroes
        public void callSkill(C_Hero user) //specify data from reader
        {
            // call script 
            script.callScript(user);

        }
    }
}
