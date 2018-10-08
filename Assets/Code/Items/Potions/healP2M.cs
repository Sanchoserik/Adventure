using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Potions
{
    class healP2M : A_Item
    {
        public healP2M(int _id, string _name)
        {
            base.id = _id;
            base.name = _name;
        }

        public override void use(C_Hero h)
        {
            h.currHP += Convert.ToInt32(h.maxHP * 0.6);
            if (h.currHP > h.maxHP) h.currHP = h.maxHP;
        }
    }
}
