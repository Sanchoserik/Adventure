using Assets.Code.SystemScripts.LocalisationScripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using UnityEngine;

namespace Assets.Code.SystemScripts
{
    public class LoadLocalisation : MonoBehaviour
    {
        private string interfaceLocPath = "";
        private string itemsLocPath = "";
        private string itemsPotionsdataPath = "";
        public static InterfaceLocalisationData interfaceLcalisationData;
        public static List<ItemsLocalisationData> itemsLocalisationData;

        private void Awake()
        {
            //reset localisation data storage 
            interfaceLcalisationData = new InterfaceLocalisationData();
            itemsLocalisationData = new List<ItemsLocalisationData>();

            selectLocalisationLanguage(AppParameters.localisation);
            DontDestroyOnLoad(gameObject);

            LoadInterfaceLocalisationXML();
            LoadItemsLocalisationXML();
        }

        private void LoadInterfaceLocalisationXML()
        {
            IEnumerable<XElement> scenes; // <scene> tag                
            XDocument xDoc = XDocument.Load(interfaceLocPath);

            scenes = xDoc.Descendants("scenes").Elements();

            foreach (XElement scene in scenes)
            {
                string scName = scene.Attribute("name").Value.Trim();
                Dictionary<string, string> values = new Dictionary<string, string>();
                foreach (XElement el in scene.Elements())
                {                                  
                    values.Add(el.Attribute("name").Value, el.Value);
                }
                interfaceLcalisationData.locValues.Add(scName, values);
            }
        }

        private void LoadItemsLocalisationXML()
        {
            IEnumerable<XElement> items; // <item> tag  
            IEnumerable<XElement> itemsPotionsData; // <item>
            XDocument xDoc = XDocument.Load(itemsLocPath);
            XDocument xDocPotions = XDocument.Load(itemsPotionsdataPath);


            items = xDoc.Descendants("items").Elements(); ;
            itemsPotionsData = xDocPotions.Descendants("items").Elements();

            foreach (XElement item in items)
            {
                string itemName = item.Attribute("name").Value.Trim();
                string itemLocName = item.Element("LocName").Value;
                string itemLocDesc = item.Element("LocDescr").Value;

                itemsLocalisationData.Add(new ItemsLocalisationData(itemName, itemLocName, itemLocDesc));
            }

            //


        }

        private void selectLocalisationLanguage(string _lang)
        {
            switch (_lang)
            {
                case "ENG": {
                        interfaceLocPath = "Assets/Resources/xml/interfaceLoc/ENG.xml";                     
                        itemsLocPath = "Assets/Resources/xml/items/ItemsPotionsLocUA.xml"; // Add Englich Localisation later(
                        break; }
                case "UA": {
                        interfaceLocPath = "Assets/Resources/xml/interfaceLoc/UA.xml";
                        itemsLocPath = "Assets/Resources/xml/items/ItemsPotionsLocUA.xml";
                        break; }
            }
            itemsPotionsdataPath = "Assets/Resources/xml/items/ItemsPotions.xml";

        }

    }
}
