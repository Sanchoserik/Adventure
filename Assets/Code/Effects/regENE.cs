using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Effects
{
    class regENE : A_Effect
    {
        public int regValue;

        public regENE(int _val, int _time, C_Hero h)
        {
            regValue = _val;
            time = _time;
            id = returnFreeId(h);
        }

        //add this to hero eff_stack
        public override void addToEffStack(C_Hero h)
        {
            h.eff_stack.Add(this);
        }

        //
        public override void addToEffStack()
        {
            throw new NotImplementedException();
        }
    }
}
