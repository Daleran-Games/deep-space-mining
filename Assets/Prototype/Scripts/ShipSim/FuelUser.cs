using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

namespace DaleranGames.LastShipToTauCeti
{
    public class FuelUser : MonoBehaviour
    {
        [SerializeField]
        ObjectThruster thruster;

        [SerializeField]
        private float stored;
        public float Stored
        {
            get { return stored; }
            set
            {
                stored = Mathf.Clamp(value, 0f, Capacity);
            }
        }

        [SerializeField]
        private float capacity;
        public float Capacity
        {
            get { return capacity; }
            
        }

        [SerializeField]
        float fuelRate = 1f;

        public event Action Changed;

        // Update is called once per frame
        void Update()
        {
            TryWithdraw(thruster.Thrust * fuelRate * Time.deltaTime);
        }

        public float TryWithdraw(float amount)
        {
            float left = Capacity - Stored;

            if (amount < 0)
            {
                Debug.LogError("A negative amount is being withdrawn from " + name);
                return 0;
            }
            else if (amount <= Stored)
            {
                Stored -= amount;
                Changed?.Invoke();
                return amount;
            }
            else
            {
                float oldStored = Stored;
                Stored = 0;
                thruster.enabled = false;
                Changed?.Invoke();
                return oldStored;
            }
        }

        public float TryDeposit(float amount)
        {
            float left = Capacity - Stored;

            if (amount < 0)
            {
                Debug.LogError("A negative amount is being deposited into " + name);
                return 0;
            }
            else if (amount <= left)
            {
                Stored += amount;
                thruster.enabled = true;
                Changed?.Invoke();
                return amount;
            }
            else
            {
                float toAdd = amount - left;
                thruster.enabled = true;
                Stored += toAdd;
                Changed?.Invoke();
                return toAdd;
            }
        }

        public void OnValidate()
        {
            Changed?.Invoke();
        }


    }
}