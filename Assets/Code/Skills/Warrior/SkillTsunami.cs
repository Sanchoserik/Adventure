﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.PlayerController;

namespace Assets.Code.Skills.Warrior
{
    class SkillTsunami : A_Skill
    {
        public SkillTsunami(string _name, short _maxLevel, bool _isAvailableForLearning) : base(_name, _maxLevel, _isAvailableForLearning)
        {

        }

        public override void callSkill(C_Hero user)
        {
            throw new NotImplementedException();
        }
    }
}