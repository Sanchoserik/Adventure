﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Adventure.Items.Talismans
{
    class defWater2M : A_Talisman
    {
        public defWater2M(string _name)
        {
            maxEne = mEne;
            element = "water";
            currEne = maxEne;
        }
    }
}
