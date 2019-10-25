using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;
using Assets.PlayerController;

namespace Assets.Code.Skills.Bruiser
{
    [Serializable]
    public class SkillFaceOfDeath : A_Skill
    {
        int deathDmg;
        int regenerationVal;
        int deathDef;
        int physDef;
        int lightDef;
        int waterDef;
        int sDuration;

        public SkillFaceOfDeath(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
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

            deathDmg = Convert.ToInt32(sData.skillValues[level]["DeathDmg"]);
            regenerationVal = Convert.ToInt32(sData.skillValues[level]["Regeneration"]);
            deathDef = Convert.ToInt32(sData.skillValues[level]["DeathDef"]);
            physDef = Convert.ToInt32(sData.skillValues[level]["PhysDef"]);
            lightDef = Convert.ToInt32(sData.skillValues[level]["LightDef"]);
            waterDef = Convert.ToInt32(sData.skillValues[level]["WaterDef"]);
            sDuration = Convert.ToInt32(sData.skillValues[level]["Time"]);
        }
    }
}
