﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    public class FireUpMix1S : A_Item
    {
        public short defValue;
        public int defTime;

        public FireUpMix1S(short _defVal, int _defTime, int _price) : base(_price)
        {
            defValue = _defVal;
            defTime = _defTime;
            category = "Mixtures";
        }

    }
}
