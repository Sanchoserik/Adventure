using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts.LocalisationScripts.LocalisationDataStructures
{
    public class InterfaceLocalisationData
    {
        //  Dictionary<sceneName, Dictionary<gameObjectName, Value>>
        public Dictionary<string, Dictionary<string, string>> locValues;

        public InterfaceLocalisationData()
        {
            locValues = new Dictionary<string, Dictionary<string, string>>();
        }
    }
}
