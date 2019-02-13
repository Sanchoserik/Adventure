using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.PlayerController
{
    public class DefenceParam
    {
        public string strValue;  //n - none s - small m - medium g - greater u - ultra
        public int intValue;     //n - 0 s - 20 m - 50 g - 80 u - 100 
        public short shortValue; //0 1 2 3 4
     
        public DefenceParam()
        {
            strValue = "n";
            shortValue = 0;
            intValue = 0;
        }
        
        public DefenceParam(string _strVal, short _shrtVal, int _intVal)
        {
            strValue = _strVal;
            shortValue = _shrtVal;
            intValue = _intVal;
        }
         
        public void changeValue(short _val)
        {
            shortValue += _val;
            if (shortValue < 0) shortValue = 0; 
            else if (shortValue > 4) shortValue = 4;
            setValue();
        }

        private void setValue()
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

    }
}
