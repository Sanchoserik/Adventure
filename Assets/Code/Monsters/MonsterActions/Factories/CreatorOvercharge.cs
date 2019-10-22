using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Monsters.MonsterActions.Factories
{
    public class CreatorOvercharge : IActionsFactory
    {
        public A_MonsterAction createMAction(MonsterActionsData aData) => new Overcharge(
              aData.actionName,
              Convert.ToInt32(aData.actionParameters["APPrice"]),
              Convert.ToInt32(aData.actionParameters["ENEPrice"]),
              Convert.ToInt32(aData.actionParameters["CoolDownTime"]),
              Convert.ToInt32(aData.actionParameters["duration"]),
              Convert.ToInt32(aData.actionParameters["bonusPhysATK%"]),
              Convert.ToInt32(aData.actionParameters["bonusMagATK%"]));
    }
}
