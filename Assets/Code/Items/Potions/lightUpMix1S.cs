﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using Adventure.Effects;

namespace Adventure.Items.Potions
{
    class lightUpMix1S : A_Item
    {
        public lightUpMix1S(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new lightUp(20, 4, h);
            eff.addToEffStack(h);

            dell(h.inv_items, this.id);
        }
    }
}
