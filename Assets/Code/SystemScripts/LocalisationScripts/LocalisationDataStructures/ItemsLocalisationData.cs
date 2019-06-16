using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts.LocalisationScripts.LocalisationDataStructures
{
    public class ItemsLocalisationData
    {
        //item localisation data
        public string itemName;
        public string itemLocalisedName;
        public string itemLocalisedDescription;
        
        public ItemsLocalisationData(string iName, string iLocName, string iLocDescr)
        {
            itemName = iName;
            itemLocalisedName = iLocName;
            itemLocalisedDescription = iLocDescr;
        }
    }
}
