using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DaleranGames.LastShipToTauCeti
{
    public class FuelGuage : MonoBehaviour
    {
        [SerializeField]
        Slider guage;

        [SerializeField]
        FuelUser fuel;

        // Update is called once per frame
        void Update()
        {
            guage.value = fuel.Stored / fuel.Capacity;
        }
    }
}