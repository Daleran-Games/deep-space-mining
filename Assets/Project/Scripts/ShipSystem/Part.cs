using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.LastShupToTauCeti
{
    public class Part : MonoBehaviour, IPrioritizable
    {
        [SerializeField]
        string partName = "Default Part";
        public string PartName { get { return partName; } }


        [SerializeField]
        int priority = 0;
        public int Priority  { get { return priority; } }

        public event System.Action<bool> PartToggled;

        protected void OnEnable()
        {
            PartToggled?.Invoke(true);
        }

        protected void OnDisable()
        {
            PartToggled?.Invoke(false);
        }

    }

}
