﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Adventure.Items.Talismans
{
    class defLife4U : A_Talisman
    {
        public defLife4U(string _name)
        {
            maxEne = uEne;
            element = "life";
            currEne = maxEne;
        }
    }
}
