using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Skills.ActionScripts;
using Assets.Code.Skills.ActionScripts.ASTactics;

namespace Assets.Skills.Tactics
{
    class st_Synchronization : A_Skill
    {
       as_Synchronization script = new as_Synchronization();

        public st_Synchronization()
        {
            flag = 10;
            levels = 1; // ?? 
            dfReader = new dataFileReader(); // data reader
        }
        // only for heroes
        public void callSkill(C_Hero user)
        {
            // call script 
            script.callScript(user);

        }
    }
}
