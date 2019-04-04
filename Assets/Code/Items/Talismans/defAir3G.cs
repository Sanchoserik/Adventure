using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefAir3G : A_Talisman
    {
        public DefAir3G(string _name)
        {
            maxEne = gEne;
            element = "air";
            currEne = maxEne;
        }
    }
}
