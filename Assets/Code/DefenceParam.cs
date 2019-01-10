using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code
{
    public class DefenceParam
    {
        public string strValue; //n - none s - small m - medium g - greater u - ultra
        public int intValue;   //n - 0 s - 20 m - 50 g - 80 u - 100 
        public short shortValue; //0 1 2 3 4

        //init
        public DefenceParam()
        {
            strValue = "n";
            shortValue = 0;
            intValue = 0;
        }
        //advanved init
        public DefenceParam(string _strVal, short _shrtVal, int _intVal)
        {
            strValue = _strVal;
            shortValue = _shrtVal;
            intValue = _intVal;
        }
        //restore value
        public void setValue()
        {
            switch (shortValue)
            {
                case 0: { intValue = 0; strValue = "n"; break; }
                case 1: { intValue = 20; strValue = "s"; break; }
                case 2: { intValue = 50; strValue = "m"; break; }
                case 3: { intValue = 80; strValue = "g"; break; }
                case 4: { intValue = 100; strValue = "u"; break; }
            }
        }
        //change value
        public void changeValue(short _val)
        {
            shortValue += _val;
            if (shortValue < 0) shortValue = 0; // cant go futher than 0
            switch (shortValue)
            {
                case 0: { intValue = 0; strValue = "n"; break; }
                case 1: { intValue = 20; strValue = "s"; break; }
                case 2: { intValue = 50; strValue = "m"; break; }
                case 3: { intValue = 80; strValue = "g"; break; }
                case 4: { intValue = 100; strValue = "u"; break; }
            }
        }
        
    }
}
