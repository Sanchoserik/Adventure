﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.PlayerController;

namespace Assets.Code.Skills.Bruiser
{
    class SkillDeathSign : A_Skill
    {
        public SkillDeathSign(string _name, short _maxLevel) : base(_name, _maxLevel)
        {

        }

        public override void callSkill(C_Hero user)
        {
            throw new NotImplementedException();
        }
    }
}
