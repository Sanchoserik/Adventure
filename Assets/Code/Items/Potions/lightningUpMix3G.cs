using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    public class LightningUpMix3G : A_Item
    {
        public int defValue;
        public int defTime;

        public LightningUpMix3G(int _defVal, int _defTime, int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            defValue = _defVal;
            defTime = _defTime;
            category = "Mixtures";
            stackable = true;
            itemCount = 1;
        }

    }
}
