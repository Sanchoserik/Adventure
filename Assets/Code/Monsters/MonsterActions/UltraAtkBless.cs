using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.MonsterActions
{
    public class UltraAtkBless : A_MonsterAction
    {
        int duration;
        int blessVal;

        public UltraAtkBless(string aName, int pAP, int pENE, int cd, int dur, int bVal) : base(aName, pAP, pENE, cd)
        {
            duration = dur;
            blessVal = bVal;
        }
    }
}
