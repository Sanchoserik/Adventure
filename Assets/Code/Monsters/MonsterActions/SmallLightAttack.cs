using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.MonsterActions
{
    public class SmallLightAttack : A_MonsterAction
    {
        string element;
        int ATKVal;

        public SmallLightAttack(string aName, int pAP, int pENE, int cd, string el, int ATKv) : base(aName, pAP, pENE, cd)
        {
            element = el;
            ATKVal = ATKv;
        }
    }
}
