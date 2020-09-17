using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;

using System.Windows.Forms;
using Microsoft.Msagl.Drawing;

namespace MaxFlow_MinCut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Graph graph = Manager.graph;

            /*
            //create a graph object
            //create the graph content
            graph.AddEdge("A", "B");
            Manager.AddEdge(gViewer1, "A", "B", 2);
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Color.Green;

            graph.FindNode("A").Attr.FillColor = Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Color.MistyRose;

            Node c = graph.FindNode("C");
            c.Attr.FillColor = Color.PaleGreen;
            c.Attr.Shape = Shape.Diamond;
            */

            //PreSet1();
            PreSet2();

            Manager.ChangeLineWidth(2);

            //bind the graph to the viewer
            gViewer1.Graph = graph;

            Manager.ShowNodesAndEdges(richTextBoxNodes, flowLayoutPnlEdges);
        }

        private void PreSet1()
        {
            Manager.AddEdge(gViewer1, "B", "A", 5);
            Manager.AddEdge(gViewer1, "B", "E", 5);
            Manager.AddEdge(gViewer1, "A", "C", 3);
            Manager.AddEdge(gViewer1, "A", "D", 2);
            Manager.AddEdge(gViewer1, "E", "D", 1);
            Manager.AddEdge(gViewer1, "E", "F", 7);
            Manager.AddEdge(gViewer1, "D", "F", 4);
            Manager.AddEdge(gViewer1, "D", "C", 3);
            Manager.AddEdge(gViewer1, "C", "H", 6);
            Manager.AddEdge(gViewer1, "F", "H", 8);
        }

        private void PreSet2()
        {
            Manager.AddEdge(gViewer1, "A", "B", 16);
            Manager.AddEdge(gViewer1, "A", "C", 13);
            Manager.AddEdge(gViewer1, "B", "C", 10);
            Manager.AddEdge(gViewer1, "B", "D", 12);
            Manager.AddEdge(gViewer1, "C", "B", 4);
            Manager.AddEdge(gViewer1, "C", "E", 14);
            Manager.AddEdge(gViewer1, "D", "C", 9);
            Manager.AddEdge(gViewer1, "D", "F", 20);
            Manager.AddEdge(gViewer1, "E", "D", 7);
            Manager.AddEdge(gViewer1, "E", "F", 4);
        }

        /// <summary>
        /// kenar ekleme butonuna basıldığında çalışan fonk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            string node1 = tbWillAddNode1.Text;
            string node2 = tbWillAddNode2.Text;
            double lineWidth = Convert.ToDouble(tbWidth.Text);

            Manager.AddEdge(gViewer1, node1, node2, lineWidth);

            Manager.ShowNodesAndEdges(richTextBoxNodes, flowLayoutPnlEdges);
        }

        private void tbWillAddNode1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = ((TextBox)sender);

            tb.Text = tb.Text.ToUpper();
            tb.SelectionStart = tb.Text.Length;
        }

        private void tbWillAddNode2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = ((TextBox)sender);

            tb.Text = tb.Text.ToUpper();
            tb.SelectionStart = tb.Text.Length;
        }

        private void btnFindFlow_Click(object sender, EventArgs e)
        {
            int start = Manager.nodeLabelID[tbStart.Text];
            int finish = Manager.nodeLabelID[Manager.FindFinishNode()];

            lblMaxFlow.Text = "Max-Flow : " + EdmondsKarp.FindMaxFlow(Manager.CalcCapacityMatrix(), Manager.FindNeighbors(), start, finish, out Manager.lglFlows);

            Manager.ShowEdgesFlow(flowLayoutPnlEdgesFlow);
        }

        private void tbStart_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = ((TextBox)sender);

            tb.Text = tb.Text.ToUpper();
            tb.SelectionStart = tb.Text.Length;
        }

        private void btnFindMinCut_Click(object sender, EventArgs e)
        {
            int start = Manager.nodeLabelID[tbStart.Text];
            int finish = Manager.nodeLabelID[Manager.FindFinishNode()];

            lblMinCutCount.Text = "M-C : " + MinCut.FindMinCut(Manager.CalcCapacityMatrix(), start, finish, flowLayoutPanelEdgesCut);
        }

        private void numericUDEdgeWidth_ValueChanged(object sender, EventArgs e)
        {
            Manager.ChangeLineWidth((int)((NumericUpDown)sender).Value);

            gViewer1.Refresh();
        }
    }
}