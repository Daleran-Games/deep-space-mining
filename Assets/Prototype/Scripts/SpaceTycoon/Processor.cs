using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.SpaceTycoon
{
    public class Processor : MonoBehaviour
    {
        [SerializeField]
        GoodStorage input;
        [SerializeField]
        GoodStorage output;

        [SerializeField]
        int rate = 1;

        [SerializeField]
        float productionTime = 5f;
        public float ProductionTime { get { return productionTime; } }

        
        float progress = 0f;
        public float Progress { get { return progress; } }


        private void Start()
        {
            input.Changed += OnInputChange;
            output.Changed += OnOutputChange;

            OnInputChange();
            OnOutputChange();
        }

        private void OnDestroy()
        {
            input.Changed -= OnInputChange;
            output.Changed -= OnOutputChange;
        }

        // Update is called once per frame
        void Update()
        {
            progress += Time.deltaTime;

            if (progress < productionTime)
            {

            } else
            {
                progress = 0f;
                output.TryDeposit(input.TryWithdraw(rate));
            }
        }

        private void OnEnable()
        {
            progress = 0f;
        }

        private void OnDisable()
        {
            progress = 0f;
        }

        void OnInputChange()
        {
            if (input.Stored < rate)
                this.enabled = false;
        }

        void OnOutputChange()
        {
            if ((output.Capacity - output.Stored) < rate)
                this.enabled = false;
        }
    }
}

