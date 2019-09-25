using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Assets.Code.SystemScripts.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureUnitTest.xmlLoadingTests
{
    [TestClass]
    public class xmlLoadingTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string monstersParemetersPath = "F:/UnityProjects/Adventure/Assets/Resources/xml/monsters/monsters.xml";
            List<MonstersData> mData = new List<MonstersData>();

            IEnumerable<XElement> monsters; // <item> tag  
            XDocument xDoc = XDocument.Load(monstersParemetersPath);

            monsters = xDoc.Descendants("monsters").Elements(); ;
            foreach (XElement monster in monsters)
            {
                if (monster.Nodes() != null)
                {
                    string mName = monster.Attribute("name").Value;
                    Dictionary<string, string> monsterParameters = new Dictionary<string, string>();
                    List<string> monsterActions = new List<string>();

                    foreach (XElement valTag in monster.Nodes())
                    {
                        if (valTag.Attribute("name").Value.Equals("actions"))
                        {
                            foreach (XElement action in valTag.Nodes())
                            {
                                monsterActions.Add(action.Value);
                            }
                        }
                        else
                            monsterParameters.Add(valTag.Attribute("name").Value, valTag.Value);

                    }

                    MonstersData monsterData = new MonstersData();
                    monsterData.monsterName = mName;
                    monsterData.monsterParameters = monsterParameters;
                    monsterData.monsterActionsList = monsterActions;

                    mData.Add(monsterData);
                }
            }
            Assert.AreEqual("simpleAttack", mData[0].monsterActionsList[0]);
            Assert.AreEqual("smallRandomDefCurse", mData[9].monsterActionsList[4]);
        }
    }
}
