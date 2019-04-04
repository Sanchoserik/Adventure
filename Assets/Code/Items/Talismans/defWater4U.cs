using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefWater4U : A_Talisman
    {
        public DefWater4U(string _name)
        {
            maxEne = uEne;
            element = "water";
            currEne = maxEne;
        }
    }
}
