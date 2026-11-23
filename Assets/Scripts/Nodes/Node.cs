using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace H2P.Nodes.Node
{
    public class Node : MonoBehaviour
    {
        private float GetDistance(Transform pointA, Transform pointB)
        {
            return math.sqrt(
                math.pow(pointB.position.x - pointA.position.x, 2) + math.pow(pointB.position.y - pointA.position.y, 2) + math.pow(pointB.position.z - pointA.position.z, 2)
            );
        }
        public GameObject FindNearestNode(List<GameObject> seen)
        {
            GameObject returnNode = null;
            float shortestDistance = 99999;
            float distance;
            foreach (GameObject node in NodeSpawner.NodeSpawner.nodes)
            {
                if (node == gameObject || seen.Contains(node))
                {
                    continue;
                }
                distance = GetDistance(transform, node.transform);
                if (distance < shortestDistance)
                {
                    returnNode = node;
                    shortestDistance = distance;
                }    
            }

            if (returnNode == null)
            {
                returnNode = NodeSpawner.NodeSpawner.nodes[0];
            }

            return returnNode;
        }

    }

}
