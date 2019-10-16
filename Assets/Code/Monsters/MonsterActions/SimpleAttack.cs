using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters.MonsterActions
{
    public class SimpleAttack : A_MonsterAction
    {
        public SimpleAttack(string aName, int pAP, int pENE, int cd) : base(aName, pAP, pENE, cd)
        {
        }
    }
}
