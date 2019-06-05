using Assets.Code;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Potions
{
    public class EneP1S : A_Item
    {      
        public int restorenValue;
      
        public EneP1S(int _restorenValue, int _price) : base(_price)
        {
            restorenValue = _restorenValue;         
            category = "Potions";
        }
    }
}
