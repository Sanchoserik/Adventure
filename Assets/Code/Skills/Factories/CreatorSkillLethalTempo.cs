using Assets.Code.Skills.Assassin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillLethalTempo : ISkillFactory
    {
        public A_Skill createSkill()
     => new SkillLethalTempo("LethalTempo", "Assassination", new string[] { "" }, false);
    }
}
