using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Adventure.Items.Talismans
{
    class defWater4U : A_Talisman
    {
        public defWater4U(string _name)
        {
            maxEne = uEne;
            element = "water";
            currEne = maxEne;
        }
    }
}
