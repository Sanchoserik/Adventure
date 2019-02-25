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
    class SkillOvercharge : A_Skill
    {
        AS_Overcharge script = new AS_Overcharge();

        public SkillOvercharge(string _name, string _skillUnlocker, bool _isAvailableForLearning) : base(_name, _skillUnlocker, _isAvailableForLearning)
        {

        }
        
        public override void callSkill(C_Hero user)
        {          
            script.callScript(user);

        }
    }
}
