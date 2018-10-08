using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defWater1S : A_Talisman
    {
        public defWater1S(string _name)
        {
            maxEne = sEne;
            element = "water";
            currEne = maxEne;
        }
    }
}
