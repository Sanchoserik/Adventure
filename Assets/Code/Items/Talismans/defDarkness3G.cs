using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class defDarkness3G : A_Talisman
    {
        public defDarkness3G(string _name)
        {
            maxEne = gEne;
            element = "darkness";
            currEne = maxEne;
        }
    }
}
