using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.MonsterActions
{
    public class GreaterHealing : A_MonsterAction
    {
        int healingVal;

        public GreaterHealing(string aName, int pAP, int pENE, int cd, int hVal) : base(aName, pAP, pENE, cd)
        {
            healingVal = hVal;
        }
    }
}
