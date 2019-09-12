using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Code.Items.Talismans
{
    public class DefLightning1S : A_Item
    {
        public int baseMaxEne;
        public int totalMaxEne;
        public int currentEne;
        public string element;

        public DefLightning1S(int _maxEne,   int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "lightning";
            baseMaxEne = _maxEne;
            category = "Talismans";
            totalMaxEne = HeroAttributesController.talismanTotalEnergy(this);
            currentEne = totalMaxEne;
            stackable = false;
        }
    }
}
