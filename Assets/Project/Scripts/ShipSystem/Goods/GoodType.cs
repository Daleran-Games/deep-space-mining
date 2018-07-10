using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.LastShupToTauCeti
{
    public class GoodType : Enumeration
    {
        public static readonly GoodType Null = new GoodType(-1, "Null");
        public static readonly GoodType Fuel = new GoodType(0, "Fuel");
        public static readonly GoodType Power = new GoodType(1, "Power");

        public GoodType() { }

        protected GoodType(int value, string displayName) : base(value, displayName)
        {

        }

    }

}
