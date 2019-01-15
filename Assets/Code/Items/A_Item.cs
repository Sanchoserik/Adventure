using Assets.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Items
{
    public abstract class A_Item
    {
        public int id;
        public string name;

        public abstract void use(C_Hero h);

        public static void dell(List<A_Item> items, int _id)
        {
            items.Remove(items.Find(x => x.id == _id));
        }

        public static bool buy(A_Item item, C_Hero hero)
        {
            int price = 0;

            switch (item.GetType().Name)
            {
                case "healP1S": price = 125; break;
                case "healP2M": price = 250; break;
                case "healP3G": price = 500; break;
                case "healP4U": price = 1000; break;

                case "healReP1S": price = 500; break;
                case "healReP2M": price = 1000; break;
                case "healReP3G": price = 2000; break;
                case "healReP4U": price = 4000; break;

                case "eneP1S": price = 200; break;
                case "eneP2M": price = 400; break;
                case "eneP3G": price = 800; break;
                case "eneP4U": price = 1600; break;

                case "eneReP1S": price = 500; break;
                case "eneReP2M": price = 1000; break;
                case "eneReP3G": price = 2000; break;
                case "eneReP4U": price = 4000; break;

            }

            if (price == 0)
            {
                string str = item.GetType().Name;
                str = str.Substring(str.Length - 2, 2);

                switch (str)
                {
                    case "1S": price = 200; break;
                    case "2M": price = 400; break;
                    case "3G": price = 800; break;
                    case "4U": price = 1600; break;
                }
            }

            if (hero.money >= price)
            {
                hero.inv_items.Add(item);
                findid(hero);
                hero.money -= price;
                return true;
            }
            return false;
        }

        public static void sell(A_Item item, C_Hero hero)
        {
            int price = 0;
            switch (item.GetType().Name)
            {
                case "healP1S": price = 31; break;
                case "healP2M": price = 62; break;
                case "healP3G": price = 125; break;
                case "healP4U": price = 250; break;

                case "healReP1S": price = 125; break;
                case "healReP2M": price = 250; break;
                case "healReP3G": price = 500; break;
                case "healReP4U": price = 1000; break;

                case "eneP1S": price = 50; break;
                case "eneP2M": price = 100; break;
                case "eneP3G": price = 200; break;
                case "eneP4U": price = 400; break;

                case "eneReP1S": price = 125; break;
                case "eneReP2M": price = 250; break;
                case "eneReP3G": price = 500; break;
                case "eneReP4U": price = 1000; break;

            }

            if (price == 0)
            {
                string str = item.GetType().Name;
                str = str.Substring(str.Length - 2, 2);

                switch (str)
                {
                    case "1S": price = 200; break;
                    case "2M": price = 400; break;
                    case "3G": price = 800; break;
                    case "4U": price = 1600; break;
                }
            }

            hero.money += price;
            dell(hero.inv_items, item.id);
            findid(hero);
        }

        //id funcs
        public static void findid(C_Hero h)
        {
            for (int i = 0; i < h.inv_items.Count; ++i)
            {
                h.inv_items[i].id = i + 1;
            }
            
        }

        protected int returnFreeId(C_Hero h)
        {
            if (h.inv_items.Count != 0)
            {
                return h.inv_items.Count;
            }
            else
                return 1;
        }
    }
}
