﻿using System;
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
    class SkillCriticalBalance : A_Skill
    {
        AS_CriticalBalance script = new AS_CriticalBalance();

        public SkillCriticalBalance(string _name, string _skillUnlocker, bool _isAvailableForLearning) : base(_name, _skillUnlocker, _isAvailableForLearning)
        {

        }
        
        public override void callSkill(C_Hero user)
        {
            
            script.callScript(user);

        }

    }
}
