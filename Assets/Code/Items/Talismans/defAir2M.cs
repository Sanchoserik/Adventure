using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefAir2M : A_Talisman
    {
        public DefAir2M(string _name)
        {
            maxEne = mEne;
            element = "air";
            currEne = maxEne;
        }
    }
}
