﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Adventure.Items.Talismans
{
    class defEarth1S : A_Talisman
    {
        public defEarth1S(string _name)
        {
            maxEne = sEne;
            element = "earth";
            currEne = maxEne;
        }
    }
}
