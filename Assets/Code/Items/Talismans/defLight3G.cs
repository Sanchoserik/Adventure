using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefLight3G : A_Talisman
    {
        public DefLight3G(string _name)
        {
            maxEne = gEne;
            element = "light";
            currEne = maxEne;
        }
    }
}
