using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Potions
{
    class eneP1S : A_Item
    {
        public eneP1S(int _id, string _name)
        {
            base.id = _id;
            base.name = _name;
        }

        public override void use(C_Hero h)
        {
            h.currENE += Convert.ToInt32(h.currENE * 0.3);
            if (h.currENE > h.maxENE) h.currENE = h.maxENE;
        }

    }
}
