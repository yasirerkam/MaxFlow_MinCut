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
            this.lblWillAddNode2 = new System.Windows.Forms.Label();
            this.tbWillAddNode2 = new System.Windows.Forms.TextBox();
            this.lblWillAddNode1 = new System.Windows.Forms.Label();
            this.tbWillAddNode1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dbNodes = new System.Windows.Forms.GroupBox();
            this.gbEdges = new System.Windows.Forms.GroupBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.dbAddEdge.SuspendLayout();
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
            this.gViewer1.Location = new System.Drawing.Point(12, 12);
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
            this.gViewer1.Size = new System.Drawing.Size(703, 578);
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
            this.dbAddEdge.Location = new System.Drawing.Point(721, 12);
            this.dbAddEdge.Name = "dbAddEdge";
            this.dbAddEdge.Size = new System.Drawing.Size(133, 140);
            this.dbAddEdge.TabIndex = 1;
            this.dbAddEdge.TabStop = false;
            this.dbAddEdge.Text = "Add Edge";
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
            this.dbNodes.Location = new System.Drawing.Point(721, 158);
            this.dbNodes.Name = "dbNodes";
            this.dbNodes.Size = new System.Drawing.Size(133, 139);
            this.dbNodes.TabIndex = 2;
            this.dbNodes.TabStop = false;
            this.dbNodes.Text = "Nodes";
            // 
            // gbEdges
            // 
            this.gbEdges.Location = new System.Drawing.Point(721, 303);
            this.gbEdges.Name = "gbEdges";
            this.gbEdges.Size = new System.Drawing.Size(133, 287);
            this.gbEdges.TabIndex = 3;
            this.gbEdges.TabStop = false;
            this.gbEdges.Text = "Edges";
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
            this.tbWidth.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 609);
            this.Controls.Add(this.gbEdges);
            this.Controls.Add(this.dbNodes);
            this.Controls.Add(this.dbAddEdge);
            this.Controls.Add(this.gViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.dbAddEdge.ResumeLayout(false);
            this.dbAddEdge.PerformLayout();
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
    }
}

