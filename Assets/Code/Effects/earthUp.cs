﻿using Assets.Code;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Effects
{
    class EarthUp : A_Effect
    {
        public int upValue;

        public EarthUp(int _val, int _time, C_Hero h)
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
