using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defFire1S : A_Talisman
    {
        public defFire1S(string _name)
        {
            maxEne = sEne;
            element = "fire";
            currEne = maxEne;
        }
    }
}
