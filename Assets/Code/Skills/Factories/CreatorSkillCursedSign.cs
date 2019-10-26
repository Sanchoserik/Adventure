using Assets.Code.Skills.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills.Factories
{
    public class CreatorSkillCursedSign : ISkillFactory
    {
        public A_Skill createSkill()
     => new SkillCursedSign("CursedSign", "CounterAttack", new string[] { "Ricochet" }, false);
    }
}
