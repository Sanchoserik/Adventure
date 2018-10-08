using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defLife1S : A_Talisman
    {
        public defLife1S(string _name)
        {
            maxEne = sEne;
            element = "life";
            currEne = maxEne;
        }
    }
}
