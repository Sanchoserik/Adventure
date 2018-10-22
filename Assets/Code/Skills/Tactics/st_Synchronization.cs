using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adventure.Skills.ActionScripts;

namespace Adventure.Skills.Tactics
{
    class st_Synchronization : A_Skill
    {
       a_SynchronizationScript script = new a_SynchronizationScript();

        public st_Synchronization()
        {
            flag = 11;
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
