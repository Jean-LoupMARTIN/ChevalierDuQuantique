using UnityEngine;

public class NodesLinkMono : MonoBehaviour
{
    public Node node1, node2;

    void Start()
    {
        MatchNodes();
    }

    void LateUpdate()
    {
        MatchNodes();
    }

    void MatchNodes()
    {
        if (!node1 || !node2)
            return;

        transform.position = (node1.transform.position + node2.transform.position) / 2;
        transform.right = node2.transform.position + node1.transform.position;
    }
}
