using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defAir4U : A_Talisman
    {
        public defAir4U(string _name)
        {
            maxEne = uEne;
            element = "air";
            currEne = maxEne;
        }
    }
}
