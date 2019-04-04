using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefEarth4U : A_Talisman
    {
        public DefEarth4U(string _name)
        {
            maxEne = uEne;
            element = "earth";
            currEne = maxEne;
        }
    }
}
