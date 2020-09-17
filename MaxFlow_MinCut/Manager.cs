using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace MaxFlow_MinCut
{
    public static class Manager
    {
        public static Graph graph = new Graph("graph");
        public static int idLatest = 0;
        public static Dictionary<string, int> nodeLabelID = new Dictionary<string, int>();
        public static Dictionary<Edge, double> edgeLineWidth = new Dictionary<Edge, double>();
        public static int[,] lglFlows;

        public static Edge AddEdge(GViewer gviewer, string source, string target, double lineWidth)
        {
            Edge edge = graph.AddEdgeIfNotExist(source, target, lineWidth);

            gviewer.Graph = graph;

            return edge;
        }

        public static void ShowNodesAndEdges(RichTextBox richTextBoxNodes, FlowLayoutPanel flowLayoutPanelEdges)
        {
            ShowNodes(richTextBoxNodes);
            ShowEdges(flowLayoutPanelEdges);
        }

        private static void ShowNodes(RichTextBox richTextBoxNodes)
        {
            Random random = new Random();
            richTextBoxNodes.Text = "";

            for (int i = 0; i < graph.NodeCount; i++)
            {
                Node[] nodes = graph.Nodes.ToArray<Node>();

                richTextBoxNodes.Text += nodes[i].LabelText + "[" + Manager.nodeLabelID[nodes[i].Id] + "], ";
                nodes[i].Attr.FillColor = new Color((byte)random.Next(), (byte)random.Next(), (byte)random.Next());
                nodes[i].Label.FontColor = Color.White;
                nodes[i].Attr.Shape = Shape.Circle;
            }
        }

        private static void ShowEdges(FlowLayoutPanel flowLayoutPanelEdges)
        {
            flowLayoutPanelEdges.Controls.Clear();

            foreach (Edge edge in graph.Edges)
            {
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();

                lbl.Text = edge.Source + "--->" + edge.Target + "  Width: " + (int)(edgeLineWidth[edge]);

                lbl.Parent = flowLayoutPanelEdges;
            }
        }

        public static void ShowEdgesFlow(FlowLayoutPanel flowLayoutPanelEdgesFlow)
        {
            flowLayoutPanelEdgesFlow.Controls.Clear();

            foreach (Edge edge in graph.Edges)
            {
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();

                lbl.Text = edge.Source + "--->" + edge.Target + "  :  " + lglFlows[nodeLabelID[edge.Source], nodeLabelID[edge.Target]] + "/" + (int)(edgeLineWidth[edge]);

                lbl.Parent = flowLayoutPanelEdgesFlow;
            }
        }

        public static bool AddNodeLabelID(string nodeLabel)
        {
            if (nodeLabelID.ContainsKey(nodeLabel))
            {
                return false;
            }
            else
            {
                nodeLabelID.Add(nodeLabel, idLatest);
                idLatest++;

                return true;
            }
        }

        public static int[,] CalcCapacityMatrix()
        {
            int[,] capacityMatrix = new int[graph.NodeCount, graph.NodeCount];

            foreach (Edge edge in graph.Edges)
            {
                capacityMatrix[nodeLabelID[edge.Source], nodeLabelID[edge.Target]] = (int)edgeLineWidth[edge];
            }

            return capacityMatrix;
        }

        public static Dictionary<int, List<int>> FindNeighbors()
        {
            Dictionary<int, List<int>> neighbors = new Dictionary<int, List<int>>();

            foreach (Edge edge in graph.Edges)
            {
                if (neighbors.ContainsKey(nodeLabelID[edge.Source]) == false)
                {
                    neighbors.Add(nodeLabelID[edge.Source], new List<int>());
                }
            }

            foreach (Edge edge in graph.Edges)
            {
                neighbors[nodeLabelID[edge.Source]].Add(nodeLabelID[edge.Target]);
            }

            return neighbors;
        }

        public static string FindFinishNode()
        {
            foreach (Node node in graph.Nodes)
            {
                int i = 0;

                for (; i < graph.Edges.Count(); i++)
                {
                    if (graph.Edges.ElementAt(i).Source.CompareTo(node.LabelText) == 0)
                    {
                        break;
                    }
                }

                if (i == graph.Edges.Count())
                {
                    return node.LabelText;
                }
            }

            return null;
        }

        public static void ChangeLineWidth(int baseLog)
        {
            if (baseLog == 1)
            {
                foreach (Edge edge in graph.Edges)
                {
                    edge.Attr.LineWidth = edgeLineWidth[edge];
                }

                return;
            }

            foreach (Edge edge in graph.Edges)
            {
                edge.Attr.LineWidth = Math.Log(edgeLineWidth[edge], baseLog);
            }
        }
    }
}