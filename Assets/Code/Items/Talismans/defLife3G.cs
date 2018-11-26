using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class defLife3G : A_Talisman
    {
        public defLife3G(string _name)
        {
            maxEne = gEne;
            element = "life";
            currEne = maxEne;
        }
    }
}
