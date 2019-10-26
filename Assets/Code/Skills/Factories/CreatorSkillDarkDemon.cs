using Assets.Code.Skills.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillDarkDemon : ISkillFactory
    {
        public A_Skill createSkill(string sName, string sUnlocker, string[] sToUnlock, bool isAvailablefroLearning)
       => new SkillDarkDemon("DarkDemon", "AbsoluteDarkness", new string[] { "" }, false);
    }
}
