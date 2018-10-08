using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defLight3G : A_Talisman
    {
        public defLight3G(string _name)
        {
            maxEne = gEne;
            element = "light";
            currEne = maxEne;
        }
    }
}
