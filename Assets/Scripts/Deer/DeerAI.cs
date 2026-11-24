using System.Collections.Generic;
using H2P.Nodes.Node;
using H2P.Nodes.NodeSpawner;
using UnityEngine;
using H2P.Libs.Distance;

public class DeerAI : MonoBehaviour
{
    public List<GameObject> seen = new();
    private Node currentNode;
    private GameObject nextNode;
    [SerializeField] private float speed;
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

        nextNode = currentNode.FindNearestNode(seen);
    }


    void Update()
    {
        
        if (Distance.GetDistance(transform, nextNode.transform) >= 0.5)
        {
            transform.position = Vector3.Lerp(transform.position, nextNode.transform.position, speed);
            return;
        }
        
        seen.Add(nextNode);

        if (seen.Count == NodeSpawner.nodeCount)
        {
            seen = new();
        }
        
        currentNode = nextNode.GetComponent<Node>();
        if (currentNode == null)
        {
            throw new System.Exception("DeerAI - Node doesnt have the script");
        }

        nextNode = currentNode.FindNearestNode(seen);
    }
}
