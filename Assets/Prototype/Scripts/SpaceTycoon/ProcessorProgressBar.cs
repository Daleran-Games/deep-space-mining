using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DaleranGames.SpaceTycoon
{
    public class ProcessorProgressBar : MonoBehaviour
    {
        [SerializeField]
        Processor processor;

        [SerializeField]
        Slider progressBar;

        private void Update()
        {
            progressBar.value = processor.Progress / processor.ProductionTime;
        }

    }
}

