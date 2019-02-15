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

        }

        //load hero skill list from file
        //public HeroSkillsController(List<SkillDataStorage> data HeroSkillsData data1)
        //{

        //}
    }
}
