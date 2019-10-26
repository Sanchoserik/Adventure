using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.Skills
{
    public interface ISkillFactory
    {
        A_Skill createSkill();
    }
}
