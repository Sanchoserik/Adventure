﻿using Assets.Code.Skills.Assassin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillTornado : ISkillFactory
    {
        public A_Skill createSkill()
       => new SkillTornado("Tornado", "Regeneration", new string[] { "ReleasedStream" }, false);
    }
}
