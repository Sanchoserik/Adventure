using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Adventure.Items.Talismans
{
    class defAir3G : A_Talisman
    {
        public defAir3G(string _name)
        {
            maxEne = gEne;
            element = "air";
            currEne = maxEne;
        }
    }
}
