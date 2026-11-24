using H2P.Nodes.NodeSpawner;
using UnityEngine;

public class Config : MonoBehaviour
{
    public ushort nodeCount;
    void OnEnable()
    {
        // Nodespawner
        NodeSpawner.nodeCount = nodeCount;
    }

}
