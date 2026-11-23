using System.Collections.Generic;
using H2P.Nodes.Node;
using H2P.Nodes.NodeSpawner;
using UnityEngine;

public class DeerAI : MonoBehaviour
{
    public List<GameObject> seen = new();
    private Node currentNode;
    void Awake()
    {
        enabled = false;
    }

    void OnEnable()
    {
        GameObject randomNode = NodeSpawner.nodes[Random.Range(0, NodeSpawner.nodeCount)];
        transform.position = randomNode.transform.position;
        
        currentNode = randomNode.GetComponent<Node>();
        if (currentNode == null)
        {
            throw new System.Exception("DeerAI - Node doesnt have the script");
        }

    
    }


    void Update()
    {
        
    }
}
