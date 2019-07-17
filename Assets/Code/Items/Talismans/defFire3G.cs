using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefFire3G : A_Item
    {
        int maxEne;
        int currentEne;
        string element;

        public DefFire3G(int _maxEne,   int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "fire";
            maxEne = _maxEne;
            currentEne = maxEne;
        }
    }
}
