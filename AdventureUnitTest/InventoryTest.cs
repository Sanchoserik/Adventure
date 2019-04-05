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
        public void TestRemoveItem()
        {
            C_Hero h = new C_Hero();
            InventorySystem invSys = new InventorySystem();
            A_Item p1 = new HealP1S("smalHPPot");
            A_Item p2 = new HealP2M("medHPPot");

            invSys.addItem(p1);
            invSys.addItem(p2);

            invSys.removeItem(p2);

            int expected = 1;
            int result = invSys.mainItemsStorage.Count;

            Assert.AreEqual(expected, result);
        }



        //tests passed
        //for test set InvertorySystem.checkStacks function as public
        //[TestMethod]
        //public void TestAddItem1()
        //{
        //    C_Hero h = new C_Hero(); 
        //    InventorySystem invSys  = new InventorySystem();
        //    A_Item p1 = new HealP1S("smalHPPot", h);

        //    bool expected = false;
        //    bool result = invSys.checkStacks(p1.GetType().Name);

        //    Assert.AreEqual(expected, result);
        //}

        //[TestMethod]
        //public void TestAddItem2()
        //{
        //    C_Hero h = new C_Hero();
        //    InventorySystem invSys = new InventorySystem();
        //    A_Item p1 = new HealP1S("smalHPPot", h);

        //    invSys.addItem(p1);

        //    bool expected = true;
        //    bool result = invSys.checkStacks(p1.GetType().Name);

        //    Assert.AreEqual(expected, result);
        //}
    }
}
