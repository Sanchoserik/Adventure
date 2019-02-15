using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Assets.Monsters;
using Assets.PlayerController;
using UnityEngine;

namespace Assets.Code.Skills
{
   
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

        public A_Skill(string _name, short _maxLevel, bool _isAvailableForLearning)
        {
            skillName = _name;
            isLearned = false;
            isAvailableForLearning = _isAvailableForLearning;
            skillLevel = 0;
            skillMaxLevel = _maxLevel;

        }

        public abstract void callSkill(C_Hero user);
        //TO DO - add other signatures for callSkipll like (C_Monster user) etc.

        public static void bindSkillData()
        {
            // 
        }
    }
}
