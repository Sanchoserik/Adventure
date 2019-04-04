using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefLight4U : A_Talisman
    {
        public DefLight4U(string _name)
        {
            maxEne = uEne;
            element = "light";
            currEne = maxEne;
        }
    }
}
