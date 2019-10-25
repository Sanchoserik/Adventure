﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;
using Assets.PlayerController;

namespace Assets.Code.Skills.Warrior
{
    [Serializable]
    public class SkillDarkDemon : A_Skill
    {
        int darknessDmg;
        int stunTime;
        int sDuration;

        public SkillDarkDemon(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
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

            darknessDmg = Convert.ToInt32(sData.skillValues[level]["DarknessDmg"]);
            stunTime = Convert.ToInt32(sData.skillValues[level]["StunTime"]);           
            sDuration = Convert.ToInt32(sData.skillValues[level]["Time"]);
        }
    }
}
