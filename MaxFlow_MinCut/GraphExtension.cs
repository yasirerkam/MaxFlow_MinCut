using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Msagl.Drawing;

namespace MaxFlow_MinCut
{
    public static class GraphExtension
    {
        /// <summary>
        /// Adds to graph if the given edge does not exist in graph
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        public static Edge AddEdgeIfNotExist(this Graph graph, string source, string target, double lineWidth)
        {
            if (!graph.CheckEdge(source, target))
            {
                Edge edge = graph.AddEdge(source, target);
                edge.Attr.ArrowheadAtTarget = ArrowStyle.None;
                edge.Attr.LineWidth = lineWidth;

                return edge;
            }
            return null;
        }

        /// <summary>
        /// Checks the graph that if contains edge or not
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool CheckEdge(this Graph graph, string source, string target)
        {
            foreach (Edge edge in graph.Edges)
            {
                if ((edge.Source.CompareTo(source) == 0 && edge.Target.CompareTo(target) == 0) || (edge.Source.CompareTo(target) == 0 && edge.Target.CompareTo(source) == 0))
                {
                    return true;
                }
            }

            return false;
        }
    }
}