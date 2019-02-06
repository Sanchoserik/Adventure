using Assets.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Potions
{
    class HealP3G : A_Item
    {
        public HealP3G(int _id, string _name)
        {
            base.id = _id;
            base.name = _name;
        }

        public override void use(C_Hero h)
        {
            h.currHP += Convert.ToInt32(h.maxHP * 0.8);
            if (h.currHP > h.maxHP) h.currHP = h.maxHP;
        }
    }
}
