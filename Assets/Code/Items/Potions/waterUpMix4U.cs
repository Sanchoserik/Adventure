﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    public class WaterUpMix4U : A_Item
    {
        public int defValue;
        public int defTime;

        public WaterUpMix4U(int _defVal, int _defTime, int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            defValue = _defVal;
            defTime = _defTime;
            category = "Mixtures";
            stackable = true;
            itemCount = 1;
        }
    }
}
