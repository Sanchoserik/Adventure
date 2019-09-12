using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefAir3G : A_Item
    {
        public int baseMaxEne;
        public int totalMaxEne;
        public int currentEne;
        public string element;

        public DefAir3G(int _maxEne,   int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "air";
            baseMaxEne = _maxEne;
            category = "Talismans";
            totalMaxEne = HeroAttributesController.talismanTotalEnergy(this);
            currentEne = totalMaxEne;
            stackable = false;
        }
    }
}
