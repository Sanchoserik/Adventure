using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class DefLightning2M : A_Talisman
    {
        public DefLightning2M(string _name)
        {
            maxEne = mEne;
            element = "lightning";
            currEne = maxEne;
        }
    }
}
