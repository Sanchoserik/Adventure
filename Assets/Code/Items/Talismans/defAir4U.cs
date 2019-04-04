using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefAir4U : A_Talisman
    {
        public DefAir4U(string _name)
        {
            maxEne = uEne;
            element = "air";
            currEne = maxEne;
        }
    }
}
