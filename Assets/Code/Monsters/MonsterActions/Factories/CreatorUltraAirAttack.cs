﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Code.SystemScripts.DataStructures;

namespace Assets.Code.Monsters.MonsterActions.Factories
{
    public class CreatorUltraAirAttack : IActionsFactory
    {
        public A_MonsterAction createMAction(MonsterActionsData aData) => new UltraAirAttack(
          aData.actionName,
          Convert.ToInt32(aData.actionParameters["APPrice"]),
          Convert.ToInt32(aData.actionParameters["ENEPrice"]),
          Convert.ToInt32(aData.actionParameters["CoolDownTime"]),
          aData.actionParameters["Element"],
          Convert.ToInt32(aData.actionParameters["ATKVal"]));
    }
}
