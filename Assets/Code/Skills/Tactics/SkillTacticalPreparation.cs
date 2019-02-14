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
    class SkillTacticalPreparation : A_Skill
    {
        AS_Retreat script = new AS_Retreat();

        public SkillTacticalPreparation(string _name, short _maxLevel) : base(_name, _maxLevel)
        {

        }

        public override void callSkill(C_Hero user) 
        {
          
            script.callScript(user);

        }
    }
}
