using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;

namespace Assets.Items.Potions
{
    class lifeUpMix1S : A_Item
    {
        public lifeUpMix1S(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new lifeUp(20, 4, h);
            eff.addToEffStack(h);

            dell(h.inv_items, this.id);
        }
    }
}
