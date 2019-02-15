using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.PlayerController;

namespace Assets.Code.Skills.Bruiser
{
    class SkillLightningChain : A_Skill
    {
        public SkillLightningChain(string _name, short _maxLevel, bool _isAvailableForLearning) : base(_name, _maxLevel, _isAvailableForLearning)
        {

        }

        public override void callSkill(C_Hero user)
        {
            throw new NotImplementedException();
        }
    }
}
