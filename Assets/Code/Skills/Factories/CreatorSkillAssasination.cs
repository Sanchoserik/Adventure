using Assets.Code.Skills.Assassin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillAssasination : ISkillFactory
    {
        public A_Skill createSkill()
       => new SkillAssassination("Assassination", "PiercingStrike", new string[] { "LethalTempo" }, false);
    }
}
