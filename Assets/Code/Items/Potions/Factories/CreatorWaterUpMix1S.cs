using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Items.Potions.Factories
{
    public class CreatorWaterUpMix1S : IItemFactory
    {
        public A_Item createItem(ItemsData itemData) => new WaterUpMix1S(Convert.ToInt32(itemData.itemsParameters["val"]),
           Convert.ToInt32(itemData.itemsParameters["time"]), Convert.ToInt32(itemData.itemsParameters["buyPrice"]),
           Convert.ToInt32(itemData.itemsParameters["sellPrice"]));
    }
}
