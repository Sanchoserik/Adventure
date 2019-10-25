using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;
using Assets.PlayerController;

namespace Assets.Code.Skills.Bruiser
{
    [Serializable]
    public class SkillDeathBlossom : A_Skill
    {
        int paralysisCh;
        int poisonCh;
        int paralysisTime;
        int poisonTime;
        int poisonDmg;
        int lifeDmg;
        int sDuration;
        
        public SkillDeathBlossom(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
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

            paralysisCh = Convert.ToInt32(sData.skillValues[level]["ParalysisCh"]);
            poisonCh = Convert.ToInt32(sData.skillValues[level]["PoisonCh"]);
            paralysisTime = Convert.ToInt32(sData.skillValues[level]["ParalysisTime"]);
            poisonTime = Convert.ToInt32(sData.skillValues[level]["PoisonTime"]);
            poisonDmg = Convert.ToInt32(sData.skillValues[level]["PoisonDmg"]);
            lifeDmg = Convert.ToInt32(sData.skillValues[level]["LifeDmg"]);
            sDuration = Convert.ToInt32(sData.skillValues[level]["Time"]);
        }
    }
}
