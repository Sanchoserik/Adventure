using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefFire4U : A_Talisman
    {
        public DefFire4U(string _name)
        {
            maxEne = uEne;
            element = "fire";
            currEne = maxEne;
        }
    }
}
