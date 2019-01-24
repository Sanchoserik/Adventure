using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.UIScripts.HeroEditorScene
{
    class commandLevelChange : interfaceCommand
    {
        C_Hero hero;
        PlusMinusButtonInputData data;

        public commandLevelChange(C_Hero _hero, PlusMinusButtonInputData _data)
        {
            hero = _hero;
            data = _data;
        }

        public void execute()
        {
            if (data.buttonType)
            { hero.levelPlus(); }
            else hero.levelMinus();
        }
    }
}
