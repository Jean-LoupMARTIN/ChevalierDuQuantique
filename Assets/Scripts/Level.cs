using System;
using UnityEngine;




[CreateAssetMenu(fileName = "Level", menuName = "Scriptable Objects/Level")]
public class Level : ScriptableObject
{
    public Line[] lines;
    public NodesLink[] nodesLinks;
}


[Serializable]
public struct Line
{
    public NodeType[] nodes;
}

[Serializable]
public struct NodesLink
{
    public NodesCoor node1;
    public NodesCoor node2;
}

[Serializable]
public struct NodesCoor
{
    public int lineIdx;
    public int nodeIdx;
}
