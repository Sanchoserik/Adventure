using Assets.Code.Skills.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillStoneSkin : ISkillFactory
    {
        public A_Skill createSkill()
        => new SkillStoneSkin("StoneSkin", "CounterAttack", new string[] { "EarthDestruction" }, false);
    }
}
