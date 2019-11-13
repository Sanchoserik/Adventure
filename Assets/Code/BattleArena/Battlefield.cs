using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.BattleArena
{
    public class Battlefield
    {
        public int sizeX;
        public int sizeY;

        private Dictionary<string, int[,]> arenaSizes = new Dictionary<string, int[,]>{
            {"3x3", new int[3,3] }, {"3x4", new int[3,4] }, {"3x5", new int[3,5] }, {"3x6", new int[3,6] },
            {"4x3", new int[4,3] }, {"4x4", new int[4,4] }, {"4x5", new int[4,5] }, {"4x6", new int[4,6] },
            {"5x3", new int[5,3] }, {"5x4", new int[5,4] }, {"5x5", new int[5,5] }
        };


        public int[,] arena;

        
    }
}
