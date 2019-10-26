using Assets.Code.Skills.Bruiser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillWideSwing : ISkillFactory
    {
        public A_Skill createSkill()
     => new SkillWideSwing("WideSwing", "Blocking", new string[] { "Devouring" }, false);
    }
}
