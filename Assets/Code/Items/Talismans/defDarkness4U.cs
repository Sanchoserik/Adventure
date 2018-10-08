using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defDarkness4U : A_Talisman
    {
        public defDarkness4U(string _name)
        {
            maxEne = uEne;
            element = "darkness";
            currEne = maxEne;
        }
    }
}
