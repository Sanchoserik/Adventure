using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefDarkness1S : A_Item
    {
        int maxEne;
        int currentEne;
        string element;

        public DefDarkness1S(int _maxEne, int _currentEne, int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "darkness";
            maxEne = _maxEne;
            currentEne = _currentEne;
        }
    }
}
