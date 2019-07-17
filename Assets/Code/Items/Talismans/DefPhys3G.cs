using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Items.Talismans
{
    public class DefPhys3G : A_Item
    {
        int maxEne;
        int currentEne;
        string element;

        public DefPhys3G(int _maxEne, int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "phys";
            maxEne = _maxEne;
            currentEne = maxEne;
        }
    }
}
