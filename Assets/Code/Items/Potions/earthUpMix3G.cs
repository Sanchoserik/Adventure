﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using Assets.Effects;

namespace Assets.Items.Potions
{
    class earthUpMix3G : A_Item
    {
        public earthUpMix3G(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new earthUp(80, 6, h);
            eff.addToEffStack(h);

            dell(h.inv_items, this.id);
        }
    }
}
