using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DaleranGames.SpaceTycoon
{
    public class GoodStorage : MonoBehaviour
    {
        [SerializeField]
        private GoodType storedType;
        public GoodType StoredType { get { return storedType; } }

        [SerializeField]
        private int stored;
        public int Stored { get { return stored; } }

        [SerializeField]
        private int capacity;
        public int Capacity { get { return capacity; } }

        public event Action Changed;

        public int TryWithdraw(int amount)
        {
            int left = capacity - stored;

            if (amount < 0)
            {
                Debug.LogError("A negative amount is being withdrawn from " + name);
                return 0;
            } else if ( amount <= stored)
            {
                stored -= amount;
                Changed?.Invoke();
                return amount;
            } else
            {
                int oldStored = stored;
                stored = 0;
                Changed?.Invoke();
                return oldStored;
            }
        }

        public int TryDeposit(int amount)
        {
            int left = capacity - stored;

            if (amount < 0)
            {
                Debug.LogError("A negative amount is being deposited into " + name);
                return 0;
            } else if(amount <= left)
            {
                stored += amount;
                Changed?.Invoke();
                return amount;
            }
            else
            {
                int toAdd = amount - left;
                stored += toAdd;
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
