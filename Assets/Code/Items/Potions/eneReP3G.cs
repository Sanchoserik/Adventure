using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;

namespace Assets.Items.Potions
{
    class eneReP3G : A_Item
    {
        public eneReP3G(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new regENE(150, 6, h);
            eff.addToEffStack(h);

            dell(h.inv_items, this.id);
        }
    }
}
