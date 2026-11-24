using System.Collections.Generic;
using UnityEngine;

namespace H2P.Nodes.NodeSpawner
{
    public class NodeSpawner : MonoBehaviour
    {
        public GameObject nodeObject;
        public static List<GameObject> nodes = new();
        public static ushort nodeCount;
        private GameObject clone;
        void Awake()
        {
            nodes = new();
            for (ushort i = 0; i < nodeCount; i++)
            {
                clone = Instantiate(nodeObject, new Vector3(Random.Range(0, 500), 0, Random.Range(0, 500)), new Quaternion(0, 0, 0, 0));
                clone.name = $"{i}";
                nodes.Add(clone);
            }
        }

    }

}