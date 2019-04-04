using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefWater2M : A_Talisman
    {
        public DefWater2M(string _name)
        {
            maxEne = mEne;
            element = "water";
            currEne = maxEne;
        }
    }
}
