using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillTacticalSwap : ISkillFactory
    {
        public A_Skill createSkill(string sName, string sUnlocker, string[] sToUnlock, bool isAvailablefroLearning)
     => new SkillTacticalSwap("TacticalSwap", "Rearm", new string[] { "TacticalRetreat", "TacticalRecharge",
                "CounterAnalysis", "IronDefence"}, false);
    }
}
