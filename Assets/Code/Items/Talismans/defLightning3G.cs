using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefLightning3G : A_Talisman
    {
        public DefLightning3G(string _name)
        {
            maxEne = gEne;
            element = "lightning";
            currEne = maxEne;
        }
    }
}
