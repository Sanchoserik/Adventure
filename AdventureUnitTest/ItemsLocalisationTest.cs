using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Assets.Code.SystemScripts;
using Assets.Code.SystemScripts.LocalisationScripts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureUnitTest
{
    [TestClass]
    public class ItemsLocalisationTest
    {
        [TestMethod]
        public void itemsLocalisationLoadTest()
        {
            List<ItemsLocalisationData> _data = new List<ItemsLocalisationData>();

            IEnumerable<XElement> items; // <item> tag  
            XDocument xDoc = XDocument.Load("F:/UnityProjects/Adventure/Assets/Resources/xml/items/ItemsLocUA.xml");

            items = xDoc.Descendants("items").Elements();

            foreach (XElement item in items)
            {
                string itemName = item.Attribute("name").Value.Trim();
                string itemLocName = item.Element("LocName").Value;
                string itemLocDesc = item.Element("LocDescr").Value;

                _data.Add(new ItemsLocalisationData(itemName, itemLocName, itemLocDesc));
            }

            Assert.AreEqual("HealP1S", _data[0].itemName);
            Assert.AreEqual("Мале зілля зцілення", _data[0].itemLocalisedName);
            Assert.AreEqual("Відновлює  $val$% здоров'я.", _data[0].itemLocalisedDescription);         
        }
    }
}
