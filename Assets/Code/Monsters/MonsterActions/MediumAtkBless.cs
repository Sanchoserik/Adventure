using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.MonsterActions
{
    public class MediumAtkBless : A_MonsterAction
    {
        int duration;
        int blessVal;

        public MediumAtkBless(string aName, int pAP, int pENE, int cd, int dur, int bVal) : base(aName, pAP, pENE, cd)
        {
            duration = dur;
            blessVal = bVal;
        }
    }
}
