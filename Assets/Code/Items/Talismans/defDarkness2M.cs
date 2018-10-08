using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defDarkness2M : A_Talisman
    {
        public defDarkness2M(string _name)
        {
            maxEne = mEne;
            element = "darkness";
            currEne = maxEne;
        }
    }
}
