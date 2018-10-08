using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defDeath3G : A_Talisman
    {
        public defDeath3G(string _name)
        {
            maxEne = gEne;
            element = "death";
            currEne = maxEne;
        }
    }
}
