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
        public void TestRemoveItemStack()
        {
            C_Hero h = new C_Hero();
            InventorySystem invSys = new InventorySystem();
            A_Item p1 = new HealP1S(1, 1);
            A_Item p2 = new HealP2M(1, 1);

            invSys.addItem(p1);
            invSys.addItem(p2);

            invSys.removeItem(p2);

            int expected = 1;
            int result = invSys.mainItemsStorage.Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestRemoveItemFromStack()
        {
            C_Hero h = new C_Hero();
            InventorySystem invSys = new InventorySystem();
            A_Item p1 = new HealP1S(1, 1);
            A_Item p2 = new HealP2M(1, 1);

            invSys.addItem(p1);
            invSys.addItem(p1);
            invSys.addItem(p1);

            invSys.addItem(p2);

            invSys.removeItem(p1);

            int expected = 2;
            int result = invSys.mainItemsStorage[0].Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestRemoveLastItemStack()
        {
            C_Hero h = new C_Hero();
            InventorySystem invSys = new InventorySystem();
            A_Item p1 = new HealP1S(1, 1);
          
            invSys.addItem(p1);
          
            invSys.removeItem(p1);

            int expected = 0;
            int result = invSys.mainItemsStorage.Count;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAddNewStackItem()
        {
            C_Hero h = new C_Hero();
            InventorySystem invSys = new InventorySystem();
            A_Item p1 = new HealP1S(1,1);
           
            invSys.addItem(p1);
                    
            int expected = 1;
            int result = invSys.mainItemsStorage.Count;
            int result2 = invSys.mainItemsStorage[0].Count;

            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected, result2);
        }

        [TestMethod]
        public void TestAddNewItemToStack()
        {
            C_Hero h = new C_Hero();
            InventorySystem invSys = new InventorySystem();
            A_Item p1 = new HealP1S(1, 1);

            invSys.addItem(p1);
            invSys.addItem(p1);
            invSys.addItem(p1);

            int expected = 1;
            int expected2 = 3;
            int result = invSys.mainItemsStorage.Count;
            int result2 = invSys.mainItemsStorage[0].Count;

            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2, result2);
        }

        [TestMethod]
        public void TestAddNewItemToRightStack()
        {
            C_Hero h = new C_Hero();
            InventorySystem invSys = new InventorySystem();
            A_Item p1 = new HealP1S(1, 1);
            A_Item p2 = new HealP2M(1, 1);

            invSys.addItem(p1);
            invSys.addItem(p1);
            invSys.addItem(p1);
            invSys.addItem(p2);
            invSys.addItem(p2);
            invSys.addItem(p2);
            invSys.addItem(p2);

            int expectedStacksCount = 2;
            int expectedFirstStackCount = 3;
            int expectedSecondStackCount = 4;

            int resultStacksCount = invSys.mainItemsStorage.Count;
            int resultFirstStackCount = invSys.mainItemsStorage[0].Count;
            int resultSecondStackCount = invSys.mainItemsStorage[1].Count;

            Assert.AreEqual(expectedStacksCount, resultStacksCount);
            Assert.AreEqual(expectedFirstStackCount, resultFirstStackCount);
            Assert.AreEqual(expectedSecondStackCount, resultSecondStackCount);
        }
    }
}
