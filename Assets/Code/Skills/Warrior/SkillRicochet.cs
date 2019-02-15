using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.PlayerController;

namespace Assets.Code.Skills.Warrior
{
    class SkillRicochet : A_Skill
    {
        public SkillRicochet(string _name, short _maxLevel, bool _isAvailableForLearning) : base(_name, _maxLevel, _isAvailableForLearning)
        {

        }

        public override void callSkill(C_Hero user)
        {
            throw new NotImplementedException();
        }
    }
}
