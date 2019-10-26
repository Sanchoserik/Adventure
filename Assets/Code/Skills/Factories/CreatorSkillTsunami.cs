using Assets.Code.Skills.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillTsunami : ISkillFactory
    {
        public A_Skill createSkill()
      => new SkillTsunami("Tsunami", "Regeneration", new string[] { "" }, false);
    }
}
