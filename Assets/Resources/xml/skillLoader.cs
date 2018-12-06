using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Resources.xml
{
    public class skillLoader : MonoBehaviour
    {
        public const string path = "xml/skills";

        void Start()
        {
            SkillContainer cs = SkillContainer.Load(path);

            foreach (Code.Skills.A_Skill skill in cs.skills)
            {
                print(skill.SName);
            }
        }


    }
}
