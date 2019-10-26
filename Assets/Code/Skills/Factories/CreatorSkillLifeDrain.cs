using Assets.Code.Skills.Bruiser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillLifeDrain : ISkillFactory
    {
        public A_Skill createSkill()
     => new SkillLifeDrain("LifeDrain", "Blocking", new string[] { "Evolution" }, false);
    }
}
