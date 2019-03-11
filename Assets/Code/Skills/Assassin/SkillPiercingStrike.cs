using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.PlayerController;

namespace Assets.Code.Skills.Assassin
{
    [Serializable]
    public class SkillPiercingStrike : A_Skill
    {
        public SkillPiercingStrike()
        {
        }

        public SkillPiercingStrike(string _name, string _skillUnlocker, string[] _skillsToUnlock, bool _isAvailableForLearning) : base(_name, _skillUnlocker, _skillsToUnlock, _isAvailableForLearning)
        {

        }

        public override void callSkill(C_Hero user)
        {
            throw new NotImplementedException();
        }
    }
}
