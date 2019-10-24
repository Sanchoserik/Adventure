using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.PlayerController;

namespace Assets.Code.Skills.Warrior
{
    [Serializable]
    public class SkillAbsoluteDarkness : A_Skill
    {
        public SkillAbsoluteDarkness(string _name, string _skillUnlocker, string[] _skillsToUnlock, bool _isAvailableForLearning)
            : base(_name, _skillUnlocker, _skillsToUnlock, _isAvailableForLearning)
        {

        }

        public override void callSkill(C_Hero user)
        {
            throw new NotImplementedException();
        }
    }
}
