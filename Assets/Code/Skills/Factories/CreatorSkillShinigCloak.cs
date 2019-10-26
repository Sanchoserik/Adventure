using Assets.Code.Skills.Assassin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillShinigCloak : ISkillFactory
    {
        public A_Skill createSkill()
       => new SkillShiningCloak("ShiningCloak", "PiercingLight", new string[] { "FasterThanLight" }, false);
    }
}
