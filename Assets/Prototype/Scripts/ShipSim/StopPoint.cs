using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.LastShipToTauCeti
{
    public class StopPoint : MonoBehaviour
    {
        [SerializeField]
        private ObjectThruster thruster;

        [SerializeField]
        private Rigidbody2D rb;

        // Update is called once per frame
        void Update()
        {
            float accel = thruster.MaxThrust / rb.mass;
            float d = rb.velocity.sqrMagnitude / (2 * accel);
            transform.position = rb.position + (rb.velocity.normalized * d);
        }
    }
}
