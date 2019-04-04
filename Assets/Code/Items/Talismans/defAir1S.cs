using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefAir1S : A_Talisman
    {
        public DefAir1S(string _name)
        {
            maxEne = sEne;
            element = "air";
            currEne = maxEne;
        }
    }
}
