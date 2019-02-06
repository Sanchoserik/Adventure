using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefEarth1S : A_Talisman
    {
        public DefEarth1S(string _name)
        {
            maxEne = sEne;
            element = "earth";
            currEne = maxEne;
        }
    }
}
