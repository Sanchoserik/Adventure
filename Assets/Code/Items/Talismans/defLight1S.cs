﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class defLight1S : A_Talisman
    {
        public defLight1S(string _name)
        {
            maxEne = sEne;
            element = "light";
            currEne = maxEne;
        }
    }
}
