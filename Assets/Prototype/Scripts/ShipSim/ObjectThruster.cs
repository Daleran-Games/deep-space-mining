using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.LastShipToTauCeti
{
    public class ObjectThruster : MonoBehaviour
    {
        [SerializeField]
        private float maxThrust;
        public float MaxThrust
        {
            get { return maxThrust; }
            set { maxThrust = value; }
        }

        [SerializeField]
        private Vector2 direction = Vector2.up;
        public Vector2 Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        [SerializeField]
        [ReadOnly]
        private float thrust = 0;
        public float Thrust
        {
            get { return thrust; }
            set { thrust = Mathf.Clamp(value, 0f, 1f); }
        }

        [SerializeField]
        private Rigidbody2D rb;

        private void Start()
        {
            if (rb == null)
                rb = gameObject.GetRequiredComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Thrust != 0)
                rb.AddRelativeForce(Direction * MaxThrust * Thrust);
        }
    }
}
