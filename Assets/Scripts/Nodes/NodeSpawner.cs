using System.Collections.Generic;
using UnityEngine;

namespace H2P.Nodes.NodeSpawner
{
    public class NodeSpawner : MonoBehaviour
    {
        public GameObject nodeObject;
        public static List<GameObject> nodes = new();
        [SerializeField] private ushort nodeCount;
        private GameObject clone;
        void Awake()
        {
            for (ushort i = 0; i < nodeCount; i++)
            {
                clone = Instantiate(nodeObject, new Vector3(Random.Range(0, 500), 0, Random.Range(0, 500)), new Quaternion(0, 0, 0, 0));
                nodes.Add(clone);
            }
        }

}

}