using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class defDeath4U : A_Talisman
    {
        public defDeath4U(string _name)
        {
            maxEne = uEne;
            element = "death";
            currEne = maxEne;
        }
    }
}
