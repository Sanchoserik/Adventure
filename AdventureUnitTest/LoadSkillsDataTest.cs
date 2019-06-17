using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Assets.Code.SystemScripts.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureUnitTest
{
    [TestClass]
    public class LoadSkillsDataTest
    {
        [TestMethod]
        public void LoadSkillsDataFromXML()
        {
            List<SkillsData> skillsData = new List<SkillsData>();

            IEnumerable<XElement> skills;
            XDocument skillsXML = XDocument.Load("F:/UnityProjects/Adventure/Assets/Resources/xml/skills/skills.xml");
            skills = skillsXML.Descendants("skills").Elements();

            foreach (XElement item in skills)
            {
                short _levels = short.Parse(item.Attribute("levels").Value);
                string _name = item.Attribute("name").Value.Trim();
                string _scname = item.Attribute("scname").Value.Trim();

                //int value is skill levels
                Dictionary<int, string> _sEneCost = new Dictionary<int, string>();
                Dictionary<int, string> _sAPCost = new Dictionary<int, string>();
                List<Dictionary<string, string>> _sValues = new List<Dictionary<string, string>>();

                int levelIter = 1;
                foreach (XElement el in item.Elements("l"))
                {
                    _sEneCost.Add(levelIter, el.Attribute("pEne").Value);
                    _sAPCost.Add(levelIter, el.Attribute("pAP").Value);

                    //get <v> tag values
                    if (el.Nodes() != null)
                    {
                        _sValues.Add(new Dictionary<string, string>());
                        foreach (XElement vTag in el.Nodes())
                        {
                            _sValues[_sValues.Count - 1].Add(vTag.Attribute("name").Value, vTag.Value);
                        }
                    }
                    ++levelIter;
                }
                skillsData.Add(new SkillsData(_name, _scname, _levels, _sAPCost, _sEneCost, _sValues));
            }

            Assert.AreEqual("Rearm", skillsData[0].skillName);
            Assert.AreEqual("TacticalRetreat", skillsData[2].skillName);
        }
    }
}
