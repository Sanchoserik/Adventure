using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;
using Assets.PlayerController;

namespace Assets.Code.Skills.Warrior
{
    [Serializable]
    public class SkillStoneSkin : A_Skill
    {
        int earthDefAdd;
        int waterDefAdd;
        int physDefAdd;
        int fireDefAdd;
        int darknessDefAdd;

        int sDuration;

        public SkillStoneSkin(string sName, string sUnlocker, string[] sToUnlock, bool isAvailableForLearning) : base(sName, sUnlocker, sToUnlock, isAvailableForLearning)
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

            earthDefAdd = Convert.ToInt32(sData.skillValues[level]["EarthDefAdd"]);
            waterDefAdd = Convert.ToInt32(sData.skillValues[level]["WaterDefAdd"]);
            physDefAdd = Convert.ToInt32(sData.skillValues[level]["PhysDefAdd"]);

            if(sData.skillValues[level].ContainsKey("FireDefAdd"))
                fireDefAdd = Convert.ToInt32(sData.skillValues[level]["FireDefAdd"]);

            if (sData.skillValues[level].ContainsKey("DarknessDefAdd"))
                darknessDefAdd = Convert.ToInt32(sData.skillValues[level]["DarknessDefAdd"]);

            sDuration = Convert.ToInt32(sData.skillValues[level]["Time"]);
        }
    }
}
