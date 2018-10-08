using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items.Talismans
{
    class defFire2M : A_Talisman
    {
        public defFire2M(string _name)
        {
            maxEne = mEne;
            element = "fire";
            currEne = maxEne;
        }
    }
}
