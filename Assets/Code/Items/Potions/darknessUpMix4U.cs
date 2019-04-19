using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    public class DarknessUpMix4U : A_Item
    {
        public DarknessUpMix4U(string _name)
        {         
            localisedName = _name;
            category = "Mixtures";
        }
    }
}
