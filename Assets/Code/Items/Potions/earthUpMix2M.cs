﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using Adventure.Effects;

namespace Adventure.Items.Potions
{
    class earthUpMix2M : A_Item
    {
        public earthUpMix2M(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new earthUp(40, 5, h);
            eff.addToEffStack(h);

            dell(h.inv_items, this.id);
        }
    }
}
