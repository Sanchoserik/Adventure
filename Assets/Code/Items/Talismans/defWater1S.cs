using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefWater1S : A_Talisman
    {
        public DefWater1S(string _name)
        {
            maxEne = sEne;
            element = "water";
            currEne = maxEne;
        }
    }
}
