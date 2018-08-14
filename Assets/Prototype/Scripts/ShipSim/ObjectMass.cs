using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.LastShipToTauCeti
{
    public class ObjectMass : MonoBehaviour
    {
        [SerializeField]
        float mass = 1f;
        public float Mass
        {
            get { return mass; }
            set
            {
                mass = value;
                UpdateMass();
            }
        }


        [SerializeField]
        private Rigidbody2D rb;

        // Use this for initialization
        void Start()
        {
            if (rb == null)
                rb = gameObject.GetRequiredComponent<Rigidbody2D>();

            UpdateMass();
        }

        private void OnValidate()
        {
            UpdateMass();
        }

        private void UpdateMass()
        {
            rb.mass = mass;
        }

    }
}

