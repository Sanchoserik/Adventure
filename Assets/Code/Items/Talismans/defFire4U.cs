using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defFire4U : A_Talisman
    {
        public defFire4U(string _name)
        {
            maxEne = uEne;
            element = "fire";
            currEne = maxEne;
        }
    }
}
