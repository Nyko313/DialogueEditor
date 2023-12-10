using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEditor : MonoBehaviour
{
    [SerializeField]
    private Dialogue currentDialogue;

    [SerializeField]
    private Transform nodesContainer;
    [SerializeField]
    private GameObject nodePrefab;

    private List<NodeUI> nodes = new List<NodeUI>();

    private void Update()
    {
        
    }

    private void ShowCurrentDialogue()
    {
        foreach(Node node in currentDialogue.nodes)
        {w
            NodeUI newNode = Instantiate(nodePrefab, nodesContainer).GetComponent<NodeUI>();

            newNode.Init(node);

            nodes.Add(newNode);
        }
    }

    private void AddNode()
    {

    }


}
