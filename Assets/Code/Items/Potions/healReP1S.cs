using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Effects;

namespace Adventure.Items.Potions
{
    class healReP1S : A_Item
    {
        public healReP1S(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new regHP(100,4,h);
            eff.addToEffStack(h);

            dell(h.inv_items, this.id);
        }
    }
}
