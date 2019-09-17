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
            talismanCalculateMaxPower();
            currentEne = totalMaxEne;
            stackable = false;
        }

        public override string talismanGetPower()
        {
           return totalMaxEne.ToString();
        }

        public override void talismanCalculateMaxPower()
        {
            totalMaxEne = baseMaxEne + HeroController.mainHero.bonusTalismanPower
                + (baseMaxEne + HeroController.mainHero.bonusTalismanPower) * HeroController.mainHero.bonusTalismanPowerPercent / 100;
        }

    }
}
