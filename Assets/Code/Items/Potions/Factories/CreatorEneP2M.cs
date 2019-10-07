using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Items.Potions.Factories
{
    public class CreatorEneP2M : IItemFactory
    {
        public A_Item createItem(ItemsData itemData) => new EneP2M(Convert.ToInt32(itemData.itemsParameters["val"]),
           Convert.ToInt32(itemData.itemsParameters["buyPrice"]),
           Convert.ToInt32(itemData.itemsParameters["sellPrice"]));
    }
}
