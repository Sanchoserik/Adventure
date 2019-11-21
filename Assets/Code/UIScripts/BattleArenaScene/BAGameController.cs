using Assets.Code.BattleArena;
using Assets.Code.Monsters;
using Assets.PlayerController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Code.UIScripts.BattleArenaScene
{
    public class BAGameController : MonoBehaviour
    {
        public Tilemap battlefieldTilemap;

        public GameObject enemySpritePrefab;

        public GameObject[] arenaPrefabs;

        public C_Hero mainHero;
        public Battlefield arenaField;
        public PackController monsterPackControler;

        public void Start()
        {
            PackGenerator packGen = new PackGenerator();
            packGen.getPack(100, PackGenerator.PackTypes.Casters);
            arenaField = new Battlefield("testArena", "4x4", 4, 4); // test manual init
            arenaField.setupMonstersOnBattlefield(packGen.generatedPack);
        }
 
        public void Update()
        {       
                //Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //Vector3Int tileCor = battlefieldTilemap.WorldToCell(point);
                //battlefieldTilemap.SetTileFlags(tileCor, TileFlags.None);
                //battlefieldTilemap.SetColor(tileCor, Color.black);
                //Debug.Log("Done"+ tileCor);
        }
    }
}
