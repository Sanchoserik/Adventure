using Assets.Code.SystemScripts.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters
{
    public interface IActionsFactory
    {
        A_MonsterAction createMAction(MonsterActionsData aData);
    }
}
