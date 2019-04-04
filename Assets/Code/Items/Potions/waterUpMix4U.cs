using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    class WaterUpMix4U : A_Item
    {
        public WaterUpMix4U(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new WaterUp(100, 7, h);
            eff.addToEffStack(h);

            dell(h.mainItemsStorage, this.id);
        }
    }
}
