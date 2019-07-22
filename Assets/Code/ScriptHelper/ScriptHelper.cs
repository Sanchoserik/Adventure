using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Code.Items;
using Assets.PlayerController;

namespace Assets.ScriptHelper
{
    public static class ScriptHelper
    {
        //select talisman from in use
        public static A_Item getTalismanInUse(C_Hero h, int _id)
        {
            return h.inventorySystem.inUseTalismansStorage.Find(x => x.id == _id);
        }


    }
}
