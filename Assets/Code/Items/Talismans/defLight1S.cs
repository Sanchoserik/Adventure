using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefLight1S : A_Talisman
    {
        public DefLight1S(string _name)
        {
            maxEne = sEne;
            element = "light";
            currEne = maxEne;
        }
    }
}
