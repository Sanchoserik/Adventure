using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefDarkness3G : A_Talisman
    {
        public DefDarkness3G(string _name)
        {
            maxEne = gEne;
            element = "darkness";
            currEne = maxEne;
        }
    }
}
