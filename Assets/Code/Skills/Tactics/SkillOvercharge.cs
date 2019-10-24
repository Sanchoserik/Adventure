using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.Code.SystemScripts.DataStructures;
using Assets.PlayerController;
using Assets.Skills.ActionScripts;

namespace Assets.Code.Skills.Tactics
{
    [Serializable]
    public class SkillOvercharge : A_Skill
    {
        int addAPPrice;
        int dmgBonusPercent;
        int healingBonusPercent;
        int sDuration;

        AS_Overcharge script = new AS_Overcharge();

        public SkillOvercharge(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
        {

        }
        
        public override void callSkill(C_Hero user)
        {          
            script.callScript(user);
        }

        public override void levelXInit(SkillsData sData, int level)
        {
            base.priceAP = Convert.ToInt32(sData.skillAPCost[level]);
            base.priceENE = Convert.ToInt32(sData.skillEneCost[level]);
            base.skillCooldown = Convert.ToInt32(sData.skillCooldown[level]);
            base.skillTargets = new SkillTargets(sData.skillValues[level]["Targets"]);

            addAPPrice = Convert.ToInt32(sData.skillValues[level]["addAPPrice"]);
            dmgBonusPercent = Convert.ToInt32(sData.skillValues[level]["DamageBonusPercent"]);
            healingBonusPercent = Convert.ToInt32(sData.skillValues[level]["HealingBonusPercent"]);
            sDuration = Convert.ToInt32(sData.skillValues[level]["Time"]);
        }
    }
}
