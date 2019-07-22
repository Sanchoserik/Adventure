using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefAir1S : A_Item
    {
        int maxEne;
        int currentEne;
        string element;

        public DefAir1S(int _maxEne,   int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "air";
            maxEne = _maxEne;
            currentEne = maxEne;
            category = "Talismans";
        }
    }
}
