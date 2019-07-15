using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Assets.Code.SystemScripts.LoadValuesScripts
{
    //storage for all item, skill etc. values 
    public class LoadValuesFromXML
    {
        private string itemsPath = "Assets/Resources/xml/items/Items.xml";
        private string skillsPath = "Assets/Resources/xml/skills/skills.xml";

        public LoadValuesFromXML()
        {
            loadItems();
            loadSkills();
        }

        private void loadItems()
        {
            IEnumerable<XElement> items; // <item> tag  
            XDocument xDoc = XDocument.Load(itemsPath);

            items = xDoc.Descendants("items").Elements(); ;

            foreach (XElement item in items)
            {
                if (item.Nodes() != null)
                {
                    string itemName = item.Attribute("name").Value;
                    Dictionary<string, string> potionParameters = new Dictionary<string, string>();

                    foreach (XElement valTag in item.Nodes())
                    {
                        potionParameters.Add(valTag.Attribute("name").Value, valTag.Value);                        
                    }
                    ItemsData itemData = new ItemsData();
                    itemData.itemName = itemName;
                    itemData.itemsParameters = potionParameters;
                    ResourcesManager.itemsData.Add(itemData);  
                }               
            }
        }

        private void loadSkills()
        {
            IEnumerable<XElement> skills;
            XDocument skillsXML = XDocument.Load(skillsPath);
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
                ResourcesManager.skillsData.Add(new SkillsData(_name, _scname, _levels , _sAPCost, _sEneCost, _sValues));
            }
        }

    }
}
