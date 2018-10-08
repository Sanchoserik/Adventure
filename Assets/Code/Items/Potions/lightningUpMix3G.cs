﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Effects;

namespace Adventure.Items.Potions
{
    class lightningUpMix3G : A_Item
    {
        public lightningUpMix3G(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new lightningUp(80, 6, h);
            eff.addToEffStack(h);

            dell(h.inv_items, this.id);
        }
    }
}
