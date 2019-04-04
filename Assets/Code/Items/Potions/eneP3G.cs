using Assets.Code;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Potions
{
    class EneP3G : A_Item
    {
        public EneP3G(int _id, string _name)
        {
            base.id = _id;
            base.name = _name;
        }

        public override void use(C_Hero h)
        {
            h.currENE += Convert.ToInt32(h.currENE * 0.8);
            if (h.currENE > h.maxENE) h.currENE = h.maxENE;
        }
    }
}
