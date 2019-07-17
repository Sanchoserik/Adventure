using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefDarkness3G : A_Item
    {
        int maxEne;
        int currentEne;
        string element;

        public DefDarkness3G(int _maxEne,   int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "darkness";
            maxEne = _maxEne;
            currentEne = maxEne;
        }
    }
}
