using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Skills.ActionScripts;
using Assets.Code.Skills.ActionScripts.ASTactics;

namespace Assets.Skills.Tactics
{
    class st_ComboCharge : A_Skill
    {
        as_ComboCharge script = new as_ComboCharge();

        public st_ComboCharge()
        {
            flag = 2;
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
