using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    public class LightUpMix1S : A_Item
    {
        public LightUpMix1S(string _name)
        {
                   localisedName = _name;
            category = "Mixtures";
        }
    }
}
