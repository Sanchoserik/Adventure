using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defEarth2M : A_Talisman
    {
        public defEarth2M(string _name)
        {
            maxEne = mEne;
            element = "earth";
            currEne = maxEne;
        }
    }
}
