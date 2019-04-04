using System;
using Assets.Code.Items;
using Assets.Code.Items.Potions;
using Assets.PlayerController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureUnitTest
{
    [TestClass]
    public class InventoryTest
    {
        [TestMethod]
        public void TestAddItem()
        {
            C_Hero h = new C_Hero(); 
            InventorySystem invSys  = new InventorySystem();
            A_Item p1 = new HealP1S("smalHPPot", h);
                      
            string result = invSys.addItem(p1);
            string expected = "HealP1S";

            Assert.AreEqual(expected, result);
        }
    }
}
