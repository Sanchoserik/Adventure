using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.MonsterActions
{
    public class Overcharge : A_MonsterAction
    {
        int duration;
        int physATKBonus;
        int magATKBonus;

        public Overcharge(string aName, int pAP, int pENE, int cd, int dur, int pATK, int mATK) : base(aName, pAP, pENE, cd)
        {
            duration = dur;
            physATKBonus = pATK;
            magATKBonus = mATK;
        }
    }
}
