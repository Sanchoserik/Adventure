using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.UIScripts.HeroEditorScene
{
    class CommandDefenceValueChange : InterfaceCommand
    {
        C_Hero hero;
        PlusMinusButtonInputData data;

        public CommandDefenceValueChange(C_Hero _hero, PlusMinusButtonInputData _data)
        {
            hero = _hero;
            data = _data;
        }

        public void execute()
        {
            if (data.buttonType)
            { hero.defenceValuePlus(data.functionMessage); }
            else hero.defenceValueMinus(data.functionMessage);
        }
    }
}
