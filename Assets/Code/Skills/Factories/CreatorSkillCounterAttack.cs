using Assets.Code.Skills.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillCounterAttack : ISkillFactory
    {
        public A_Skill createSkill(string sName, string sUnlocker, string[] sToUnlock, bool isAvailablefroLearning)
       => new SkillCounterAttack("CounterAttack", "Rearm", new string[] { "TripleCut", "CursedSign", "StoneSkin",
                "WaterPrison", "DarkVortex" }, false);
    }
}
