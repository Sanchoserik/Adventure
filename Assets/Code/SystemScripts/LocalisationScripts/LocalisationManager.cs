using Assets.Code.SystemScripts.LocalisationScripts.LocalisationDataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using UnityEngine;

namespace Assets.Code.SystemScripts.LocalisationScripts
{
    public class LocalisationManager : MonoBehaviour
    {
        private string interfaceLocPath = "";
        private string systemMessagesPath = "";
        private string itemsLocPath = "";
        private string skillsLocPath = "";
       
        public static InterfaceLocalisationData interfaceLocalisationData;
        public static InterfaceLocalisationData systemMessagesLocalisationData;
        public static List<ItemsLocalisationData> itemsLocalisationData;
        public static List<SkillsLocalisationData> skillsLocalisationData;
       
        //Load from XML on awake
        private void Awake()
        {            
            interfaceLocalisationData = new InterfaceLocalisationData();
            systemMessagesLocalisationData = new InterfaceLocalisationData();
            itemsLocalisationData = new List<ItemsLocalisationData>();
            skillsLocalisationData = new List<SkillsLocalisationData>();
            
            selectLocalisationLanguage(AppParameters.localisation);
            DontDestroyOnLoad(gameObject);

            LoadInterfaceLocalisationXML(interfaceLocalisationData, interfaceLocPath);
            LoadInterfaceLocalisationXML(systemMessagesLocalisationData, systemMessagesPath);
            LoadItemsLocalisationXML();
            LoadSkillsLocalisationXML();
        }

        private void LoadInterfaceLocalisationXML(InterfaceLocalisationData _data, string path)
        {
            IEnumerable<XElement> scenes; // <scene> tag                
            XDocument xDoc = XDocument.Load(path);

            scenes = xDoc.Descendants("scenes").Elements();

            foreach (XElement scene in scenes)
            {
                string scName = scene.Attribute("name").Value.Trim();
                Dictionary<string, string> values = new Dictionary<string, string>();
                foreach (XElement el in scene.Elements())
                {
                    if (!values.ContainsKey(el.Attribute("name").Value))
                        values.Add(el.Attribute("name").Value, el.Value);
                }
                if (!_data.localisationValues.ContainsKey(scName))
                    _data.localisationValues.Add(scName, values);
            }
        }

        private void LoadItemsLocalisationXML()
        {
            IEnumerable<XElement> itemsLocalisation; // <item> tag  
            XDocument xDoc = XDocument.Load(itemsLocPath);                  

            itemsLocalisation = xDoc.Descendants("items").Elements(); ;

            foreach (XElement item in itemsLocalisation)
            {
                string itemName = item.Attribute("name").Value.Trim();
                string itemLocName = item.Element("LocName").Value;
                string itemLocDesc = item.Element("LocDescr").Value;

                itemsLocalisationData.Add(new ItemsLocalisationData(itemName, itemLocName, itemLocDesc));
            }

        }

        private void LoadSkillsLocalisationXML()
        {
            IEnumerable<XElement> skillsLocalisation; 
            XDocument xDoc = XDocument.Load(skillsLocPath);

            skillsLocalisation = xDoc.Descendants("skills").Elements();

            foreach (XElement item in skillsLocalisation)
            {
                string sName = item.Attribute("name").Value;
                string sLocName = item.Attribute("locname").Value;
                string sMainDescr = item.Attribute("descr").Value;

                List<string> levelsDescr = new List<string>();// concrette level description
                List<string> levelsTargets = new List<string>();// <targets> tag 
                foreach (XElement el in item.Elements("l"))
                {
                    levelsTargets.Add(el.Attribute("lTarget").Value);
                    levelsDescr.Add(el.Value);
                }

                skillsLocalisationData.Add(new SkillsLocalisationData(sName, sLocName, sMainDescr, levelsDescr, levelsTargets));
            }
        }



        private void selectLocalisationLanguage(string _lang)
        {
            switch (_lang)
            {
                case "ENG": {
                        interfaceLocPath = "Assets/Resources/xml/interfaceLoc/ENG.xml";                     
                        itemsLocPath = "Assets/Resources/xml/items/ItemsLocUA.xml"; // Add English Localisation later(
                        skillsLocPath = "Assets/Resources/xml/skills/skillsLocUA.xml";// // Add English Localisation later(
                        systemMessagesPath = "Assets/Resources/xml/interfaceLoc/systemMessagesENG.xml";
                        break; }
                case "UA": {
                        interfaceLocPath = "Assets/Resources/xml/interfaceLoc/UA.xml";
                        itemsLocPath = "Assets/Resources/xml/items/ItemsLocUA.xml";
                        skillsLocPath = "Assets/Resources/xml/skills/skillsLocUA.xml";
                        systemMessagesPath = "Assets/Resources/xml/interfaceLoc/systemMessagesUA.xml";
                        break; }
            }
        }

    }
}
