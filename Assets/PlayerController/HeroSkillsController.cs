using Assets.Code.Skills;
using Assets.Code.UIScripts.SkillTreeScene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.PlayerController
{
    
    public class HeroSkillsController
    {
        public List<A_Skill> skillsList;

        //standart initialisation
        public HeroSkillsController(List<SkillDataStorage> data)
        {
            skillsList = new List<A_Skill>();
            addSkillsInList(skillsList);

            foreach (A_Skill skill in skillsList)
            {
                SkillDataStorage _d = data.Find(x => x.skillName.Equals(skill.skillName));
                    skill.skillLevel = 1;
                    skill.skillMaxLevel = _d.skillLevels;                   
            }

        }

        //load hero skill list from file
        //public HeroSkillsController(List<SkillDataStorage> data HeroSkillsData data1)
        //{

        //}

        public HeroSkillsController()
        { }

        private void addSkillsInList(List<A_Skill> slist)
        {
            SkillFabric skillFabric = new SkillFabric();

            slist.Add(skillFabric.createSkillAllIn());
            slist.Add(skillFabric.createSkillComboCharge());
            slist.Add(skillFabric.createSkillCounterAnalysis());
            slist.Add(skillFabric.createSkillCriticalBalance());
            slist.Add(skillFabric.createSkillDestruction());
            slist.Add(skillFabric.createSkillIronDefence());
            slist.Add(skillFabric.createSkillOvercharge());
            slist.Add(skillFabric.createSkillRearm());
            slist.Add(skillFabric.createSkillSynchronyzation());
            slist.Add(skillFabric.createSkillTacticalRetreat());
            slist.Add(skillFabric.createSkillTacticalPreparation());
            slist.Add(skillFabric.createSkillTacticalRecharge());
            slist.Add(skillFabric.createSkillTacticalSwap());

            slist.Add(skillFabric.createSkillAbsoluteDarkness());
            slist.Add(skillFabric.createSkillCounterAttack());
            slist.Add(skillFabric.createSkillCursedSign());
            slist.Add(skillFabric.createSkillDarkDemon());
            slist.Add(skillFabric.createSkillDarkVortex());
            slist.Add(skillFabric.createSkillEarthDestruction());
            slist.Add(skillFabric.createSkillFinnishingBlow());
            slist.Add(skillFabric.createSkillPerfectWarrior());
            slist.Add(skillFabric.createSkillRegeneration());
            slist.Add(skillFabric.createSkillRicochet());
            slist.Add(skillFabric.createSkillStoneSkin());
            slist.Add(skillFabric.createSkillTripleCut());
            slist.Add(skillFabric.createSkillTsunami());
            slist.Add(skillFabric.createSkillWaterPrison());

            slist.Add(skillFabric.createSkillAssassination());
            slist.Add(skillFabric.createSkillBurnout());
            slist.Add(skillFabric.createSkillDoubleStrike());
            slist.Add(skillFabric.createSkillEvasion());
            slist.Add(skillFabric.createSkillFasterThanLight());
            slist.Add(skillFabric.createSkillFireClaw());
            slist.Add(skillFabric.createSkillGehena());
            slist.Add(skillFabric.createSkillLethalTempo());
            slist.Add(skillFabric.createSkillPiercingLight());
            slist.Add(skillFabric.createSkillPiercingStrike());
            slist.Add(skillFabric.createSkillReleasedStream());
            slist.Add(skillFabric.createSkillShiningCloak());
            slist.Add(skillFabric.createSkillTornado());
            slist.Add(skillFabric.createSkillWindBLade());

            slist.Add(skillFabric.createSkillAnarchy());
            slist.Add(skillFabric.createSkillBlocking());
            slist.Add(skillFabric.createSkillDeathBlossom());
            slist.Add(skillFabric.createSkillDeathSign());
            slist.Add(skillFabric.createSkillDelayedDeath());
            slist.Add(skillFabric.createSkillDevouring());
            slist.Add(skillFabric.createSkillElectrification());
            slist.Add(skillFabric.createSkillEvolution());
            slist.Add(skillFabric.createSkillFaceOfDeath());
            slist.Add(skillFabric.createSkillHarvesting());
            slist.Add(skillFabric.createSkillLifeDrain());
            slist.Add(skillFabric.createSkillLightningChain());
            slist.Add(skillFabric.createSkillThunderstorm());
            slist.Add(skillFabric.createSkillWideSwing());
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
