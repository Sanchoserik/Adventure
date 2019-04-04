using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefEarth3G : A_Talisman
    {
        public DefEarth3G(string _name)
        {
            maxEne = gEne;
            element = "earth";
            currEne = maxEne;
        }
    }
}
