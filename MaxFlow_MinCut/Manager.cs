using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace MaxFlow_MinCut
{
    public static class Manager
    {
        public static Graph graph = new Graph("graph");
        public static Nodes Nodes { get; set; } = new Nodes();

        public static Edge AddEdge(ref GViewer gviewer, string source, string target, double lineWidth)
        {
            Nodes.AddNode(new Node(source));
            Nodes.AddNode(new Node(target));

            Edge edge = graph.AddEdgeIfNotExist(source, target, lineWidth);

            gviewer.Graph = graph;

            return edge;
        }
    }
}