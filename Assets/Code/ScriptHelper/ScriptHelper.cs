using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Items;

namespace Adventure.ScriptHelper
{
    public static class ScriptHelper
    {
        //select talisman from in use
        public static A_Talisman getTalismanInUse(C_Hero h, int _id)
        {
            return h.in_useTalismans.Find(x => x.id == _id);
        }


    }
}
