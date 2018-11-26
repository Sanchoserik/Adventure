using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class defDeath2M : A_Talisman
    {
        public defDeath2M(string _name)
        {
            maxEne = mEne ;
            element = "death";
            currEne = maxEne;
        }
    }
}
