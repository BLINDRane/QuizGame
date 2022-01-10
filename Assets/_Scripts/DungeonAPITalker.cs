using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DungeonArchitect.Builders.GridFlow;
using DungeonArchitect.Graphs;

public class DungeonAPITalker : MonoBehaviour
{
    [SerializeField]
    DungeonGridFlowAsset ex;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ex.execGraph.Nodes.Count);

        foreach (GraphNode n in ex.execGraph.Nodes)
        {
            Debug.Log("node found with name of ");
            Debug.Log(n.name);
        }
    }
}
