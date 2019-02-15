using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Skills
{
    public interface ISkillFabric
    {
        A_Skill createSkillAllIn();
        A_Skill createSkillComboCharge();
        A_Skill createSkillCounterAnalysis();
        A_Skill createSkillCriticalBalance();
        A_Skill createSkillDestruction();
        A_Skill createSkillIronDefence();
        A_Skill createSkillOvercharge();
        A_Skill createSkillRearm();
        A_Skill createSkillTacticalRecharge();
        A_Skill createSkillTacticalRetreat();
        A_Skill createSkillSynchronyzation();
        A_Skill createSkillTacticalPreparation();
        A_Skill createSkillTacticalSwap();

        A_Skill createSkillAbsoluteDarkness();
        A_Skill createSkillCounterAttack();
        A_Skill createSkillCursedSign();
        A_Skill createSkillDarkDemon();
        A_Skill createSkillDarkVortex();
        A_Skill createSkillEarthDestruction();
        A_Skill createSkillFinnishingBlow();
        A_Skill createSkillPerfectWarrior();
        A_Skill createSkillRegeneration();
        A_Skill createSkillRicochet();
        A_Skill createSkillStoneSkin();
        A_Skill createSkillTripleCut();
        A_Skill createSkillTsunami();
        A_Skill createSkillWaterPrison();

        A_Skill createSkillAssassination();
        A_Skill createSkillBurnout();
        A_Skill createSkillDoubleStrike();
        A_Skill createSkillEvasion();
        A_Skill createSkillFasterThanLight();
        A_Skill createSkillFireClaw();
        A_Skill createSkillGehena();
        A_Skill createSkillLethalTempo();
        A_Skill createSkillPiercingLight();
        A_Skill createSkillPiercingStrike();
        A_Skill createSkillReleasedStream();
        A_Skill createSkillShiningCloak();
        A_Skill createSkillTornado();
        A_Skill createSkillWindBLade();

        A_Skill createSkillAnarchy();
        A_Skill createSkillBlocking();
        A_Skill createSkillDeathBlossom();
        A_Skill createSkillDeathSign();
        A_Skill createSkillDelayedDeath();
        A_Skill createSkillDevouring();
        A_Skill createSkillElectrification();
        A_Skill createSkillEvolution();
        A_Skill createSkillFaceOfDeath();
        A_Skill createSkillHarvesting();
        A_Skill createSkillLifeDrain();
        A_Skill createSkillLightningChain();
        A_Skill createSkillThunderstorm();
        A_Skill createSkillWideSwing();
    }
}
