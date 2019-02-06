using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefFire3G : A_Talisman
    {
        public DefFire3G(string _name)
        {
            maxEne = gEne;
            element = "fire";
            currEne = maxEne;
        }
    }
}
