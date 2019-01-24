using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code.UIScripts.HeroEditorScene
{
    class HeroEditorController : MonoBehaviour
    {
        public PlayerController controller;
        interfaceCommand inputCommand;

        void Start()
        {
            
        }

        private void Update()
        {
            
        }

      
        public void buttonInput(PlusMinusButtonInputData commandData)
        {
            switchCommandType(commandData);
            inputCommand.execute();
        }
        private void switchCommandType(PlusMinusButtonInputData data )
        {
            switch (data.commandName)
            {
                case "attrChange": { setCommand(new commandAttributeChange(controller.hero, data)); break; }
                case "defValChange": { setCommand(new commandDefenceValueChange(controller.hero, data)); break; }
                case "levelChange": { setCommand(new commandLevelChange(controller.hero, data)); break; }
            }
        }
        private void setCommand(interfaceCommand command)
        {
            inputCommand = command;
        }
    }
}
