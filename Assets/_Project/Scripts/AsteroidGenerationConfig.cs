using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace DaleranGames.DeepSpaceMining
{
    public class AsteroidGenerationConfig : ScriptableObject
    {
        #region Public

        #endregion

        #region Dependicies
        [SerializeField]
        Vector2Int radiusRange = new Vector2Int(3, 6);
        [SerializeField]
        TileBase surface;
        [SerializeField]
        TileBase subsurface;
        [SerializeField]
        List<OreGeneration> ores;
        [SerializeField]
        [Range(0, 1)]
        float oreChance = 0f;
        #endregion

        protected class OreGeneration
        {
            public TileBase Ore { get { return ore; } }
            public float OreWeight { get { return oreWeight; } }

            [SerializeField]
            TileBase ore;
            [SerializeField]
            [Range(0, 1)]
            float oreWeight = 0f;

        }

        public void Generate(out DataGrid<TileBase> tiles)
        {

        }

    }
}

