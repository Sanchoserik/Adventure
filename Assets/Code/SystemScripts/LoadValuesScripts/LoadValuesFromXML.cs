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
        private string itemsPath = "Assets/Resources/xml/items/ItemsPotions.xml";

        public LoadValuesFromXML()
        {
            loadItems();            
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
                    itemData.potionName = itemName;
                    itemData.potionParameters = potionParameters;
                    ResourcesManager.itemsData.Add(itemData);  
                }               
            }
        }
    }
}
