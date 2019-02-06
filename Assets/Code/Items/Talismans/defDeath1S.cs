using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefDeath1S : A_Talisman
    {
        public DefDeath1S(string _name)
        {
            maxEne = sEne ;
            element = "death";
            currEne = maxEne;
        }
    }
}
