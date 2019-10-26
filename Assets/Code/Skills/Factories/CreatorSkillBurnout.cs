using Assets.Code.Skills.Assassin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillBurnout : ISkillFactory
    {
        public A_Skill createSkill()
        => new SkillBurnout("Burnout", "FireClaw", new string[] { "Gehena" }, false);
    }
}
