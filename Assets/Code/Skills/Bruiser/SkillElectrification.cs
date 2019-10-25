using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;
using Assets.PlayerController;

namespace Assets.Code.Skills.Bruiser
{
    [Serializable]
    public class SkillElectrification : A_Skill
    {
        int lightningDmgMod;
        int crStriceBonusDmg;
        int sDuration;

        public SkillElectrification(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
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

            lightningDmgMod = Convert.ToInt32(sData.skillValues[level]["LightningDmgMod"]);
            crStriceBonusDmg = Convert.ToInt32(sData.skillValues[level]["CrStrikeDmgPlus"]);          
            sDuration = Convert.ToInt32(sData.skillValues[level]["Time"]);
        }
    }
}
