using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defLightning3G : A_Talisman
    {
        public defLightning3G(string _name)
        {
            maxEne = gEne;
            element = "lightning";
            currEne = maxEne;
        }
    }
}
