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
        public static LocalisationData localisationData; //= new LocalisationData(); // localisation data storage

        private void Start()
        {
            //reset localisation data storage 
            localisationData = new LocalisationData();
            string lang = AppParameters.localisation;
            selectLocalisation(lang);
            DontDestroyOnLoad(gameObject);
            LoadXML();

            LocaliseComponents lsc = new LocaliseComponents();
            lsc.localiseScene(localisationData); // localise scene from ldata       
        }

        void LoadXML()
        {
            IEnumerable<XElement> scenes; // <scene> tag     
            IEnumerable<XElement> elements; // <el> tag
            XDocument xDoc = XDocument.Load(path);

            scenes = xDoc.Descendants("scenes").Elements();
            elements = xDoc.Descendants("scene").Elements();

            foreach (XElement scene in scenes)
            {

                string scName = scene.Attribute("name").Value.Trim();
                Dictionary<string, string> values = new Dictionary<string, string>();
                foreach (XElement el in scene.Elements())
                {               
                   
                    values.Add(el.Attribute("name").Value, el.Value);
                }
                localisationData.locValues.Add(scName, values);
            }//end foreach
            //

        }//end LoadXML

        void selectLocalisation(string _lang)
        {
            switch (_lang)
            {
                case "ENG": { path = "Assets/Resources/xml/interfaceLoc/ENG.xml";  break; }
                case "UA": { path = "Assets/Resources/xml/interfaceLoc/UA.xml"; break; }
            }
        }//end ufn
    }
}
