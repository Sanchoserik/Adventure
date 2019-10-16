using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.MonsterActions
{
    public class GreaterRandomDefCurse : A_MonsterAction
    {
        int duration;
        int defCurseVal;

        public GreaterRandomDefCurse(string aName, int pAP, int pENE, int cd, int dur, int cVal) : base(aName, pAP, pENE, cd)
        {
            duration = dur;
            defCurseVal = cVal;
        }
    }
}
