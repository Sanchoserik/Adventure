using Assets.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Potions
{
    class eneP4U : A_Item
    {
        public eneP4U(int _id, string _name)
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
