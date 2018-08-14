using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.LastShipToTauCeti
{
    public class ProjectedPathPoint : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D rb;


        // Update is called once per frame
        void Update()
        {
            transform.position = rb.position + (rb.velocity.normalized * MainCamera.Instance.orthographicSize * 4);
        }
    }
}