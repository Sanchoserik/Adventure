﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;
using Assets.PlayerController;

namespace Assets.Code.Skills.Assassin
{
    [Serializable]
    public class SkillEvasion : A_Skill
    {
        int atkEvasion;
        int skillEvasion;

        public SkillEvasion(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
        {

        }

        public override void callSkill(C_Hero user)
        {
            throw new NotImplementedException();
        }

        public override void levelXInit(SkillsData sData, int level)
        {
            base.priceAP = Convert.ToInt32(sData.skillAPCost[level]);
            base.priceENE = Convert.ToInt32(sData.skillEneCost[level]);
            base.skillCooldown = Convert.ToInt32(sData.skillCooldown[level]);
            base.skillTargets = new SkillTargets(sData.skillValues[level]["Targets"]);

            atkEvasion = Convert.ToInt32(sData.skillValues[level]["AtkEvasion"]);
            skillEvasion = Convert.ToInt32(sData.skillValues[level]["SkillEvasion"]);           
        }
    }
}
