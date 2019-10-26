﻿using Assets.Code.Skills.Bruiser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillDelayedDeath : ISkillFactory
    {
        public A_Skill createSkill(string sName, string sUnlocker, string[] sToUnlock, bool isAvailablefroLearning)
      => new SkillDelayedDeath("DelayedDeath", "DeathSign", new string[] { "FaceOfDeath" }, false);
    }
}
