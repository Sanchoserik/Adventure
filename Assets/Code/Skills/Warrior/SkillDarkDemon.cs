﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.PlayerController;

namespace Assets.Code.Skills.Warrior
{
    class SkillDarkDemon : A_Skill
    {
        public SkillDarkDemon(string _name, string _skillUnlocker, bool _isAvailableForLearning) : base(_name, _skillUnlocker, _isAvailableForLearning)
        {

        }

        public override void callSkill(C_Hero user)
        {
            throw new NotImplementedException();
        }
    }
}
