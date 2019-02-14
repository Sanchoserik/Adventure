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
    class SkillComboCharge : A_Skill
    {
        AS_ComboCharge script = new AS_ComboCharge();

        public SkillComboCharge(string _name, short _maxLevel) : base(_name, _maxLevel)
        {

        }
        
        public override void callSkill(C_Hero user)
        {           
            script.callScript(user);
        }
    }
}
