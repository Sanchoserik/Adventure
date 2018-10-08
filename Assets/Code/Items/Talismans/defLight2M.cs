using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defLight2M : A_Talisman
    {
        public defLight2M(string _name)
        {
            maxEne = mEne;
            element = "light";
            currEne = maxEne;
        }
    }
}
