using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defFire3G : A_Talisman
    {
        public defFire3G(string _name)
        {
            maxEne = gEne;
            element = "fire";
            currEne = maxEne;
        }
    }
}
