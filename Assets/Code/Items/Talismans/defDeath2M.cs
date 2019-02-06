using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefDeath2M : A_Talisman
    {
        public DefDeath2M(string _name)
        {
            maxEne = mEne ;
            element = "death";
            currEne = maxEne;
        }
    }
}
