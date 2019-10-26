using Assets.Code.Skills.Bruiser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillElectrification : ISkillFactory
    {
        public A_Skill createSkill()
       => new SkillElectrification("Electrification", "LightningChain", new string[] { "Thunderstorm" }, false);
    }
}
