using Assets.Code;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Items
{
    public abstract class A_Item
    {
        public int id; // for yet unknown reasons 
        public string category;
        public int price;

        public A_Item()
        {

        }

        public A_Item(int _price)
        {
            price = _price;
        }
    }
}
