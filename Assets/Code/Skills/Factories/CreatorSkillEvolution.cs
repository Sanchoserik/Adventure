﻿using Assets.Code.Skills.Bruiser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillEvolution : ISkillFactory
    {
        public A_Skill createSkill()
        => new SkillEvolution("Evolution", "LifeDrain", new string[] { "DeathBlossom" }, false);
    }
}
