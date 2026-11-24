using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace H2P.Libs.Distance
{
    public class Distance : MonoBehaviour
    {
        public static float GetDistance(Transform pointA, Transform pointB)
        {
            return math.sqrt(
                math.pow(pointB.position.x - pointA.position.x, 2) + math.pow(pointB.position.y - pointA.position.y, 2) + math.pow(pointB.position.z - pointA.position.z, 2)
            );
        }

    }

}
