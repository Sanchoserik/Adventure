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
            return new SkillAbsoluteDarkness("AbsoluteDarkness", "DarkVortex", new string[] { "DarkDemon"}, false);
        }

        public A_Skill createSkillAllIn()
        {
            return new SkillAllIn("AllIn", "TacticalPreparation", new string[] { "" }, false);
        }

        public A_Skill createSkillAnarchy()
        {
            return new   SkillAnarchy("Anarchy", "Devouring", new string[] { "Harvesting" }, false);
        }

        public A_Skill createSkillAssassination()
        {
            return new   SkillAssassination("Assassination", "PiercingStrike", new string[] { "LethalTempo" }, false);
        }

        public A_Skill createSkillBlocking()
        {
            return new   SkillBlocking("Blocking", "Rearm", new string[] { "WideSwing", "DeathSign", "LightningChain", "LifeDrain" }, false);
        }

        public A_Skill createSkillBurnout()
        {
            return new   SkillBurnout("Burnout", "FireClaw", new string[] { "Gehena" }, false);
        }

        public A_Skill createSkillComboCharge()
        {
            return new   SkillComboCharge("ComboCharge", "CriticalBalance", new string[] { "" }, false);
        }

        public A_Skill createSkillCounterAnalysis()
        {
            return new   SkillCounterAnalysis("CounterAnalysis", "TacticalSwap", new string[] { "CriticalBalance" }, false);
        }

        public A_Skill createSkillCounterAttack()
        {
            return new   SkillCounterAttack("Counterattack", "Rearm", new string[] { "TripleCut", "CursedSign", "StoneSkin",
                "WaterPrison", "DarkVortex" }, false);
        }

        public A_Skill createSkillCriticalBalance()
        {
            return new   SkillCriticalBalance("CriticalBalance", "CounterAnalysis", new string[] { "ComboCharge", "Overcharge",
            "Synchronization"}, false);
        }

        public A_Skill createSkillCursedSign()
        {
            return new   SkillCursedSign("CursedSign", "Counterattack", new string[] { "Ricochet" }, false);
        }

        public A_Skill createSkillDarkDemon()
        {
            return new   SkillDarkDemon("DarkDemon", "AbsoluteDarkness", new string[] { "" }, false);
        }

        public A_Skill createSkillDarkVortex()
        {
            return new   SkillDarkVortex("DarkVortex", "CounterAttack", new string[] { "AbsoluteDarkness" }, false);
        }

        public A_Skill createSkillDeathBlossom()
        {
            return new   SkillDeathBlossom("DeathBlossom", "Evolution", new string[] { "" }, false);
        }

        public A_Skill createSkillDeathSign()
        {
            return new   SkillDeathSign("DeathSign", "Blocking", new string[] { "DelayedDeath" }, false);
        }

        public A_Skill createSkillDelayedDeath()
        {
            return new   SkillDelayedDeath("DelayedDeath", "DeathSign", new string[] { "FaceOfDeath" }, false);
        }

        public A_Skill createSkillDestruction()
        {
            return new   SkillDestruction("Destruction", "TacticalRecharge", new string[] { "" }, false);
        }

        public A_Skill createSkillDevouring()
        {
            return new   SkillDevouring("Devouring", "WideSwing", new string[] { "Anarchy" }, false);
        }

        public A_Skill createSkillDoubleStrike()
        {
            return new   SkillDoubleStrike("DoubleStrike", "Evasion", new string[] { "PiercingStrike" }, false);
        }

        public A_Skill createSkillEarthDestruction()
        {
            return new   SkillEarthDestruction("EarthDestruction", "StoneSkin", new string[] { "" }, false);
        }

        public A_Skill createSkillElectrification()
        {
            return new   SkillElectrification("Electrification", "LightningChain", new string[] { "Thunderstorm" }, false);
        }

        public A_Skill createSkillEvasion()
        {
            return new   SkillEvasion("Evasion", "Rearm", new string[] { "DoubleStrike", "PiercingLight", "FireClaw", "WindBlade" }, false);
        }

        public A_Skill createSkillEvolution()
        {
            return new   SkillEvolution("Evolution", "LifeDrain", new string[] { "DeathBlossom" }, false);
        }

        public A_Skill createSkillFaceOfDeath()
        {
            return new   SkillFaceOfDeath("FaceOfDeath", "DelayedDeath", new string[] { "" }, false);
        }

        public A_Skill createSkillFasterThanLight()
        {
            return new   SkillFasterThanLight("FasterThanLight", "ShiningCloak", new string[] { "" }, false);
        }

        public A_Skill createSkillFinnishingBlow()
        {
            return new   SkillFinnishingBlow("FinishingBlow", "TripleCut", new string[] { "" }, false);
        }

        public A_Skill createSkillFireClaw()
        {
            return new   SkillFireClaw("FireClaw", "Evasion", new string[] { "Burnout" }, false);
        }

        public A_Skill createSkillGehena()
        {
            return new   SkillGehenna("Gehena", "Burnout", new string[] { "" }, false);
        }

        public A_Skill createSkillHarvesting()
        {
            return new   SkillHarvesting("Harvesting", "Anarchy", new string[] { "" }, false);
        }

        public A_Skill createSkillIronDefence()
        {
            return new  SkillIronDefence("IronDefence", "TacticalSwap", new string[] { "" }, false);
        }

        public A_Skill createSkillLethalTempo()
        {
            return new   SkillLethalTempo("LethalTempo", "Assassination", new string[] { "" }, false);
        }

        public A_Skill createSkillLifeDrain()
        {
            return new   SkillLifeDrain("LifeDrain", "Blocking", new string[] { "Evolution" }, false);
        }

        public A_Skill createSkillLightningChain()
        {
            return new   SkillLightningChain("LightningChain", "Blocking", new string[] { "Electrification" }, false);
        }

        public A_Skill createSkillOvercharge()
        {
            return new   SkillOvercharge("Overcharge", "CriticalBalance", new string[] { "" }, false);
        }

        public A_Skill createSkillPerfectWarrior()
        {
            return new   SkillPerfectWarrior("PerfectWarrior", "Ricochet", new string[] { "" }, false);
        }

        public A_Skill createSkillPiercingLight()
        {
            return new   SkillPiercingLight("PiercingLight", "Evasion", new string[] { "ShiningCloak" }, false);
        }

        public A_Skill createSkillPiercingStrike()
        {
            return new   SkillPiercingStrike("PiercingStrike", "DoubleStrike", new string[] { "Assassination" }, false);
        }

        public A_Skill createSkillRearm()
        {
            return new   SkillRearm("Rearm", "none", new string[] { "TacticalSwap", "CounterAttack",
                "Evasion", "Blocking" }, true);
        }

        public A_Skill createSkillTacticalRecharge()
        {
            return new   SkillTacticalRecharge("TacticalRecharge", "TacticalSwap", new string[] { "Destruction" }, false);
        }

        public A_Skill createSkillRegeneration()
        {
            return new   SkillRegeneration("Regeneration", "WaterPrison", new string[] { "Tsunami" }, false);
        }

        public A_Skill createSkillReleasedStream()
        {
            return new   SkillReleasedStream("ReleasedStream", "Tornado", new string[] { "" }, false);
        }

        public A_Skill createSkillTacticalRetreat()
        {
            return new   SkillTacticalRetreat("TacticalRetreat", "TacticalSwap", new string[] { "TacticalPreparation" }, false);
        }

        public A_Skill createSkillRicochet()
        {
            return new   SkillRicochet("Ricochet", "CursedSign", new string[] { "PerfectWarrior" }, false);
        }

        public A_Skill createSkillShiningCloak()
        {
            return new   SkillShiningCloak("ShiningCloak", "PiercingLight", new string[] { "FasterThanLight" }, false);
        }

        public A_Skill createSkillStoneSkin()
        {
            return new   SkillStoneSkin("StoneSkin", "CounterAttack", new string[] { "EarthDestruction" }, false);
        }

        public A_Skill createSkillSynchronyzation()
        {
            return new   SkillSynchronization("Synchronization", "CriticalBalance", new string[] { "" }, false);
        }

        public A_Skill createSkillTacticalPreparation()
        {
            return new   SkillTacticalPreparation("TacticalPreparation", "TacticalRetreat", new string[] { "AllIn" }, false);
        }

        public A_Skill createSkillTacticalSwap()
        {
            return new   SkillTacticalSwap("TacticalSwap", "Rearm", new string[] { "TacticalRetreat", "TacticalRecharge",
                "CounterAnalysis", "IronDefence"}, false);
        }

        public A_Skill createSkillThunderstorm()
        {
            return new   SkillThunderstorm("ThundeStorm", "Electrification", new string[] { "" }, false);
        }

        public A_Skill createSkillTornado()
        { 
            return new   SkillTornado("Tornado", "Regeneration", new string[] { "ReleasedStream" }, false);
        }

        public A_Skill createSkillTripleCut()
        {
            return new   SkillTripleCut("TripleCut", "CounterAttack", new string[] { "FinishingBlow" }, false);
        }

        public A_Skill createSkillTsunami()
        {
            return new   SkillTsunami("Tsunami", "Regeneration", new string[] { "" }, false);
        }

        public A_Skill createSkillWaterPrison()
        {
            return new   SkillWaterPrison("WaterPrison", "CounterAttack", new string[] { "Regeneration" }, false);
        }

        public A_Skill createSkillWideSwing()
        {
            return new   SkillWideSwing("WideSwing", "Blocking", new string[] { "Devouring" }, false);
        }

        public A_Skill createSkillWindBLade()
        {
            return new   SkillWindBlade("WindBlade", "Evasion", new string[] { "Tornado" }, false);
        }
    }
}
