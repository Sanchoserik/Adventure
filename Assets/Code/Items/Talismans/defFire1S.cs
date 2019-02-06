using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefFire1S : A_Talisman
    {
        public DefFire1S(string _name)
        {
            maxEne = sEne;
            element = "fire";
            currEne = maxEne;
        }
    }
}
