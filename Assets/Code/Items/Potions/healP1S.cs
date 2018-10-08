using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Potions
{
    class healP1S : A_Item
    {
        public healP1S(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            h.currHP += Convert.ToInt32(h.maxHP * 0.3);
            if (h.currHP > h.maxHP) h.currHP = h.maxHP;

            dell(h.inv_items, this.id);
        }

    }
}
