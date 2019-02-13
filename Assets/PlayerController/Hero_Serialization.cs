using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

namespace Assets.PlayerController
{
    class Hero_Serialization : MonoBehaviour
    {
        //kinda "make save"
        private void Start()
        {
            C_Hero hero = new C_Hero();
            Debug.Log("Hero created");

            XmlSerializer hero_serializer = new XmlSerializer(typeof(C_Hero));

            using (FileStream fs = new FileStream("h.xml", FileMode.OpenOrCreate))
            {
                hero_serializer.Serialize(fs, hero);
                Debug.Log("Serialization Completed");
            }

             
        }
    }
}
