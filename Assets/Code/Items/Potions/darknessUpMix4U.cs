using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using Assets.Effects;

namespace Assets.Items.Potions
{
    class darknessUpMix4U : A_Item
    {
        public darknessUpMix4U(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new darknessUp(100, 7, h);
            eff.addToEffStack(h);

            dell(h.inv_items, this.id);
        }
    }
}
