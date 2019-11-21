using Assets.Code.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code.BattleArena
{
    public struct monsterCoordinates
    {
        public int x;
        public int y;

        public monsterCoordinates(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }

    public enum battlefieldsSizes
    { 
      s3x3, s3x4, s3x5, s3x6, s4x3, s4x4, s4x5, s4x6, s5x3, s5x4, s5x5
      // and special arenas for bosses
    }
    
    public class Battlefield
    {
        public string arenaName;
        public string sizeName;
        public int sizeX;
        public int sizeY;
        public int totalSize;

        public Dictionary<monsterCoordinates, A_Monster> monstersCoordinatesDict;
        public int[,] arenaArray;
        
        private Dictionary<string, int[,]> arenaSizes = new Dictionary<string, int[,]>{
            {"3x3", new int[3,3] }, {"3x4", new int[3,4] }, {"3x5", new int[3,5] }, {"3x6", new int[3,6] },
            {"4x3", new int[4,3] }, {"4x4", new int[4,4] }, {"4x5", new int[4,5] }, {"4x6", new int[4,6] },
            {"5x3", new int[5,3] }, {"5x4", new int[5,4] }, {"5x5", new int[5,5] }
        };


        public Battlefield(string aName, string sName, int sX, int sY)
        {
            arenaName = aName;
            sizeName = sName;
            sizeX = sX;
            sizeY = sY;

            monstersCoordinatesDict = new Dictionary<monsterCoordinates, A_Monster>();
            totalSize = sizeX * sizeY;
            arenaArray = new int[sizeX, sizeY];
        }

        public void setupMonstersOnBattlefield(List<A_Monster> generatedPack)
        {        
            if (generatedPack.Count <= totalSize)
            {
                foreach (A_Monster monster in generatedPack)
                {
                    monsterCoordinates newMCors = generateRandomFreeCors();
                    monstersCoordinatesDict.Add(newMCors, monster);
                }
            }
            else
            {
                for (int i = 0; i <= totalSize; ++i)
                {
                    monsterCoordinates newMCors = generateRandomFreeCors();
                    monstersCoordinatesDict.Add(newMCors, generatedPack[i]);
                }
            }
        }

        private monsterCoordinates generateRandomFreeCors()
        {
            Random random = new Random();
            
            while (true)
            {
                int corX = random.Next(0, sizeX);
                int corY = random.Next(0, sizeY);

                if (arenaArray[corX, corY] == 0)
                {
                    arenaArray[corX, corY] = 1;
                    return new monsterCoordinates(corX, corY);
                }
            }
        }
    }
}
