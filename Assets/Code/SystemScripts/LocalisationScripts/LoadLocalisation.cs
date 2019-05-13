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
        private string path = "";
        public static InterfaceLocalisationData interfaceLcalisationData;
        public List<ItemsLocalisationData> itemsLocalisationData;

        private void Start()
        {
            //reset localisation data storage 
            interfaceLcalisationData = new InterfaceLocalisationData();
            itemsLocalisationData = new List<ItemsLocalisationData>();

            selectLocalisationLanguage(AppParameters.localisation);
            DontDestroyOnLoad(gameObject);

            LoadInterfaceLocalisationXML();


            LocaliseComponents lsc = new LocaliseComponents();
            lsc.localiseScene(interfaceLcalisationData); // localise scene from ldata       
        }

        private void LoadInterfaceLocalisationXML()
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
                   
                    values.Add(el.Attribute("name").Value, el.Value);
                }
                interfaceLcalisationData.locValues.Add(scName, values);
            }
        }

        private void selectLocalisationLanguage(string _lang)
        {
            switch (_lang)
            {
                case "ENG": { path = "Assets/Resources/xml/interfaceLoc/ENG.xml";  break; }
                case "UA": { path = "Assets/Resources/xml/interfaceLoc/UA.xml"; break; }
            }
        }
    }
}
