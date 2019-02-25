using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using System.Xml;
using System.Xml.Serialization; 
using System.IO;
using System.Xml.Linq;

namespace Assets.Code.UIScripts.SkillTreeScene
{
    public class SkillsLoaderFromXML
    {

        public static void LoadXML(List<SkillDataStorage> skillDataXML) // TODO: add localisation language parames
        {
            IEnumerable<XElement> skills;      
            IEnumerable<XElement> skillLocalisation; 
          
            XDocument skillsXML = XDocument.Load("Assets/Resources/xml/skills/skills.xml");
           
            //!!! UA LOCALISATION BY DEFAULT 
            XDocument skillsLocalisationXML = XDocument.Load("Assets/Resources/xml/skills/skillsLocUA.xml");

            skills = skillsXML.Descendants("skills").Elements();

            skillLocalisation = skillsLocalisationXML.Descendants("skills").Elements();

            getSkillsDataFromXML(skillDataXML,skills);
            getSkillsLocalisationFromXML(skillDataXML, skillLocalisation);
        
           
        }

        private static void getSkillsDataFromXML(List<SkillDataStorage> skillDataXML, IEnumerable<XElement> skills)
        {
            foreach (XElement item in skills)
            {              
                short _levels = short.Parse(item.Attribute("levels").Value);
                string _name = item.Attribute("name").Value.Trim();
                string _scname = item.Attribute("scname").Value.Trim();

                //int value is skill levels
                Dictionary<int, string> lDataEne = new Dictionary<int, string>();
                Dictionary<int, string> lDataAP = new Dictionary<int, string>();
                
                List<Dictionary<string, string>> vValues = new List<Dictionary<string, string>>();

                int levelIter = 1;
                foreach (XElement el in item.Elements("l"))
                {
                    
                    lDataEne.Add(levelIter, el.Attribute("pEne").Value);
                    lDataAP.Add(levelIter, el.Attribute("pAP").Value);
                    
                    //get <v> tag values
                    if (el.Nodes() != null)
                    {
                        vValues.Add(new Dictionary<string, string>());
                        foreach (XElement vTag in el.Nodes())
                        {
                            vValues[vValues.Count - 1].Add(vTag.Attribute("name").Value, vTag.Value);
                        }
                    }
                    ++levelIter;
                }
                 
                skillDataXML.Add(new SkillDataStorage(_levels, _name, _scname, lDataAP, lDataEne, vValues)); // add data to list
            }
        }

        private static void getSkillsLocalisationFromXML(List<SkillDataStorage> skillDataXML, IEnumerable<XElement> skillLocalisation)
        {
            int iter = 0; 
            foreach (XElement item in skillLocalisation)
            {
                skillDataXML[iter].skillLocalisedName = item.Attribute("locname").Value;
                skillDataXML[iter].skillMainDescription = item.Attribute("descr").Value;

                List<string> levelsDescr = new List<string>();// concrette level description
                List<string> levelsTargets = new List<string>();// <targets> tag 
                foreach (XElement el in item.Elements("l"))
                {
                    levelsTargets.Add(el.Attribute("lTarget").Value);
                    levelsDescr.Add(el.Value);
                }
                skillDataXML[iter].skillLocalisedLevelDescription = levelsDescr;
                skillDataXML[iter].skillTargetsDescription = levelsTargets;
                ++iter;
            }
        }
    }
}