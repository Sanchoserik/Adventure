﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    public class WaterUpMix1S : A_Item
    {
        public WaterUpMix1S(string _name)
        {
            localisedName = _name;
            category = "Mixtures";
        }

    }
}
