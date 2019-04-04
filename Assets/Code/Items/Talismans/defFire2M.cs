using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefFire2M : A_Talisman
    {
        public DefFire2M(string _name)
        {
            maxEne = mEne;
            element = "fire";
            currEne = maxEne;
        }
    }
}
