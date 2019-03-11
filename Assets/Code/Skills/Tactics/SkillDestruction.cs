using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.PlayerController;
using Assets.Skills.ActionScripts;

namespace Assets.Code.Skills.Tactics
{
    [Serializable]
    public class SkillDestruction : A_Skill
    {
        AS_Destruction script = new AS_Destruction();

        public SkillDestruction()
        {
        }

        public SkillDestruction(string _name, string _skillUnlocker, string[] _skillsToUnlock, bool _isAvailableForLearning) : base(_name, _skillUnlocker, _skillsToUnlock, _isAvailableForLearning)
        {

        }
        
        public override void callSkill(C_Hero user)
        {
            
            script.callScript(user);

        }
    }
}
