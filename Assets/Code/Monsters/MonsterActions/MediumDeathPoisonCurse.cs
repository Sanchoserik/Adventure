using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.MonsterActions
{
    public class MediumDeathPoisonCurse : A_MonsterAction
    {
        int duration;
        int poisonATK;

        public MediumDeathPoisonCurse(string aName, int pAP, int pENE, int cd, int dur, int pATK) : base(aName, pAP, pENE, cd)
        {
            duration = dur;
            poisonATK = pATK;
        }
    }
}
