using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defLife2M : A_Talisman
    {
        public defLife2M(string _name)
        {
            maxEne = mEne;
            element = "life";
            currEne = maxEne;
        }
    }
}
