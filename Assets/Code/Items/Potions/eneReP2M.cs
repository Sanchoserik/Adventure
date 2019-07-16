using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    public class EneReP2M : A_Item
    {
        public int regenerationValue;
        public int defTime;

        public EneReP2M(int _regenerationValue, int _defTime, int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            regenerationValue = _regenerationValue;
            defTime = _defTime;
            category = "Potions";
        }
    }
}
