using Assets.Code.Skills.Assassin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillEvasion : ISkillFactory
    {
        public A_Skill createSkill(string sName, string sUnlocker, string[] sToUnlock, bool isAvailablefroLearning)
        => new SkillEvasion("Evasion", "Rearm", new string[] { "DoubleStrike", "PiercingLight", "FireClaw", "WindBlade" }, false);
    }
}
