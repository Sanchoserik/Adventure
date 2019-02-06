using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefLight2M : A_Talisman
    {
        public DefLight2M(string _name)
        {
            maxEne = mEne;
            element = "light";
            currEne = maxEne;
        }
    }
}
