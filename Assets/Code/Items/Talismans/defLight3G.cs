﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefLight3G : A_Item
    {
        int maxEne;
        int currentEne;
        string element;

        public DefLight3G(int _maxEne, int _currentEne, int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "light";
            maxEne = _maxEne;
            currentEne = _currentEne;
        }
    }
}
