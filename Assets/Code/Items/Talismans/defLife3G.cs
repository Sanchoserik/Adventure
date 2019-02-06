using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefLife3G : A_Talisman
    {
        public DefLife3G(string _name)
        {
            maxEne = gEne;
            element = "life";
            currEne = maxEne;
        }
    }
}
