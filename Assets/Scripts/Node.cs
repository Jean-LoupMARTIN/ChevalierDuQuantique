using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    [SerializeField] NodeType type = NodeType.None;

    public void SetType(NodeType type)
    {
        if      (type == NodeType.H)  spriteRenderer.color = Color.yellow;
        else if (type == NodeType.X)  spriteRenderer.color = Color.red;
        else if (type == NodeType.Z)  spriteRenderer.color = Color.green;
        else if (type == NodeType.X2) spriteRenderer.color = new Color(1, 0.5f, 0.5f);
        else if (type == NodeType.Z2) spriteRenderer.color = new Color(0.5f, 1, 0.5f);
    }

    void OnValidate()
    {
        SetType(type);
    }
}

public enum NodeType
{
    None,
    H,
    X,
    Z,
    X2,
    Z2,
}