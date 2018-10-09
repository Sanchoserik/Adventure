using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Adventure.Effects
{
    class physUp : A_Effect
    {
        public int upValue;

        public physUp(int _val, int _time, C_Hero h)
        {
            upValue = _val;
            time = _time;
            id = returnFreeId(h);
        }

        public override void addToEffStack(C_Hero h)
        {
            throw new NotImplementedException();
        }

        public override void addToEffStack()
        {
            throw new NotImplementedException();
        }
    }
}
