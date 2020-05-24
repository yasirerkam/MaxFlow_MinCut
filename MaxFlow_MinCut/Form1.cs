using System;
using System.Collections;
using System.Collections.Generic;
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

            //create a graph object
            //create the graph content
            //graph.AddEdge("A", "B");
            Manager.AddEdge(ref gViewer1, "A", "B", 2);
            //graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Color.Green;
            graph.FindNode("A").Attr.FillColor = Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Color.MistyRose;
            Node c = graph.FindNode("C");
            c.Attr.FillColor = Color.PaleGreen;
            c.Attr.Shape = Shape.Diamond;
            //bind the graph to the viewer
            gViewer1.Graph = graph;
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
            lineWidth = Math.Log(lineWidth);

            Manager.AddEdge(ref gViewer1, node1, node2, lineWidth);
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
    }
}