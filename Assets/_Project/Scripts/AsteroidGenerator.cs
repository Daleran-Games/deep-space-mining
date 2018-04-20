using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

namespace DaleranGames.DeepSpaceMining
{
    public class AsteroidGenerator : MonoBehaviour
    {

        #region Dependicies
        [SerializeField]
        AsteroidGenerationConfig config;
        [SerializeField]
        Tilemap asteroid;
        #endregion

        [ContextMenu("Generate")]
        public void Generate()
        {
            Clear();
            DataGrid<TileBase> tiles;
            DataGrid<TileBase> subsurfaceTiles;
            config.Generate(out tiles, out objects, Vector3Int.zero);
            Terrain.SetTiles(tiles.Positions, tiles.Values);
        }

        [ContextMenu("Clear")]
        public void Clear()
        {
            subsrface?.ClearAllTiles();
            surface?.ClearAllTiles();
        }

        // Use this for initialization
        void Start()
        {
            Generate();
        }
    }
}

