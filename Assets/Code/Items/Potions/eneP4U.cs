using Assets.Code;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Potions
{
    class EneP4U : A_Item
    {
        public EneP4U(int _id, string _name)
        {
            base.id = _id;
            base.name = _name;
        }

        public override void use(C_Hero h)
        {
          h.currENE = h.maxENE;
        }
    }
}
