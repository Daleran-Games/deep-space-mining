using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DaleranGames.SpaceTycoon
{
    public class RouteVisualizer : MonoBehaviour
    {
        [SerializeField]
        LineRenderer line;

        [SerializeField]
        Route route;

        // Use this for initialization
        void Start()
        {

            List<GoodStorage> nodes = route.Nodes;
            Vector3[] points = new Vector3[nodes.Count];

           for (int i=0; i<nodes.Count;i++)
            {
                points[i] = nodes[i].transform.position;
            }

            line.positionCount = points.Length;
            line.SetPositions(points);

        }

    }
}

