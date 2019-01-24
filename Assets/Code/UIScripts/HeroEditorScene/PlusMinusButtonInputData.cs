using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code.UIScripts.HeroEditorScene
{
    // Two types of buttons
    // true is for PLUS
    // false is for MINUS
    // functionMessage is for function data
    // command name is for setCommand method
    public class PlusMinusButtonInputData : MonoBehaviour
    {
        public bool buttonType;       
        public string functionMessage;
        public string commandName;
    }
}
