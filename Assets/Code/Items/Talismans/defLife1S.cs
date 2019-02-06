using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefLife1S : A_Talisman
    {
        public DefLife1S(string _name)
        {
            maxEne = sEne;
            element = "life";
            currEne = maxEne;
        }
    }
}
