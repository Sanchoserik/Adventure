using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Effects
{
    class lightUp : A_Effect
    {
        public int upValue;

        public lightUp(int _val, int _time, C_Hero h)
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
