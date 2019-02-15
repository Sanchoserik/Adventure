using Assets.Code.Skills.Tactics;
using Assets.Code.Skills.Warrior;
using Assets.Code.Skills.Assassin;
using Assets.Code.Skills.Bruiser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Skills
{
    class SkillFabric : ISkillFabric
    {
        public A_Skill createSkillAbsoluteDarkness()
        {
            return new   SkillAbsoluteDarkness("AbsoluteDarkness", 3, false);
        }

        public A_Skill createSkillAllIn()
        {
            return new SkillAllIn("AllIn", 2, false);
        }

        public A_Skill createSkillAnarchy()
        {
            return new   SkillAnarchy("Anarchy", 3, false);
        }

        public A_Skill createSkillAssassination()
        {
            return new   SkillAssassination("Assassination", 5, false);
        }

        public A_Skill createSkillBlocking()
        {
            return new   SkillBlocking("Blocking", 5, false);
        }

        public A_Skill createSkillBurnout()
        {
            return new   SkillBurnout("Burnout", 3, false);
        }

        public A_Skill createSkillComboCharge()
        {
            return new   SkillComboCharge("ComboCharge", 1, false);
        }

        public A_Skill createSkillCounterAnalysis()
        {
            return new   SkillCounterAnalysis("CounterAnalysis", 1, false);
        }

        public A_Skill createSkillCounterAttack()
        {
            return new   SkillCounterAttack("Counterattack", 5, false);
        }

        public A_Skill createSkillCriticalBalance()
        {
            return new   SkillCriticalBalance("CriticalBalance", 3, false);
        }

        public A_Skill createSkillCursedSign()
        {
            return new   SkillCursedSign("CursedSign", 3, false);
        }

        public A_Skill createSkillDarkDemon()
        {
            return new   SkillDarkDemon("DarkDemon", 5, false);
        }

        public A_Skill createSkillDarkVortex()
        {
            return new   SkillDarkVortex("DarkVortex", 5, false);
        }

        public A_Skill createSkillDeathBlossom()
        {
            return new   SkillDeathBlossom("DeathBlossom", 4, false);
        }

        public A_Skill createSkillDeathSign()
        {
            return new   SkillDeathSign("DeathSign", 3, false);
        }

        public A_Skill createSkillDelayedDeath()
        {
            return new   SkillDelayedDeath("DelayedDeath", 4, false);
        }

        public A_Skill createSkillDestruction()
        {
            return new   SkillDestruction("Destruction", 5, false);
        }

        public A_Skill createSkillDevouring()
        {
            return new   SkillDevouring("Devouring", 2, false);
        }

        public A_Skill createSkillDoubleStrike()
        {
            return new   SkillDoubleStrike("DoubleStrike", 5, false);
        }

        public A_Skill createSkillEarthDestruction()
        {
            return new   SkillEarthDestruction("EarthDestruction", 5, false);
        }

        public A_Skill createSkillElectrification()
        {
            return new   SkillElectrification("Electrification", 3, false);
        }

        public A_Skill createSkillEvasion()
        {
            return new   SkillEvasion("Evasion", 5, false);
        }

        public A_Skill createSkillEvolution()
        {
            return new   SkillEvolution("Evolution", 2, false);
        }

        public A_Skill createSkillFaceOfDeath()
        {
            return new   SkillFaceOfDeath("FaceOfDeath", 5, false);
        }

        public A_Skill createSkillFasterThanLight()
        {
            return new   SkillFasterThanLight("FsterThanLight", 3, false);
        }

        public A_Skill createSkillFinnishingBlow()
        {
            return new   SkillFinnishingBlow("FinishingBlow", 4, false);
        }

        public A_Skill createSkillFireClaw()
        {
            return new   SkillFireClaw("FireClaw", 5, false);
        }

        public A_Skill createSkillGehena()
        {
            return new   SkillGehenna("Gehena", 5, false);
        }

        public A_Skill createSkillHarvesting()
        {
            return new   SkillHarvesting("Harvesting", 3, false);
        }

        public A_Skill createSkillIronDefence()
        {
            return new  SkillIronDefence("IronDefence", 1, false);
        }

        public A_Skill createSkillLethalTempo()
        {
            return new   SkillLethalTempo("LethalTempo", 3, false);
        }

        public A_Skill createSkillLifeDrain()
        {
            return new   SkillLifeDrain("LifeDrain", 4, false);
        }

        public A_Skill createSkillLightningChain()
        {
            return new   SkillLightningChain("LightningChain", 6, false);
        }

        public A_Skill createSkillOvercharge()
        {
            return new   SkillOvercharge("Overcharge", 3, false);
        }

        public A_Skill createSkillPerfectWarrior()
        {
            return new   SkillPerfectWarrior("PerfectWarrior", 3, false);
        }

        public A_Skill createSkillPiercingLight()
        {
            return new   SkillPiercingLight("PiercingLight", 6, false);
        }

        public A_Skill createSkillPiercingStrike()
        {
            return new   SkillPiercingStrike("PiercingStrike", 3, false);
        }

        public A_Skill createSkillRearm()
        {
            return new   SkillRearm("Rearm", 1, true);
        }

        public A_Skill createSkillTacticalRecharge()
        {
            return new   SkillTacticalRecharge("TacticalRecharge", 4, false);
        }

        public A_Skill createSkillRegeneration()
        {
            return new   SkillRegeneration("Regeneration", 3, false);
        }

        public A_Skill createSkillReleasedStream()
        {
            return new   SkillReleasedStream("ReleasedStream", 5, false);
        }

        public A_Skill createSkillTacticalRetreat()
        {
            return new   SkillTacticalRetreat("TacticalRetreat", 4, false);
        }

        public A_Skill createSkillRicochet()
        {
            return new   SkillRicochet("Ricochet", 3, false);
        }

        public A_Skill createSkillShiningCloak()
        {
            return new   SkillShiningCloak("ShiningCloak", 4, false);
        }

        public A_Skill createSkillStoneSkin()
        {
            return new   SkillStoneSkin("StoneSkin", 3, false);
        }

        public A_Skill createSkillSynchronyzation()
        {
            return new   SkillSynchronization("Synchronization", 4, false);
        }

        public A_Skill createSkillTacticalPreparation()
        {
            return new   SkillTacticalPreparation("TacticalPreparation", 2, false);
        }

        public A_Skill createSkillTacticalSwap()
        {
            return new   SkillTacticalSwap("TacticalSwap", 1, false);
        }

        public A_Skill createSkillThunderstorm()
        {
            return new   SkillThunderstorm("ThundeStorm", 3, false);
        }

        public A_Skill createSkillTornado()
        {
            return new   SkillTornado("Tornado", 3, false);
        }

        public A_Skill createSkillTripleCut()
        {
            return new   SkillTripleCut("TripleCut", 5, false);
        }

        public A_Skill createSkillTsunami()
        {
            return new   SkillTsunami("Tsunami", 5, false);
        }

        public A_Skill createSkillWaterPrison()
        {
            return new   SkillWaterPrison("WaterPrison", 3, false);
        }

        public A_Skill createSkillWideSwing()
        {
            return new   SkillWideSwing("WideSwing", 5, false);
        }

        public A_Skill createSkillWindBLade()
        {
            return new   SkillWindBlade("WindBlade", 5, false);
        }
    }
}
