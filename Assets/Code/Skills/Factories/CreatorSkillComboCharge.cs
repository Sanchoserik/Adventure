﻿using Assets.Code.Skills.Tactics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillComboCharge : ISkillFactory
    {
        public A_Skill createSkill()
      => new SkillComboCharge("ComboCharge", "CriticalBalance", new string[] { "" }, false);
    }
}
