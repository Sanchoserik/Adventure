using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defEarth3G : A_Talisman
    {
        public defEarth3G(string _name)
        {
            maxEne = gEne;
            element = "earth";
            currEne = maxEne;
        }
    }
}
