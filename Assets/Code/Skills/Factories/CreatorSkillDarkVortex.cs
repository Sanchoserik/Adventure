using Assets.Code.Skills.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillDarkVortex : ISkillFactory
    {
        public A_Skill createSkill()
        => new SkillDarkVortex("DarkVortex", "CounterAttack", new string[] { "AbsoluteDarkness" }, false);
    }
}
