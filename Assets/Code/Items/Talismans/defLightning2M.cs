﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Adventure.Items.Talismans
{
    class defLightning2M : A_Talisman
    {
        public defLightning2M(string _name)
        {
            maxEne = mEne;
            element = "lightning";
            currEne = maxEne;
        }
    }
}
