using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adventure.Skills.ActionScripts;

namespace Adventure.Skills.Tactics
{
    class st_ComboCharge : A_Skill
    {
        a_ComboChargeScript script = new a_ComboChargeScript();

        public st_ComboCharge()
        {
            flag = 11;
            levels = 1; // more than one 
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
