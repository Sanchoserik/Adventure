using Assets.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Effects
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

        //add this to hero effectsStorage
        public override void addToEffStack(C_Hero h)
        {
            h.effectsStorage.Add(this);
        }

        //
        public override void addToEffStack()
        {
            throw new NotImplementedException();
        }
    }
}
