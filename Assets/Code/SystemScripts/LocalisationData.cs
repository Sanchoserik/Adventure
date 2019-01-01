using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.SystemScripts
{
    public class LocalisationData
    {
        public Dictionary<string, Dictionary<string, string>> locValues;
                         // sceneName  gameObjName  Value 

        public LocalisationData()
        {
            locValues = new Dictionary<string, Dictionary<string, string>>();
        }
    }
}
