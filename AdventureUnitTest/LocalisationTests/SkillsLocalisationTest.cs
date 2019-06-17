using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Assets.Code.SystemScripts.LocalisationScripts.LocalisationDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureUnitTest.LocalisationTests
{
    [TestClass]
    public class SkillsLocalisationTest
    {
        [TestMethod]
        public void skillsLocalisationLoadTest()
        {
            List<SkillsLocalisationData> skillsLocalisationData = new List<SkillsLocalisationData>();

            IEnumerable<XElement> skillsLocalisation;
            XDocument xDoc = XDocument.Load("F:/UnityProjects/Adventure/Assets/Resources/xml/skills/skillsLocUA.xml");

            skillsLocalisation = xDoc.Descendants("skills").Elements();

            foreach (XElement item in skillsLocalisation)
            {
                string sLocName = item.Attribute("locname").Value;
                string sMainDescr = item.Attribute("descr").Value;

                List<string> levelsDescr = new List<string>();// concrette level description
                List<string> levelsTargets = new List<string>();// <targets> tag 
                foreach (XElement el in item.Elements("l"))
                {
                    levelsTargets.Add(el.Attribute("lTarget").Value);
                    levelsDescr.Add(el.Value);
                }

                skillsLocalisationData.Add(new SkillsLocalisationData(sLocName, sMainDescr, levelsDescr, levelsTargets));     
            }
            Assert.AreEqual("Можна змінити зброю на катану катари або косу", skillsLocalisationData[0].skillLocalisedLevelDescription[0]);

        }
    }
}
