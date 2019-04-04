using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefLife4U : A_Talisman
    {
        public DefLife4U(string _name)
        {
            maxEne = uEne;
            element = "life";
            currEne = maxEne;
        }
    }
}
