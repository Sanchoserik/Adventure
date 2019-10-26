using Assets.Code.Skills.Assassin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillDoubleStrike : ISkillFactory
    {
        public A_Skill createSkill()
       => new SkillDoubleStrike("DoubleStrike", "Evasion", new string[] { "PiercingStrike" }, false);
    }
}
