﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using Adventure.Effects;

namespace Adventure.Items.Potions
{
    class darknessUpMix2M : A_Item
    {
        public darknessUpMix2M(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new darknessUp(50, 5, h);
            eff.addToEffStack(h);

            dell(h.inv_items, this.id);
        }
    }
}
