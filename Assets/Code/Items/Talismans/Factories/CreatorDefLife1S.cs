using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Items.Talismans.Factories
{
    public class CreatorDefLife1S : IItemFactory
    {
        public A_Item createItem(ItemsData itemData) => new DefLife1S(
          Convert.ToInt32(itemData.itemsParameters["maxEne"]),
          Convert.ToInt32(itemData.itemsParameters["buyPrice"]),
          Convert.ToInt32(itemData.itemsParameters["sellPrice"]));
    }
}
