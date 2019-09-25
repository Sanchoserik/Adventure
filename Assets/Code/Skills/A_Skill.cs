using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Code.Skills.Assassin;
using Assets.Code.Skills.Bruiser;
using Assets.Code.Skills.Tactics;
using Assets.Code.Skills.Warrior;
using Assets.PlayerController;
using UnityEngine;

namespace Assets.Code.Skills
{
    [Serializable]
    [XmlInclude(typeof(SkillAllIn))]
    [XmlInclude(typeof(SkillComboCharge))]
    [XmlInclude(typeof(SkillCounterAnalysis))]
    [XmlInclude(typeof(SkillCriticalBalance))]
    [XmlInclude(typeof(SkillDestruction))]
    [XmlInclude(typeof(SkillIronDefence))]
    [XmlInclude(typeof(SkillOvercharge))]
    [XmlInclude(typeof(SkillRearm))]
    [XmlInclude(typeof(SkillTacticalRetreat))]
    [XmlInclude(typeof(SkillTacticalRecharge))]
    [XmlInclude(typeof(SkillSynchronization))]
    [XmlInclude(typeof(SkillTacticalPreparation))]
    [XmlInclude(typeof(SkillTacticalSwap))]
    [XmlInclude(typeof(SkillAssassination))]
    [XmlInclude(typeof(SkillBurnout))]
    [XmlInclude(typeof(SkillDoubleStrike))]
    [XmlInclude(typeof(SkillEvasion))]
    [XmlInclude(typeof(SkillFasterThanLight))]
    [XmlInclude(typeof(SkillFireClaw))]
    [XmlInclude(typeof(SkillGehenna))]
    [XmlInclude(typeof(SkillLethalTempo))]
    [XmlInclude(typeof(SkillPiercingLight))]
    [XmlInclude(typeof(SkillPiercingStrike))]
    [XmlInclude(typeof(SkillReleasedStream))]
    [XmlInclude(typeof(SkillShiningCloak))]
    [XmlInclude(typeof(SkillTornado))]
    [XmlInclude(typeof(SkillWindBlade))]
    [XmlInclude(typeof(SkillAnarchy))]
    [XmlInclude(typeof(SkillBlocking))]
    [XmlInclude(typeof(SkillDeathBlossom))]
    [XmlInclude(typeof(SkillDeathSign))]
    [XmlInclude(typeof(SkillDelayedDeath))]
    [XmlInclude(typeof(SkillDevouring))]
    [XmlInclude(typeof(SkillElectrification))]
    [XmlInclude(typeof(SkillEvolution))]
    [XmlInclude(typeof(SkillFaceOfDeath))]
    [XmlInclude(typeof(SkillHarvesting))]
    [XmlInclude(typeof(SkillLifeDrain))]
    [XmlInclude(typeof(SkillLightningChain))]
    [XmlInclude(typeof(SkillThunderstorm))]
    [XmlInclude(typeof(SkillWideSwing))]
    [XmlInclude(typeof(SkillAbsoluteDarkness))]
    [XmlInclude(typeof(SkillCounterAttack))]
    [XmlInclude(typeof(SkillCursedSign))]
    [XmlInclude(typeof(SkillDarkDemon))]
    [XmlInclude(typeof(SkillDarkVortex))]
    [XmlInclude(typeof(SkillEarthDestruction))]
    [XmlInclude(typeof(SkillFinnishingBlow))]
    [XmlInclude(typeof(SkillPerfectWarrior))]
    [XmlInclude(typeof(SkillRegeneration))]
    [XmlInclude(typeof(SkillRicochet))]
    [XmlInclude(typeof(SkillStoneSkin))]
    [XmlInclude(typeof(SkillStoneSkin))]
    [XmlInclude(typeof(SkillTripleCut))]
    [XmlInclude(typeof(SkillTsunami))]
    [XmlInclude(typeof(SkillWaterPrison))]
    public abstract class A_Skill
    {
        public string skillName;
        public bool isAvailableForLearning;
        public bool isLearned;
        public short skillLevel;
        public short skillMaxLevel;

        public short energyCost;
        public short actionPointsCost;
        public short skillDuration;
        public SkillTargets skillTargets;

        public string skillUnlocker;
        public string[] skillsToUnlock;

        public A_Skill(string _name, string _skillUnlocker,string[] _skillsToUnlock, bool _isAvailableForLearning)
        {
            skillName = _name;
            isLearned = false;
            isAvailableForLearning = _isAvailableForLearning;
            skillLevel = 0;
            skillUnlocker = _skillUnlocker;
            skillsToUnlock = _skillsToUnlock;
        }

        public A_Skill() { }

        public abstract void callSkill(C_Hero user);
        //TO DO - add other signatures for callSkipll like (C_Monster user) etc.

        public static void bindSkillData()
        {
            // 
        }
    }
}
