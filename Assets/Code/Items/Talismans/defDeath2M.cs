using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefDeath2M : A_Item
    {
        int maxEne;
        int currentEne;
        string element;

        public DefDeath2M(int _maxEne, int _currentEne, int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "death";
            maxEne = _maxEne;
            currentEne = _currentEne;
        }
    }
}
