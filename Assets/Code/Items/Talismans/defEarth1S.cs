﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefEarth1S : A_Item
    {
        int maxEne;
        int currentEne;
        string element;

        public DefEarth1S(int _maxEne,   int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "earth";
            maxEne = _maxEne;
            currentEne = maxEne;
        }
    }
}
