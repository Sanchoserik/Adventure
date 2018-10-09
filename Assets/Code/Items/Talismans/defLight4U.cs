using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Adventure.Items.Talismans
{
    class defLight4U : A_Talisman
    {
        public defLight4U(string _name)
        {
            maxEne = uEne;
            element = "light";
            currEne = maxEne;
        }
    }
}
