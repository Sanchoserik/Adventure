using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Code.SystemScripts.LoadValuesScripts;

namespace Assets.Code.SystemScripts
{
    public class ResourcesManager : MonoBehaviour
    {
        public static List<ItemsData> itemsData;
        public static List<SkillsData> skillsData;

        private void Awake()
        {
            itemsData = new List<ItemsData>();
            skillsData = new List<SkillsData>();

            LoadValuesFromXML loadValues = new LoadValuesFromXML();           
        }
    }
}
