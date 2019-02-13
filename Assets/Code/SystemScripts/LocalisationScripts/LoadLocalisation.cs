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
        public static LocalisationData localisationDataStorage; 

        private void Start()
        {
            //reset localisation data storage 
            localisationDataStorage = new LocalisationData();

            string lang = AppParameters.localisation;
            selectLocalisationLanguage(lang);
            DontDestroyOnLoad(gameObject);
            LoadXML();

            LocaliseComponents lsc = new LocaliseComponents();
            lsc.localiseScene(localisationDataStorage); // localise scene from ldata       
        }

        void LoadXML()
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
                localisationDataStorage.locValues.Add(scName, values);
            }
        }//end LoadXML

        void selectLocalisationLanguage(string _lang)
        {
            switch (_lang)
            {
                case "ENG": { path = "Assets/Resources/xml/interfaceLoc/ENG.xml";  break; }
                case "UA": { path = "Assets/Resources/xml/interfaceLoc/UA.xml"; break; }
            }
        }//end ufn
    }
}
