using Assets.Code;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Potions
{
    public class HealP2M : A_Item
    {
        public HealP2M(string _name)
        {
           localisedName = _name;
            category = "Potions";
        }

    }
}
