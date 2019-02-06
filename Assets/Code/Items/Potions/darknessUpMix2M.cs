﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;

namespace Assets.Items.Potions
{
    class DarknessUpMix2M : A_Item
    {
        public DarknessUpMix2M(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new DarknessUp(50, 5, h);
            eff.addToEffStack(h);

            dell(h.mainItemsStorage, this.id);
        }
    }
}
