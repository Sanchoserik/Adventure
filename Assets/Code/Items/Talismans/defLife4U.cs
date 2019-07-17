using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefLife4U : A_Item
    {
        int maxEne;
        int currentEne;
        string element;

        public DefLife4U(int _maxEne,   int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "life";
            maxEne = _maxEne;
            currentEne = maxEne;
        }
    }
}
