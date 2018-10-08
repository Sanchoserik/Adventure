using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defLightning4U : A_Talisman
    {
        public defLightning4U(string _name)
        {
            maxEne = uEne;
            element = "lightning";
            currEne = maxEne;
        }
    }
}
