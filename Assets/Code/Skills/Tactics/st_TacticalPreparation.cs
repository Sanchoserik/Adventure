using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Skills.ActionScripts;

namespace Adventure.Skills.Tactics
{
    class st_TacticalPreparation : A_Skill
    {
        a_RetreatScript script = new a_RetreatScript();

        public st_TacticalPreparation()
        {
            flag = 4;
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
