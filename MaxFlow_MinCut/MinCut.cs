using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxFlow_MinCut
{
    internal class MinCut
    {
        // Returns true if there is a path
        // from source 's' to sink 't' in residual
        // graph. Also fills parent[] to store the path
        private static bool Bfs(int[,] rGraph, int s, int t, int[] parent)
        {
            // Create a visited array and mark
            // all vertices as not visited
            bool[] visited = new bool[rGraph.Length];

            // Create a queue, enqueue source vertex
            // and mark source vertex as visited
            Queue<int> q = new Queue<int>();
            q.Enqueue(s);
            visited[s] = true;
            parent[s] = -1;

            // Standard BFS Loop
            while (q.Count != 0)
            {
                int v = q.Dequeue();
                for (int i = 0; i < rGraph.GetLength(0); i++)
                {
                    if (rGraph[v, i] > 0 && !visited[i])
                    {
                        q.Enqueue(i);
                        visited[i] = true;
                        parent[i] = v;
                    }
                }
            }

            // If we reached sink in BFS starting
            // from source, then return true, else false
            return (visited[t] == true);
        }

        // A DFS based function to find all reachable
        // vertices from s. The function marks visited[i]
        // as true if i is reachable from s. The initial
        // values in visited[] must be false. We can also
        // use BFS to find reachable vertices
        private static void Dfs(int[,] rGraph, int s, bool[] visited)
        {
            visited[s] = true;
            for (int i = 0; i < rGraph.GetLength(0); i++)
            {
                if (rGraph[s, i] > 0 && !visited[i])
                {
                    Dfs(rGraph, i, visited);
                }
            }
        }

        // Prints the minimum s-t cut
        public static int FindMinCut(int[,] graph, int s, int t, FlowLayoutPanel flowLayoutPanelEdgesCut)
        {
            int u, v;
            int cutNumber = 0;

            // Create a residual graph and fill the residual
            // graph with given capacities in the original
            // graph as residual capacities in residual graph
            // rGraph[i,j] indicates residual capacity of edge i-j
            int[,] rGraph = new int[graph.Length, graph.Length];
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    rGraph[i, j] = graph[i, j];
                }
            }

            // This array is filled by BFS and to store path
            int[] parent = new int[graph.Length];

            // Augment the flow while there is path
            // from source to sink
            while (Bfs(rGraph, s, t, parent))
            {
                // Find minimum residual capacity of the edhes
                // along the path filled by BFS. Or we can say
                // find the maximum flow through the path found.
                int pathFlow = int.MaxValue;
                for (v = t; v != s; v = parent[v])
                {
                    u = parent[v];
                    pathFlow = Math.Min(pathFlow, rGraph[u, v]);
                }

                // update residual capacities of the edges and
                // reverse edges along the path
                for (v = t; v != s; v = parent[v])
                {
                    u = parent[v];
                    rGraph[u, v] = rGraph[u, v] - pathFlow;
                    rGraph[v, u] = rGraph[v, u] + pathFlow;
                }
            }

            // Flow is maximum now, find vertices reachable from s
            bool[] isVisited = new bool[graph.Length];
            Dfs(rGraph, s, isVisited);

            flowLayoutPanelEdgesCut.Controls.Clear();

            // Print all edges that are from a reachable vertex to
            // non-reachable vertex in the original graph
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if (graph[i, j] > 0 &&
                        isVisited[i] && !isVisited[j])
                    {
                        Console.WriteLine(i + " - " + j);

                        System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();

                        lbl.Text = Manager.nodeLabelID.First((keyValue) => keyValue.Value == i).Key + "--->" + Manager.nodeLabelID.First((keyValue) => keyValue.Value == j).Key;

                        lbl.Parent = flowLayoutPanelEdgesCut;

                        cutNumber++;
                    }
                }
            }

            return cutNumber;
        }

        //// Driver Code
        //public static void Main(String[] args)
        //{
        //    // Let us create a graph shown
        //    // in the above example
        //    int[,] graph = {{0, 16, 13, 0, 0, 0},
        //                {0, 0, 10, 12, 0, 0},
        //                {0, 4, 0, 0, 14, 0},
        //                {0, 0, 9, 0, 0, 20},
        //                {0, 0, 0, 7, 0, 4},
        //                {0, 0, 0, 0, 0, 0}};

        //    FindMinCut(graph, 0, 5);
        //}
    }
}