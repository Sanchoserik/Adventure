using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts
{
    public class LocalisationData
    {
        //  Dictionary<sceneName, Dictionary<gameObjectName, Value>>
        public Dictionary<string, Dictionary<string, string>> locValues;

        public LocalisationData()
        {
            locValues = new Dictionary<string, Dictionary<string, string>>();
        }
    }
}
