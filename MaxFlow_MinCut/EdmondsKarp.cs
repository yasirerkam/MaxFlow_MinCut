using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxFlow_MinCut
{
    internal static class EdmondsKarp
    {
        private static int n = 0;

        public static int FindMaxFlow(int[,] capacityMatrix, Dictionary<int, List<int>> neighbors, int source, int sink, out int[,] legalFlows)
        {
            n = capacityMatrix.GetLength(0);

            int f = 0; // initial flow is 0
            legalFlows = new int[n, n]; // residual capacity from u to v is capacityMatrix[u,v] - legalFlows[u,v]

            while (true)
            {
                int[] p;
                int m = BreadthFirstSearch(capacityMatrix, neighbors, source, sink, legalFlows, out p);

                if (m == 0) break;
                f += m;
                // backtrakc search, and write flow
                int v = sink;

                while (v != source)
                {
                    int u = p[v];
                    legalFlows[u, v] += m;
                    legalFlows[v, u] -= m;
                    v = u;
                }
            }

            return f;
        }

        private static int BreadthFirstSearch(int[,] capacityMatrix, Dictionary<int, List<int>> neighbors, int source, int sink, int[,] legalFlows, out int[] p)
        {
            p = new int[n];
            for (int u = 0; u < n; u++)
            {
                p[u] = -1;
            }

            p[source] = -2; // make sure source is not rediscovered
            int[] m = new int[n]; // capacity of found path to node
            m[source] = int.MaxValue;

            Queue<int> q = new Queue<int>();
            q.Enqueue(source);

            while (q.Count > 0)
            {
                int u = q.Dequeue();
                foreach (int v in neighbors[u])
                {
                    // if there is available capacity, and v is not seen before in search
                    if (capacityMatrix[u, v] - legalFlows[u, v] > 0 &&
                        p[v] == -1)
                    {
                        p[v] = u;
                        m[v] = Math.Min(m[u], capacityMatrix[u, v] - legalFlows[u, v]);

                        if (v != sink) q.Enqueue(v);
                        else return m[sink];
                    }
                }
            }

            return 0;
        }
    }
}