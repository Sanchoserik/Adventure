using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class defAir1S : A_Talisman
    {
        public defAir1S(string _name)
        {
            maxEne = sEne;
            element = "air";
            currEne = maxEne;
        }
    }
}
