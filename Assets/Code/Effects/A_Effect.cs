using Assets.Code;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assets.Effects
{
    public abstract class A_Effect
    {
        public int id;
        public int time;

        //add concrette eff to stack in hero 
        public abstract void addToEffStack(C_Hero h);

        //monster eff
        public abstract void addToEffStack();
        //
        public void calculateEff(C_Hero h)
        { }

        //remove from stack by id
        public void removeEff(C_Hero h, int id)
        {
            h.effectsStorage.Remove(h.effectsStorage.Find(x => x.id == id));
        }

        //id operations
        private void fidId(C_Hero h)
        {
            for (int i = 0; i < h.effectsStorage.Count; ++i)
            {
                h.effectsStorage[i].id = i + 1;
            }
        }
        protected static int returnFreeId(C_Hero h)
        {
            if (h.effectsStorage.Count != 0)
            {
                return h.effectsStorage.Count;
            }
            else
                return 1;
        }
    }
}
