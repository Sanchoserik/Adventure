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
    class st_CounterAnalysis : A_Skill
    {
        as_CounterAnalysis script = new as_CounterAnalysis();

        public st_CounterAnalysis()
        {
            flag = 3;
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
