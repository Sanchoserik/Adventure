﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    public class LightUpMix2M : A_Item
    {
        public int defValue;
        public int defTime;

        public LightUpMix2M(int _defVal, int _defTime, int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            defValue = _defVal;
            defTime = _defTime;
            category = "Mixtures";
            stackable = true;
            itemCount = 1;
        }


    }
}
