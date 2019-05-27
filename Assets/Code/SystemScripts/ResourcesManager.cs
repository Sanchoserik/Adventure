﻿using Assets.Code.SystemScripts.DataStructures;
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
        public static ItemsData itemsData;

        private void Awake()
        {
            itemsData = new ItemsData();

            //
            LoadValuesFromXML loadValues = new LoadValuesFromXML();
        }
    }
}
