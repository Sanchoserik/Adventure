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
            return new   SkillAbsoluteDarkness("AbsoluteDarkness", "DarkVortex", false);
        }

        public A_Skill createSkillAllIn()
        {
            return new SkillAllIn("AllIn", "TacticalPreparation", false);
        }

        public A_Skill createSkillAnarchy()
        {
            return new   SkillAnarchy("Anarchy", "Devouring", false);
        }

        public A_Skill createSkillAssassination()
        {
            return new   SkillAssassination("Assassination", "PiercingStrike", false);
        }

        public A_Skill createSkillBlocking()
        {
            return new   SkillBlocking("Blocking", "Rearm", false);
        }

        public A_Skill createSkillBurnout()
        {
            return new   SkillBurnout("Burnout", "FireClaw", false);
        }

        public A_Skill createSkillComboCharge()
        {
            return new   SkillComboCharge("ComboCharge", "CriticalBalance", false);
        }

        public A_Skill createSkillCounterAnalysis()
        {
            return new   SkillCounterAnalysis("CounterAnalysis", "TacticalSwap", false);
        }

        public A_Skill createSkillCounterAttack()
        {
            return new   SkillCounterAttack("Counterattack", "Rearm", false);
        }

        public A_Skill createSkillCriticalBalance()
        {
            return new   SkillCriticalBalance("CriticalBalance", "CounterAnalysis", false);
        }

        public A_Skill createSkillCursedSign()
        {
            return new   SkillCursedSign("CursedSign", "Counterattack", false);
        }

        public A_Skill createSkillDarkDemon()
        {
            return new   SkillDarkDemon("DarkDemon", "AbsoluteDarkness", false);
        }

        public A_Skill createSkillDarkVortex()
        {
            return new   SkillDarkVortex("DarkVortex", "CounterAttack", false);
        }

        public A_Skill createSkillDeathBlossom()
        {
            return new   SkillDeathBlossom("DeathBlossom", "Evolution", false);
        }

        public A_Skill createSkillDeathSign()
        {
            return new   SkillDeathSign("DeathSign", "Blocking", false);
        }

        public A_Skill createSkillDelayedDeath()
        {
            return new   SkillDelayedDeath("DelayedDeath", "DeathSign", false);
        }

        public A_Skill createSkillDestruction()
        {
            return new   SkillDestruction("Destruction", "TacticalRecharge", false);
        }

        public A_Skill createSkillDevouring()
        {
            return new   SkillDevouring("Devouring", "WideSwing", false);
        }

        public A_Skill createSkillDoubleStrike()
        {
            return new   SkillDoubleStrike("DoubleStrike", "Evasion", false);
        }

        public A_Skill createSkillEarthDestruction()
        {
            return new   SkillEarthDestruction("EarthDestruction", "StoneSkin", false);
        }

        public A_Skill createSkillElectrification()
        {
            return new   SkillElectrification("Electrification", "LightningChain", false);
        }

        public A_Skill createSkillEvasion()
        {
            return new   SkillEvasion("Evasion", "Rearm", false);
        }

        public A_Skill createSkillEvolution()
        {
            return new   SkillEvolution("Evolution", "LifeDrain", false);
        }

        public A_Skill createSkillFaceOfDeath()
        {
            return new   SkillFaceOfDeath("FaceOfDeath", "DelayedDeath", false);
        }

        public A_Skill createSkillFasterThanLight()
        {
            return new   SkillFasterThanLight("FsterThanLight", "ShiningCloak", false);
        }

        public A_Skill createSkillFinnishingBlow()
        {
            return new   SkillFinnishingBlow("FinishingBlow", "TripleCut", false);
        }

        public A_Skill createSkillFireClaw()
        {
            return new   SkillFireClaw("FireClaw", "Evasion", false);
        }

        public A_Skill createSkillGehena()
        {
            return new   SkillGehenna("Gehena", "Burnout", false);
        }

        public A_Skill createSkillHarvesting()
        {
            return new   SkillHarvesting("Harvesting", "Anarchy", false);
        }

        public A_Skill createSkillIronDefence()
        {
            return new  SkillIronDefence("IronDefence", "TacticalSwap", false);
        }

        public A_Skill createSkillLethalTempo()
        {
            return new   SkillLethalTempo("LethalTempo", "Assassination", false);
        }

        public A_Skill createSkillLifeDrain()
        {
            return new   SkillLifeDrain("LifeDrain", "Blocking", false);
        }

        public A_Skill createSkillLightningChain()
        {
            return new   SkillLightningChain("LightningChain", "Blocking", false);
        }

        public A_Skill createSkillOvercharge()
        {
            return new   SkillOvercharge("Overcharge", "CriticalBalance", false);
        }

        public A_Skill createSkillPerfectWarrior()
        {
            return new   SkillPerfectWarrior("PerfectWarrior", "Ricochet", false);
        }

        public A_Skill createSkillPiercingLight()
        {
            return new   SkillPiercingLight("PiercingLight", "Evasion", false);
        }

        public A_Skill createSkillPiercingStrike()
        {
            return new   SkillPiercingStrike("PiercingStrike", "DoubleStrike", false);
        }

        public A_Skill createSkillRearm()
        {
            return new   SkillRearm("Rearm", "none", true);
        }

        public A_Skill createSkillTacticalRecharge()
        {
            return new   SkillTacticalRecharge("TacticalRecharge", "TacticalSwap", false);
        }

        public A_Skill createSkillRegeneration()
        {
            return new   SkillRegeneration("Regeneration", "WaterPrison", false);
        }

        public A_Skill createSkillReleasedStream()
        {
            return new   SkillReleasedStream("ReleasedStream", "Tornado", false);
        }

        public A_Skill createSkillTacticalRetreat()
        {
            return new   SkillTacticalRetreat("TacticalRetreat", "TacticalSwap", false);
        }

        public A_Skill createSkillRicochet()
        {
            return new   SkillRicochet("Ricochet", "CursedSign", false);
        }

        public A_Skill createSkillShiningCloak()
        {
            return new   SkillShiningCloak("ShiningCloak", "PiercingLight", false);
        }

        public A_Skill createSkillStoneSkin()
        {
            return new   SkillStoneSkin("StoneSkin", "CounterAttack", false);
        }

        public A_Skill createSkillSynchronyzation()
        {
            return new   SkillSynchronization("Synchronization", "CriticalBalance", false);
        }

        public A_Skill createSkillTacticalPreparation()
        {
            return new   SkillTacticalPreparation("TacticalPreparation", "TacticalRetreat", false);
        }

        public A_Skill createSkillTacticalSwap()
        {
            return new   SkillTacticalSwap("TacticalSwap", "Rearm", false);
        }

        public A_Skill createSkillThunderstorm()
        {
            return new   SkillThunderstorm("ThundeStorm", "Electrification", false);
        }

        public A_Skill createSkillTornado()
        { 
            return new   SkillTornado("Tornado", "Regeneration", false);
        }

        public A_Skill createSkillTripleCut()
        {
            return new   SkillTripleCut("TripleCut", "CounterAttack", false);
        }

        public A_Skill createSkillTsunami()
        {
            return new   SkillTsunami("Tsunami", "Regeneration", false);
        }

        public A_Skill createSkillWaterPrison()
        {
            return new   SkillWaterPrison("WaterPrison", "CounterAttack", false);
        }

        public A_Skill createSkillWideSwing()
        {
            return new   SkillWideSwing("WideSwing", "Blocking", false);
        }

        public A_Skill createSkillWindBLade()
        {
            return new   SkillWindBlade("WindBlade", "Evasion", false);
        }
    }
}
