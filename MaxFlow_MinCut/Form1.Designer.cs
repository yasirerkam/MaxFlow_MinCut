namespace MaxFlow_MinCut
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation3 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.dbAddEdge = new System.Windows.Forms.GroupBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.lblWillAddNode2 = new System.Windows.Forms.Label();
            this.tbWillAddNode2 = new System.Windows.Forms.TextBox();
            this.lblWillAddNode1 = new System.Windows.Forms.Label();
            this.tbWillAddNode1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dbNodes = new System.Windows.Forms.GroupBox();
            this.richTextBoxNodes = new System.Windows.Forms.RichTextBox();
            this.gbEdges = new System.Windows.Forms.GroupBox();
            this.flowLayoutPnlEdges = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.btnFindFlow = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMaxFlow = new System.Windows.Forms.Label();
            this.flowLayoutPnlEdgesFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnFindMinCut = new System.Windows.Forms.Button();
            this.lblMinCutCount = new System.Windows.Forms.Label();
            this.flowLayoutPanelEdgesCut = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.numericUDEdgeWidth = new System.Windows.Forms.NumericUpDown();
            this.dbAddEdge.SuspendLayout();
            this.dbNodes.SuspendLayout();
            this.gbEdges.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDEdgeWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // gViewer1
            // 
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(6, 18);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(703, 604);
            this.gViewer1.TabIndex = 0;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = planeTransformation3;
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            // 
            // dbAddEdge
            // 
            this.dbAddEdge.Controls.Add(this.lblWidth);
            this.dbAddEdge.Controls.Add(this.tbWidth);
            this.dbAddEdge.Controls.Add(this.lblWillAddNode2);
            this.dbAddEdge.Controls.Add(this.tbWillAddNode2);
            this.dbAddEdge.Controls.Add(this.lblWillAddNode1);
            this.dbAddEdge.Controls.Add(this.tbWillAddNode1);
            this.dbAddEdge.Controls.Add(this.button1);
            this.dbAddEdge.Location = new System.Drawing.Point(6, 19);
            this.dbAddEdge.Name = "dbAddEdge";
            this.dbAddEdge.Size = new System.Drawing.Size(133, 140);
            this.dbAddEdge.TabIndex = 1;
            this.dbAddEdge.TabStop = false;
            this.dbAddEdge.Text = "Add Edge";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(17, 80);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "Width";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(65, 77);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(51, 20);
            this.tbWidth.TabIndex = 5;
            this.tbWidth.Text = "3";
            // 
            // lblWillAddNode2
            // 
            this.lblWillAddNode2.AutoSize = true;
            this.lblWillAddNode2.Location = new System.Drawing.Point(17, 54);
            this.lblWillAddNode2.Name = "lblWillAddNode2";
            this.lblWillAddNode2.Size = new System.Drawing.Size(42, 13);
            this.lblWillAddNode2.TabIndex = 4;
            this.lblWillAddNode2.Text = "Node 2";
            // 
            // tbWillAddNode2
            // 
            this.tbWillAddNode2.Location = new System.Drawing.Point(65, 51);
            this.tbWillAddNode2.Name = "tbWillAddNode2";
            this.tbWillAddNode2.Size = new System.Drawing.Size(51, 20);
            this.tbWillAddNode2.TabIndex = 3;
            this.tbWillAddNode2.TextChanged += new System.EventHandler(this.tbWillAddNode2_TextChanged);
            // 
            // lblWillAddNode1
            // 
            this.lblWillAddNode1.AutoSize = true;
            this.lblWillAddNode1.Location = new System.Drawing.Point(17, 28);
            this.lblWillAddNode1.Name = "lblWillAddNode1";
            this.lblWillAddNode1.Size = new System.Drawing.Size(42, 13);
            this.lblWillAddNode1.TabIndex = 2;
            this.lblWillAddNode1.Text = "Node 1";
            // 
            // tbWillAddNode1
            // 
            this.tbWillAddNode1.Location = new System.Drawing.Point(65, 25);
            this.tbWillAddNode1.Name = "tbWillAddNode1";
            this.tbWillAddNode1.Size = new System.Drawing.Size(51, 20);
            this.tbWillAddNode1.TabIndex = 1;
            this.tbWillAddNode1.TextChanged += new System.EventHandler(this.tbWillAddNode1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbNodes
            // 
            this.dbNodes.Controls.Add(this.richTextBoxNodes);
            this.dbNodes.Location = new System.Drawing.Point(6, 165);
            this.dbNodes.Name = "dbNodes";
            this.dbNodes.Size = new System.Drawing.Size(133, 90);
            this.dbNodes.TabIndex = 2;
            this.dbNodes.TabStop = false;
            this.dbNodes.Text = "Nodes";
            // 
            // richTextBoxNodes
            // 
            this.richTextBoxNodes.Location = new System.Drawing.Point(7, 20);
            this.richTextBoxNodes.Name = "richTextBoxNodes";
            this.richTextBoxNodes.Size = new System.Drawing.Size(120, 64);
            this.richTextBoxNodes.TabIndex = 0;
            this.richTextBoxNodes.Text = "";
            // 
            // gbEdges
            // 
            this.gbEdges.Controls.Add(this.flowLayoutPnlEdges);
            this.gbEdges.Location = new System.Drawing.Point(6, 261);
            this.gbEdges.Name = "gbEdges";
            this.gbEdges.Size = new System.Drawing.Size(133, 312);
            this.gbEdges.TabIndex = 3;
            this.gbEdges.TabStop = false;
            this.gbEdges.Text = "Edges";
            // 
            // flowLayoutPnlEdges
            // 
            this.flowLayoutPnlEdges.Location = new System.Drawing.Point(7, 19);
            this.flowLayoutPnlEdges.Name = "flowLayoutPnlEdges";
            this.flowLayoutPnlEdges.Size = new System.Drawing.Size(120, 287);
            this.flowLayoutPnlEdges.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dbAddEdge);
            this.groupBox1.Controls.Add(this.gbEdges);
            this.groupBox1.Controls.Add(this.dbNodes);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 579);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(886, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 628);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Max-Flow";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbStart);
            this.groupBox3.Controls.Add(this.btnFindFlow);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find Flow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start";
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(65, 25);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(51, 20);
            this.tbStart.TabIndex = 1;
            this.tbStart.TextChanged += new System.EventHandler(this.tbStart_TextChanged);
            // 
            // btnFindFlow
            // 
            this.btnFindFlow.Location = new System.Drawing.Point(30, 58);
            this.btnFindFlow.Name = "btnFindFlow";
            this.btnFindFlow.Size = new System.Drawing.Size(75, 23);
            this.btnFindFlow.TabIndex = 0;
            this.btnFindFlow.Text = "FIND";
            this.btnFindFlow.UseVisualStyleBackColor = true;
            this.btnFindFlow.Click += new System.EventHandler(this.btnFindFlow_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMaxFlow);
            this.groupBox4.Controls.Add(this.flowLayoutPnlEdgesFlow);
            this.groupBox4.Location = new System.Drawing.Point(6, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(133, 298);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edges-Flow";
            // 
            // lblMaxFlow
            // 
            this.lblMaxFlow.AutoSize = true;
            this.lblMaxFlow.Location = new System.Drawing.Point(28, 26);
            this.lblMaxFlow.Name = "lblMaxFlow";
            this.lblMaxFlow.Size = new System.Drawing.Size(61, 13);
            this.lblMaxFlow.TabIndex = 1;
            this.lblMaxFlow.Text = "Max-Flow : ";
            // 
            // flowLayoutPnlEdgesFlow
            // 
            this.flowLayoutPnlEdgesFlow.Location = new System.Drawing.Point(7, 53);
            this.flowLayoutPnlEdgesFlow.Name = "flowLayoutPnlEdgesFlow";
            this.flowLayoutPnlEdgesFlow.Size = new System.Drawing.Size(120, 239);
            this.flowLayoutPnlEdgesFlow.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gViewer1);
            this.groupBox5.Location = new System.Drawing.Point(162, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(718, 628);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Graph";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblMinCutCount);
            this.groupBox6.Controls.Add(this.btnFindMinCut);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(6, 422);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(133, 200);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Min-Cut";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.flowLayoutPanelEdgesCut);
            this.groupBox7.Location = new System.Drawing.Point(6, 49);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(121, 145);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Edges-Cut";
            // 
            // btnFindMinCut
            // 
            this.btnFindMinCut.Location = new System.Drawing.Point(7, 20);
            this.btnFindMinCut.Name = "btnFindMinCut";
            this.btnFindMinCut.Size = new System.Drawing.Size(65, 23);
            this.btnFindMinCut.TabIndex = 1;
            this.btnFindMinCut.Text = "FIND";
            this.btnFindMinCut.UseVisualStyleBackColor = true;
            this.btnFindMinCut.Click += new System.EventHandler(this.btnFindMinCut_Click);
            // 
            // lblMinCutCount
            // 
            this.lblMinCutCount.AutoSize = true;
            this.lblMinCutCount.Location = new System.Drawing.Point(81, 25);
            this.lblMinCutCount.Name = "lblMinCutCount";
            this.lblMinCutCount.Size = new System.Drawing.Size(35, 13);
            this.lblMinCutCount.TabIndex = 2;
            this.lblMinCutCount.Text = "M-C : ";
            // 
            // flowLayoutPanelEdgesCut
            // 
            this.flowLayoutPanelEdgesCut.AutoScroll = true;
            this.flowLayoutPanelEdgesCut.Location = new System.Drawing.Point(7, 20);
            this.flowLayoutPanelEdgesCut.Name = "flowLayoutPanelEdgesCut";
            this.flowLayoutPanelEdgesCut.Size = new System.Drawing.Size(114, 119);
            this.flowLayoutPanelEdgesCut.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.numericUDEdgeWidth);
            this.groupBox8.Location = new System.Drawing.Point(6, 597);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(150, 44);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Edge Width";
            // 
            // numericUDEdgeWidth
            // 
            this.numericUDEdgeWidth.Location = new System.Drawing.Point(26, 18);
            this.numericUDEdgeWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUDEdgeWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDEdgeWidth.Name = "numericUDEdgeWidth";
            this.numericUDEdgeWidth.Size = new System.Drawing.Size(85, 20);
            this.numericUDEdgeWidth.TabIndex = 0;
            this.numericUDEdgeWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUDEdgeWidth.ValueChanged += new System.EventHandler(this.numericUDEdgeWidth_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 653);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.dbAddEdge.ResumeLayout(false);
            this.dbAddEdge.PerformLayout();
            this.dbNodes.ResumeLayout(false);
            this.gbEdges.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUDEdgeWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private System.Windows.Forms.GroupBox dbAddEdge;
        private System.Windows.Forms.Label lblWillAddNode2;
        private System.Windows.Forms.TextBox tbWillAddNode2;
        private System.Windows.Forms.Label lblWillAddNode1;
        private System.Windows.Forms.TextBox tbWillAddNode1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox dbNodes;
        private System.Windows.Forms.GroupBox gbEdges;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPnlEdges;
        private System.Windows.Forms.RichTextBox richTextBoxNodes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Button btnFindFlow;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPnlEdgesFlow;
        private System.Windows.Forms.Label lblMaxFlow;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblMinCutCount;
        private System.Windows.Forms.Button btnFindMinCut;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEdgesCut;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown numericUDEdgeWidth;
    }
}

