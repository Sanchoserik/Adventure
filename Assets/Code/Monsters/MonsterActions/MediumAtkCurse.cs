using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.MonsterActions
{
    public class MediumAtkCurse : A_MonsterAction
    {
        int duration;
        int curseVal;

        public MediumAtkCurse(string aName, int pAP, int pENE, int cd, int dur, int cVal) : base(aName, pAP, pENE, cd)
        {
            duration = dur;
            curseVal = cVal;
        }
    }
}
