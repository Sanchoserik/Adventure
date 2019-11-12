using Assets.Code.BattleArena;
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
        
        public C_Hero mainHero;
        public Battlefield arenaField;

        public void Start()
        {
            Grid grid = battlefieldTilemap.layoutGrid;

            TileBase tile = battlefieldTilemap.GetTile(new Vector3Int(3,3,1));

            BoundsInt mbounds = battlefieldTilemap.cellBounds;

            Instantiate(enemySpritePrefab, new Vector3(0, 0, 1),new Quaternion(), battlefieldTilemap.transform);
            Instantiate(enemySpritePrefab, new Vector3(1, 0, 1), new Quaternion(), battlefieldTilemap.transform);
            Instantiate(enemySpritePrefab, new Vector3(1, 1, 1), new Quaternion(), battlefieldTilemap.transform);
            Instantiate(enemySpritePrefab, new Vector3(-2, 2, 1), new Quaternion(), battlefieldTilemap.transform);
            Instantiate(enemySpritePrefab, new Vector3(3, 0, 1), new Quaternion(), battlefieldTilemap.transform);
            Instantiate(enemySpritePrefab, new Vector3(0, 3, 1), new Quaternion(), battlefieldTilemap.transform);

            int xx = 20;
        }

    }
}
