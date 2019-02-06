using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefWater3G : A_Talisman
    {
        public DefWater3G(string _name)
        {
            maxEne = gEne;
            element = "water";
            currEne = maxEne;
        }
    }
}
