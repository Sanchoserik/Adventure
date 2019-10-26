using Assets.Code.Skills.Bruiser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillLightningChain : ISkillFactory
    {
        public A_Skill createSkill()
       => new SkillLightningChain("LightningChain", "Blocking", new string[] { "Electrification" }, false);
    }
}
