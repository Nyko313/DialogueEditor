using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Node
{
    public List<string> children = new List<string>();
    public string id;

    public string content;
}
