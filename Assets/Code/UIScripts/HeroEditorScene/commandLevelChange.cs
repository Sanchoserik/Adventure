using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.UIScripts.HeroEditorScene
{
    class CommandLevelChange : ICommand
    {
        C_Hero hero;
        PlusMinusButtonInputData data;

        public CommandLevelChange(C_Hero _hero, PlusMinusButtonInputData _data)
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
