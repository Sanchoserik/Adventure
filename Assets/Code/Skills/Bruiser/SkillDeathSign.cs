using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;
using Assets.PlayerController;

namespace Assets.Code.Skills.Bruiser
{
    [Serializable]
    public class SkillDeathSign : A_Skill
    {
        int atkDecr;
        int deathDefDecr;
        int darknessDefDecr;
        int lightDefDecr;
        int sDuration;

        public SkillDeathSign(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
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

            atkDecr = Convert.ToInt32(sData.skillValues[level]["AtkDecr"]);
            deathDefDecr = Convert.ToInt32(sData.skillValues[level]["DeathDefDecr"]);
            darknessDefDecr = Convert.ToInt32(sData.skillValues[level]["DarknessDefDecr"]);
            lightDefDecr = Convert.ToInt32(sData.skillValues[level]["LightDefDecr"]);
            sDuration = Convert.ToInt32(sData.skillValues[level]["Time"]);
        }
    }
}
