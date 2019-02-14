﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code;
using Assets.Items;
using Assets.PlayerController;

namespace Assets.ScriptHelper
{
    public static class ScriptHelper
    {
        //select talisman from in use
        public static A_Talisman getTalismanInUse(C_Hero h, int _id)
        {
            return h.inUseTalismansStorage.Find(x => x.id == _id);
        }


    }
}
