using Assets.Code.Skills.Tactics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillAllIn : ISkillFactory
    {
        public A_Skill createSkill()
      => new SkillAllIn("AllIn", "TacticalPreparation", new string[] { "" }, false);
    }
}
