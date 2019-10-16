using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.MonsterActions
{
    public class GreaterLightDefBless : A_MonsterAction
    {
        string element;
        int duration;
        int defBlessVal;

        public GreaterLightDefBless(string aName, int pAP, int pENE, int cd, string el, int dur, int bVal) : base(aName, pAP, pENE, cd)
        {
            element = el;
            duration = dur;
            defBlessVal = bVal;
        }
    }
}
