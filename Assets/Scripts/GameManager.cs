using System;
using System.Collections.Generic;
using UnityEngine;





public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] GameData data;

    [SerializeField] Node nodePrefab;
    [SerializeField] NodesLinkMono nodesLinkPrefab;



    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Level[] levels = GetLevelsFromResources();
        InstantiateLevel(levels[0]);
    }



    Level[] GetLevelsFromResources()
    {
        List<Level> levels = new List<Level>();

        for (int i = 1; true; i++)
        {
            Level level = Resources.Load($"Levels/{i}") as Level;

            if (level == null)
                break;

            levels.Add(level);
        }

        return levels.ToArray();
    }

    void InstantiateLevel(Level level)
    {
        for (int lineIdx = 0; lineIdx < level.lines.Length; lineIdx++)
        {
            Line line = level.lines[lineIdx];

            for (int nodeIdx = 0; nodeIdx < line.nodes.Length; nodeIdx++)
            {
                NodeType nodeType = line.nodes[nodeIdx];
                Node node = Instantiate(nodePrefab, data.nodesDistance * (nodeIdx * Vector3.right + lineIdx * Vector3.down), Quaternion.identity);
                node.SetType(nodeType);

                if (nodeIdx > 0)
                {

                }
            }
        }
    }
}