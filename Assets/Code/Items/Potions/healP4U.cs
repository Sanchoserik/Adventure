using Assets.Code;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Potions
{
    class HealP4U : A_Item
    {
        public HealP4U(int _id, string _name)
        {
            base.id = _id;
            base.name = _name;
        }

        public override void use(C_Hero h)
        {
            h.currHP = h.maxHP;
        }
    }
}
