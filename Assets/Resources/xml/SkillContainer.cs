using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine;
using Assets.Code.Skills;

    // namespaces not allowed for some reason)
    [XmlRoot("SkillColection")]
    public class SkillContainer
    {
        [XmlArray("skills")]
        [XmlArrayItem("skill")]
        public List<A_Skill> skills = new List<A_Skill>();

        public static SkillContainer Load(string path)
        {
             TextAsset _xml = Resources.Load<TextAsset>(path);

             XmlSerializer serializer = new XmlSerializer(typeof(SkillContainer));
            
             StringReader reader = new StringReader(_xml.text);
        
             SkillContainer skills = serializer.Deserialize(reader) as SkillContainer;

            reader.Close();

            return skills;
        }

    }

