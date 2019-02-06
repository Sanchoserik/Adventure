using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefDeath3G : A_Talisman
    {
        public DefDeath3G(string _name)
        {
            maxEne = gEne;
            element = "death";
            currEne = maxEne;
        }
    }
}
