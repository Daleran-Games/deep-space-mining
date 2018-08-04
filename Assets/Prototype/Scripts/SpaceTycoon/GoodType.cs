using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.SpaceTycoon
{
    [System.Serializable]
    [CreateAssetMenu(fileName ="NewGoodType", menuName = "Data/GoodType", order = 20)]
    public class GoodType : ScriptableObject
    {
        [SerializeField]
        Sprite icon;
        public Sprite Icon { get { return icon; } }
        
    }
}
