﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    public class WaterUpMix3G : A_Item
    {
        public short defValue;
        public int defTime;

        public WaterUpMix3G(short _defVal, int _defTime, int _price) : base(_price)
        {
            defValue = _defVal;
            defTime = _defTime;
            category = "Mixtures";
        }
    }
}
