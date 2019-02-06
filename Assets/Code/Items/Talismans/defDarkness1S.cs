using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefDarkness1S : A_Talisman
    {
        public DefDarkness1S(string _name)
        {
            maxEne = sEne;
            element = "darkness";
            currEne = maxEne;
        }
    }
}
