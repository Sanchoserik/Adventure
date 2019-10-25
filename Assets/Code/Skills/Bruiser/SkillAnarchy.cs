using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;
using Assets.PlayerController;

namespace Assets.Code.Skills.Bruiser
{
    [Serializable]
    public class SkillAnarchy : A_Skill
    {
        int bonusCriticalCh;
        int bonusCriticalDmgPercent;
        int counterATKChDecr;
        int atkEvasionChDecr;
        int skillEvasionChDecr;
        int blockingChDecr;
        int sDuration;

        public SkillAnarchy(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
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

            bonusCriticalCh = Convert.ToInt32(sData.skillValues[level]["CrStrikeChancePlus"]);
            bonusCriticalDmgPercent = Convert.ToInt32(sData.skillValues[level]["CrStrikeDmgPlus"]);
            counterATKChDecr = Convert.ToInt32(sData.skillValues[level]["CounterattackChDecr"]);
            atkEvasionChDecr = Convert.ToInt32(sData.skillValues[level]["AtkEvasionChDecr"]);
            skillEvasionChDecr = Convert.ToInt32(sData.skillValues[level]["SkillEvasionChDecr"]);
            blockingChDecr = Convert.ToInt32(sData.skillValues[level]["BlockingChDecr"]);
            sDuration = Convert.ToInt32(sData.skillValues[level]["Time"]);
        }
    }
}
