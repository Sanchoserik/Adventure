using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defLightning1S : A_Talisman
    {
        public defLightning1S(string _name)
        {
            maxEne = sEne;
            element = "lightning";
            currEne = maxEne;
        }
    }
}
