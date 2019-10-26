using Assets.Code.Skills.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillTripleCut : ISkillFactory
    {
        public A_Skill createSkill(string sName, string sUnlocker, string[] sToUnlock, bool isAvailablefroLearning)
        => new SkillTripleCut("TripleCut", "CounterAttack", new string[] { "FinishingBlow" }, false);
    }
}
