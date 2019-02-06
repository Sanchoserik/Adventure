using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefLife2M : A_Talisman
    {
        public DefLife2M(string _name)
        {
            maxEne = mEne;
            element = "life";
            currEne = maxEne;
        }
    }
}
