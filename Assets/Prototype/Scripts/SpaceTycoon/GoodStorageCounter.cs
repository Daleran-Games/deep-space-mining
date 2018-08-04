using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace DaleranGames.SpaceTycoon
{
    public class GoodStorageCounter : MonoBehaviour
    {
        [SerializeField]
        GoodStorage storage;


        [SerializeField]
        TextMeshPro text;

        // Use this for initialization
        void OnEnable()
        {
            OnStorageUpdate();

            storage.Changed += OnStorageUpdate;
        }

        private void OnDisable()
        {
            storage.Changed -= OnStorageUpdate;
        }

        void OnStorageUpdate()
        {
            text.text = storage.Stored + "/" + storage.Capacity;
        }
    }
}
