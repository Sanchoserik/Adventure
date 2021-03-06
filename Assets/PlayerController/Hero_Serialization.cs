﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

namespace Assets.PlayerController
{
    class Hero_Serialization 
    {       
        public static void serializeHero(string path)
        {
            XmlSerializer hero_serializer = new XmlSerializer(typeof(C_Hero));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                hero_serializer.Serialize(fs, HeroController.mainHero);
                fs.Dispose();
            }    
        }

        public static void deserializeHero(string path)
        {
            XmlSerializer hero_serializer = new XmlSerializer(typeof(C_Hero));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {               
                HeroController.mainHero = (C_Hero)hero_serializer.Deserialize(fs);
                fs.Dispose();
            }
        }
    }
}
