﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Adventure.Items.Talismans
{
    class defDeath1S : A_Talisman
    {
        public defDeath1S(string _name)
        {
            maxEne = sEne ;
            element = "death";
            currEne = maxEne;
        }
    }
}
