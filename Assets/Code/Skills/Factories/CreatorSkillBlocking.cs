using Assets.Code.Skills.Bruiser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillBlocking : ISkillFactory
    {
        public A_Skill createSkill()
       => new SkillBlocking("Blocking", "Rearm", new string[] { "WideSwing", "DeathSign", "LightningChain", "LifeDrain" }, false);
    }
}
