using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefDarkness4U : A_Talisman
    {
        public DefDarkness4U(string _name)
        {
            maxEne = uEne;
            element = "darkness";
            currEne = maxEne;
        }
    }
}
