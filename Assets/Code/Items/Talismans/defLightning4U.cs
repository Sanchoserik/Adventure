using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    class DefLightning4U : A_Talisman
    {
        public DefLightning4U(string _name)
        {
            maxEne = uEne;
            element = "lightning";
            currEne = maxEne;
        }
    }
}
