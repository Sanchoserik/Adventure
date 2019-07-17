using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefLightning2M : A_Item
    {
        int maxEne;
        int currentEne;
        string element;

        public DefLightning2M(int _maxEne, int _currentEne, int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "lightning";
            maxEne = _maxEne;
            currentEne = _currentEne;
        }
    }
}
