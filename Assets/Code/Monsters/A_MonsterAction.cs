using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters
{
    public abstract class A_MonsterAction
    {
        public string actionName;
        public int priceAP;
        public int priceENE;
        public int cooldown;

        public A_MonsterAction(string aName, int pAP,int pENE, int cd)
        {
            actionName = aName;
            priceAP = pAP;
            priceENE = pENE;
            cooldown = cd;
        }     
    }
}
