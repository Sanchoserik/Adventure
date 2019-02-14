﻿using Assets.Code;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Assets.Items
{
    public abstract class A_Talisman
    {
        public int id;
        public string name;

        public int currEne;
        public int maxEne;
        public string element;

        // maxEne values
        protected int sEne = 250;
        protected int mEne = 1000;
        protected int gEne = 3000;
        protected int uEne = 6000;
        //sell prices
        public int sS = 0;
        public int sM = 0;
        public int sG = 0;
        public int sU = 0;
        //buy prices
        public int bS = 0;
        public int bM = 0;
        public int bG = 0;
        public int bU = 0;

        //move from inv to tInUSe
        public static void moveToOrder(C_Hero h, int pos, A_Talisman t)
        {
            if (h.inUseTalismansStorage[pos] == null)
            {
                h.inUseTalismansStorage[pos] = t;
                dell(h, t);
            }
            else
            {
                h.mainTalismansStorage.Add(h.mainTalismansStorage[pos]);
                h.inUseTalismansStorage[pos] = t;
                dell(h, t);
            }
            findId(h);
        }
        //move from InUse to Invertory
        public static void moveToInv(C_Hero h, int pos)
        {
                h.mainTalismansStorage.Add(h.mainTalismansStorage[pos]);
                h.inUseTalismansStorage[pos] = null;
                findId(h);                   
        }

        // tInUse1 <-> tInUse2
        public static void swapPosition(C_Hero h, int posX, int posY)
        {
            A_Talisman t = h.inUseTalismansStorage[posY];
            h.inUseTalismansStorage[posY] = h.inUseTalismansStorage[posX];
            h.inUseTalismansStorage[posX] = t;
        }
      
        //dell from inv
        public static void dell(C_Hero h, A_Talisman t)
        {
            h.mainTalismansStorage.Remove(h.mainTalismansStorage.Find(x => x.id == t.id));
            // findId's in inv
            findId(h);
        }

        //rename id in invertory
        private static void findId(C_Hero h)
        {
            for (int i = 0; i < h.mainTalismansStorage.Count; ++i)
            {
                h.mainTalismansStorage[i].id = i + 1;
            }
        }

        public static bool buy(A_Talisman talisman, C_Hero hero)
        {
            int price = 0;

            string str = talisman.GetType().Name;
            str = str.Substring(str.Length - 2, 2);

            switch (str)
            {
                case "1S": price = 800; break;
                case "2M": price = 1600; break;
                case "3G": price = 3200; break;
                case "4U": price = 6400; break;

            }
            
            if (hero.money >= price)
            {
                hero.mainTalismansStorage.Add(talisman);
                findId(hero);
                hero.money -= price;
                return true;
            }
            return false;
        }
        public static void sell(A_Talisman talisman, C_Hero hero)
        {
            int price = 0;

            string str = talisman.GetType().Name;
            str = str.Substring(str.Length - 2, 2);

            switch (str)
            {
                case "1S": price = 200; break;
                case "2M": price = 400; break;
                case "3G": price = 800; break;
                case "4U": price = 1600; break;

            }

            hero.money += price;
            dell(hero, talisman);
            findId(hero);
        }

        //re charge talisman funcs
        public static int reChargePrice(A_Talisman t, int val)
        {
             return Convert.ToInt32(val * 1.8);
        }

        public static void reCharge(A_Talisman t, int val)
        {
            t.currEne += val;
        }

    }
}
