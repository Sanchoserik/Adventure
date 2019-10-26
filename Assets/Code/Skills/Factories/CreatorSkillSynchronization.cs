using Assets.Code.Skills.Tactics;
using Assets.Code.Skills.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillSynchronization : ISkillFactory
    {
        public A_Skill createSkill()
     => new SkillSynchronization("Synchronization", "CriticalBalance", new string[] { "" }, false);
    }
}
