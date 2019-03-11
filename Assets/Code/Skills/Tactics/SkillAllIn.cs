using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Skills.ActionScripts;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.PlayerController;

namespace Assets.Code.Skills.Tactics
{
    [Serializable]
    public class SkillAllIn : A_Skill
    {
        AS_AllIn script = new AS_AllIn();

        public SkillAllIn() { }

        public SkillAllIn(string _name, string _skillUnlocker, string[] _skillsToUnlock, bool _isAvailableForLearning) : base(_name, _skillUnlocker, _skillsToUnlock, _isAvailableForLearning)
        {
          
        }
        
        public override void callSkill(C_Hero user)
        {
            script.callScript(user);
        }
    }
}
