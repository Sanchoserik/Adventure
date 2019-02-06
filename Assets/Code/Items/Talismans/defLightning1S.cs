using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefLightning1S : A_Talisman
    {
        public DefLightning1S(string _name)
        {
            maxEne = sEne;
            element = "lightning";
            currEne = maxEne;
        }
    }
}
