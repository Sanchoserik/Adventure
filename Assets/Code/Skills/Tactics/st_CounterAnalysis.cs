using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Skills.ActionScripts;


namespace Adventure.Skills.Tactics
{
    class st_CounterAnalysis : A_Skill
    {
        a_CounterAnalysisScript script = new a_CounterAnalysisScript();

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
