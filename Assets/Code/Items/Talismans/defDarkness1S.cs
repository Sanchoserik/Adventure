﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Adventure.Items.Talismans
{
    class defDarkness1S : A_Talisman
    {
        public defDarkness1S(string _name)
        {
            maxEne = sEne;
            element = "darkness";
            currEne = maxEne;
        }
    }
}
