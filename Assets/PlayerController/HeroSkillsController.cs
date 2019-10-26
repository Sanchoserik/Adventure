using Assets.Code.Skills;
using Assets.Code.SystemScripts.DataStructures;
using Assets.Code.UIScripts.SkillTreeScene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.PlayerController
{
    
    public class HeroSkillsController
    {
        enum SkillsList
        {
            SkillAllIn, SkillComboCharge, SkillCounterAnalysis, SkillCriticalBalance, SkillDestruction, SkillIronDefence, SkillOvercharge,
            SkillRearm, SkillSynchronization, SkillTacticalPreparation, SkillTacticalRecharge, SkillTacticalRetreat, SkillTacticalSwap,
            SkillAbsoluteDarkness, SkillCounterAttack, SkillCursedSign, SkillDarkDemon, SkillDarkVortex, SkillEarthDestruction,
            SkillFinnishingBlow, SkillPerfectWarrior, SkillRegeneration, SkillRicochet, SkillStoneSkin, SkillTripleCut, SkillTsunami,
            SkillWaterPrison,
            SkillAssassination, SkillBurnout, SkillDoubleStrike, SkillEvasion, SkillFasterThanLight, SkillFireClaw, SkillGehena,
            SkillLethalTempo, SkillPiercingLight, SkillPiercingStrike, SkillReleasedStream, SkillShiningCloak, SkillTornado, SkillWindBlade,
            SkillAnarchy, SkillBlocking, SkillDeathBlossom, SkillDeathSign, SkillDelayedDeath, SkillDevouring, SkillElectrification, 
            SkillEvolution, SkillFaceOfDeath, SkillHarvesting, SkillLifeDrain, SkillLightningChain, SkillThunderstorm, SkillWideSwing
        }

        readonly Dictionary<SkillsList, ISkillFactory> skillFactories;

        public List<A_Skill> heroSkillsList;

        //standart empty initialisation
        public HeroSkillsController(List<SkillsData> data)
        {
            skillFactories = new Dictionary<SkillsList, ISkillFactory>();

            foreach (SkillsList skill in Enum.GetValues(typeof(SkillsList)))
            {
                var factory = (ISkillFactory)Activator.CreateInstance(Type.GetType("Assets.Code.Skills.Factories.Creator" + Enum.GetName(typeof(SkillsList), skill)));
                skillFactories.Add(skill, factory);
            }

            heroSkillsList = new List<A_Skill>();
            addSkillsInList();

            foreach (A_Skill skill in heroSkillsList)
            {
                skill.skillLevel = 1;
                skill.skillMaxLevel = data.Find(x => x.skillName.Equals(skill.skillName)).skillLevels;                   
            }
        }

        public HeroSkillsController()
        { }

        private void addSkillsInList()
        {
            foreach (KeyValuePair<SkillsList, ISkillFactory> sFact in skillFactories)
            {
                heroSkillsList.Add(sFact.Value.createSkill());
            }        
        }

        public static string getSkillAvailability(A_Skill skill)
        {           
            if (skill.isAvailableForLearning)
            {
                if (skill.isLearned)
                    return "Learned";
                else
                    return "Available";
            }
            else
                return "NotAvailable";
        }

        public static void getNewAvailableSKills(List<A_Skill> _data, string _newLearnedSkillName)
        {
            foreach (A_Skill skill in _data)
            {
                if (skill.skillUnlocker.Equals(_newLearnedSkillName) && !skill.isAvailableForLearning && !skill.isLearned)
                    skill.isAvailableForLearning = true;            
            }
        }

        public static void refreshAvailability(List<A_Skill> _data, string _newLearnedSkillName)
        {
            foreach (A_Skill skill in _data)
            {
                string unlocker = skill.skillUnlocker;

                if(!_data.Find(x => x.skillName.Equals(unlocker)).isLearned)
                {
                    skill.isAvailableForLearning = false;
                    skill.isLearned = false;
                    refundSkillPoints(HeroController.mainHero, skill);
                    skill.skillLevel = 1;
                }
            }
        }

        private static void refundSkillPoints(C_Hero hero, A_Skill skill)
        {
            hero.freeSkillPoints += skill.skillLevel;
        }
        
        public static void setSkillAsLearned(A_Skill skill)
        {
            skill.isLearned = true;
        }

        public static void setSkillAsNotLearned(A_Skill skill)
        {
            skill.isLearned = false;
        }

        public static void cascadeSkillRemoval(List<A_Skill> skillTree, A_Skill skill)
        {
            skill.isLearned = false;
            refundSkillPoints(HeroController.mainHero, skill);
            skill.skillLevel = 1;

            foreach (string _sToUnlock in skill.skillsToUnlock)
            {
                if (!_sToUnlock.Equals(""))
                {
                    A_Skill nextSkill = skillTree.Find(x => x.skillName.Equals(_sToUnlock));
                    if (nextSkill.isLearned)
                    {
                        cascadeSkillRemoval(skillTree, nextSkill);
                    }
                    if (nextSkill.isAvailableForLearning)
                    {
                        nextSkill.isAvailableForLearning = false;
                    }

                }
            }
        }

    }
}
