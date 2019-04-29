using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    public class HealReP2M : A_Item
    {
        public HealReP2M(string _name)
        {
            localisedName = _name;
            category = "Elixirs";
        }

    }
}
