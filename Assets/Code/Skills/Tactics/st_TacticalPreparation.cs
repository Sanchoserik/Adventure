using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.Skills.ActionScripts;

namespace Assets.Skills.Tactics
{
    class st_TacticalPreparation : A_Skill
    {
        as_Retreat script = new as_Retreat();

        public st_TacticalPreparation()
        {
            flag = 11;
            levels = 3;
            dfReader = null; //reader read data on creation 
        }
        // only for heroes
        public void callSkill(C_Hero user) //specify data from reader
        {
            // call script 
            script.callScript(user);

        }
    }
}
