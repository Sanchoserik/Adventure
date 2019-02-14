using Assets.Code;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Potions
{
    class HealP1S : A_Item
    {
        public HealP1S(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            h.currHP += Convert.ToInt32(h.maxHP * 0.3);
            if (h.currHP > h.maxHP) h.currHP = h.maxHP;

            dell(h.mainItemsStorage, this.id);
        }

    }
}
