﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items.Talismans
{
    class defEarth4U : A_Talisman
    {
        public defEarth4U(string _name)
        {
            maxEne = uEne;
            element = "earth";
            currEne = maxEne;
        }
    }
}
