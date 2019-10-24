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
    public class SkillCriticalBalance : A_Skill
    {
        int allDefdecrVal;
        int criticalChBonus;
        int sDuration;

        AS_CriticalBalance script = new AS_CriticalBalance();
   
        public SkillCriticalBalance(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
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

            allDefdecrVal = Convert.ToInt32(sData.skillValues[level]["AllDefDecr"]);
            criticalChBonus = Convert.ToInt32(sData.skillValues[level]["CrStrikeChancePlus"]);
            sDuration = Convert.ToInt32(sData.skillValues[level]["Time"]);
        }
    }
}
