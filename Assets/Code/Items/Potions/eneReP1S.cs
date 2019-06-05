using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Effects;
using Assets.PlayerController;

namespace Assets.Code.Items.Potions
{
    public class EneReP1S : A_Item
    {
        public int regenerationValue;
        public int defTime;

        public EneReP1S(int _regenerationValue, int _defTime, int _price) : base(_price)
        {
            regenerationValue = _regenerationValue;
            defTime = _defTime;
            category = "Potions";
        }
    }
}
