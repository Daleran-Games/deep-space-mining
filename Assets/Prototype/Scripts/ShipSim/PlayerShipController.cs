using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.LastShipToTauCeti
{
    public class PlayerShipController : MonoBehaviour
    {
        [SerializeField]
        private ObjectRotator rotator;

        [SerializeField]
        private ObjectThruster thruster;

        [SerializeField]
        [ReadOnly]
        private Vector3 controlVector;

        private void Start()
        {
            if (rotator == null)
                rotator = gameObject.GetRequiredComponent<ObjectRotator>();

            if (thruster == null)
                thruster = gameObject.GetRequiredComponent<ObjectThruster>();
        }

        // Update is called once per frame
        void Update()
        {
            controlVector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Input.GetAxis("Jump"));

            rotator.Torque = controlVector.x;
            thruster.Thrust = controlVector.y;  
            


        }

        private void Brake()
        {

        }
    }
}


