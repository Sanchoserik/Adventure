using Assets.Code.Skills.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillRicochet : ISkillFactory
    {
        public A_Skill createSkill()
   => new SkillRicochet("Ricochet", "CursedSign", new string[] { "PerfectWarrior" }, false);
    }
}
