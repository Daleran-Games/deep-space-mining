using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DaleranGames.SpaceTycoon
{
    public class Route : MonoBehaviour
    {
        [SerializeField]
        List<GoodStorage> nodes;
        public List<GoodStorage> Nodes { get { return new List<GoodStorage>(nodes); } }


        public event Action RouteChanged;
        

        
    }
}

