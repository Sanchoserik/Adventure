﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Code.Skills.Assassin;
using Assets.Code.Skills.Bruiser;
using Assets.Code.Skills.Tactics;
using Assets.Code.Skills.Warrior;
using Assets.Code.SystemScripts.DataStructures;
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
        public int skillLevel;
        public int skillMaxLevel;

        public int priceENE;
        public int priceAP;
        public int skillCooldown;          
        public SkillTargets skillTargets;

        public string skillUnlocker;
        public string[] skillsToUnlock;

        //skill level 0 initialization
        public A_Skill(string sName, string sUnlocker, string[] sToUnlock, bool isAvbForLearning)
        {
            skillName = sName;         
            isLearned = false;
            isAvailableForLearning = isAvbForLearning;
            skillLevel = 0;
            skillUnlocker = sUnlocker;
            skillsToUnlock = sToUnlock;
        }

        public abstract void levelXInit(SkillsData sData, int level);
        public abstract void callSkill(C_Hero user);
        //TO DO - add other signatures for callSkipll like (C_Monster user) etc.
    }
}
