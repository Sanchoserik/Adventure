using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;
using Assets.PlayerController;

namespace Assets.Code.Skills.Bruiser
{
    [Serializable]
    public class SkillEvolution : A_Skill
    {
        bool addResistFromIncomingDmg;
        int addResistVal;
        int sDuration;

        public SkillEvolution(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
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

            addResistFromIncomingDmg = Convert.ToBoolean(sData.skillValues[level]["AddResitFromIncomingDamage"]);
            addResistVal = Convert.ToInt32(sData.skillValues[level]["AddDefVal"]);
            sDuration = Convert.ToInt32(sData.skillValues[level]["Time"]);
        }
    }
}
