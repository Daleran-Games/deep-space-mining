using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.LastShipToTauCeti
{
    public class RefuelStation : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            FuelUser fuel = collision.GetComponentInChildren<FuelUser>();

            if (fuel != null)
                fuel.TryDeposit(fuel.Capacity);
        }
    }
}

