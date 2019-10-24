using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Skills.ActionScripts;
using Assets.Code.Skills.ActionScripts.ASTactics;
using Assets.PlayerController;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Skills.Tactics
{
    [Serializable]
    public class SkillComboCharge : A_Skill
    {
        int dmgBonusPercentMark;
        int sDuration;

        AS_ComboCharge script = new AS_ComboCharge();

        public SkillComboCharge(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
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

            dmgBonusPercentMark = Convert.ToInt32(sData.skillValues[level]["DamageBonusPercentMark"]);
            sDuration = Convert.ToInt32(sData.skillValues[level]["Time"]);
        }
    }
}
