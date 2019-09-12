using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Items.Talismans
{
    public class DefPhys2M : A_Item
    {
        public int baseMaxEne;
        public int totalMaxEne;
        public int currentEne;
        public string element;

        public DefPhys2M(int _maxEne, int _buyPrice, int _sellPrice) : base(_buyPrice, _sellPrice)
        {
            element = "phys";
            baseMaxEne = _maxEne;
            category = "Talismans";
            totalMaxEne = HeroAttributesController.talismanTotalEnergy(this);
            currentEne = totalMaxEne;
            stackable = false;
        }
    }
}
