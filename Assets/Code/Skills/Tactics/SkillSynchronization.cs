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
    class SkillSynchronization : A_Skill
    {
       AS_Synchronization script = new AS_Synchronization();

        public SkillSynchronization(string _name, string _skillUnlocker, bool _isAvailableForLearning) : base(_name, _skillUnlocker, _isAvailableForLearning)
        {

        }
      
        public override void callSkill(C_Hero user)
        {
         
            script.callScript(user);

        }
    }
}
