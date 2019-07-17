using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefAir4U : A_Item
    {
        int maxEne;
        int currentEne;
        string element;

        public DefAir4U(int _maxEne, int _currentEne, int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "air";
            maxEne = _maxEne;
            currentEne = _currentEne;
        }
    }
}
