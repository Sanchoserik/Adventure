using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using Assets.Monsters;

namespace Assets.Skills
{
    public abstract class A_Skill
    {
       public int flag;
       public string dataFileName;
       public dataFileReader dfReader;

       public int APcost;
       public int levels;

     
    }
}
