using Assets.Code.Monsters.NeuralWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Code.Monsters
{
    public class PackController
    {
        public List<A_Monster> monsters;
        public List<coordinatates> monstersCors;

        public StrategicNeuralLayer strategicLayer;


        public struct coordinatates
        {
            int corX;
            int corY;
        }

        public void doStrategicCalculations()
        {

        }

        public void makeTurn()
        {

        }
    }
}
