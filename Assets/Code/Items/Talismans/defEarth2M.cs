using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefEarth2M : A_Talisman
    {
        public DefEarth2M(string _name)
        {
            maxEne = mEne;
            element = "earth";
            currEne = maxEne;
        }
    }
}
