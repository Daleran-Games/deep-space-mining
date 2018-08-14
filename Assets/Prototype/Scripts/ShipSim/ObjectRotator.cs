using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.LastShipToTauCeti
{
    public class ObjectRotator : MonoBehaviour
    {
        [SerializeField]
        private float maxTorque;
        public float MaxTorque
        {
            get { return maxTorque; }
            set
            {
                maxTorque = value;
                rb.angularDrag = maxTorque;
            }
        }

        [SerializeField]
        [ReadOnly]
        private float torque = 0;
        public float Torque
        {
            get { return torque; }
            set { torque = Mathf.Clamp(value, -1f, 1f); }
        }

        [SerializeField]
        private Rigidbody2D rb;

        private void Awake()
        {
            if (rb == null)
                rb = gameObject.GetRequiredComponent<Rigidbody2D>();
        }

        private void OnEnable()
        {
            rb.angularDrag = maxTorque;
        }

        private void OnDisable()
        {
            rb.angularDrag = 0f;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Torque != 0)
                rb.MoveRotation(rb.rotation - (MaxTorque / rb.mass)* Torque * Time.fixedDeltaTime);

        }
    }
}