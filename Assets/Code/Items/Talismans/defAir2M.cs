using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class defAir2M : A_Talisman
    {
        public defAir2M(string _name)
        {
            maxEne = mEne;
            element = "air";
            currEne = maxEne;
        }
    }
}
