using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Adventure.Items.Talismans
{
    class defWater3G : A_Talisman
    {
        public defWater3G(string _name)
        {
            maxEne = gEne;
            element = "water";
            currEne = maxEne;
        }
    }
}
