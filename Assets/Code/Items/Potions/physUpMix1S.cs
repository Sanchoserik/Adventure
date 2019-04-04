using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    class PhysUpMix1S : A_Item
    {
        public PhysUpMix1S(string _name, C_Hero h)
        {
            id = returnFreeId(h);
            name = _name;
        }

        public override void use(C_Hero h)
        {
            A_Effect eff = new RhysUp(20, 4, h);
            eff.addToEffStack(h);

            dell(h.mainItemsStorage, this.id);
        }
    }
}
