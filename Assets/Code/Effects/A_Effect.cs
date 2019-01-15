using Assets.Code;
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
            h.eff_stack.Remove(h.eff_stack.Find(x => x.id == id));
        }

        //id operations
        private void fidId(C_Hero h)
        {
            for (int i = 0; i < h.eff_stack.Count; ++i)
            {
                h.eff_stack[i].id = i + 1;
            }
        }
        protected static int returnFreeId(C_Hero h)
        {
            if (h.eff_stack.Count != 0)
            {
                return h.eff_stack.Count;
            }
            else
                return 1;
        }
    }
}
