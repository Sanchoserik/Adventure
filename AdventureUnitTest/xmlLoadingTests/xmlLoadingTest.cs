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
            string monsterActionsPath = "F:/UnityProjects/Adventure/Assets/Resources/xml/monsters/actions.xml";
            List<MonsterActionsData> actionsData = new List<MonsterActionsData>();

            IEnumerable<XElement> monsterActions; // <item> tag  
            XDocument xDoc = XDocument.Load(monsterActionsPath);

            monsterActions = xDoc.Descendants("actions").Elements();
            foreach (XElement action in monsterActions)
            {
                if (action.Nodes() != null)
                {
                    string actionName = action.Attribute("name").Value;
                    Dictionary<string, string> actionParameters = new Dictionary<string, string>();

                    foreach (XElement elTag in action.Nodes())
                    {
                        actionParameters.Add(elTag.Attribute("name").Value, elTag.Value);
                    }

                    MonsterActionsData aData = new MonsterActionsData();
                    aData.actionName = actionName;
                    aData.actionParameters = actionParameters;
                    actionsData.Add(aData);
                }
            }
        
            Assert.AreEqual("simpleAttack", actionsData[0].actionName);
            Assert.AreEqual("0", actionsData[0].actionParameters["CoolDownTime"]);
        }
    }
}
