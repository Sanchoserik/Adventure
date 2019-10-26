using Assets.Code.Skills.Tactics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillCriticalBalance : ISkillFactory
    {
        public A_Skill createSkill()
       => new SkillCriticalBalance("CriticalBalance", "CounterAnalysis", new string[] { "ComboCharge", "Overcharge",
            "Synchronization"}, false);
    }
}
