using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Items
{
    public interface IItemFactory
    {
        A_Item createItem(ItemsData itemData);
    }
}
