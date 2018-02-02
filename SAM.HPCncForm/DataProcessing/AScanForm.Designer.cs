namespace SAM.HPCncForm.DataProcessing
{
    partial class AScanForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxGate1 = new System.Windows.Forms.CheckBox();
            this.checkBoxGate2 = new System.Windows.Forms.CheckBox();
            this.checkBoxGate3 = new System.Windows.Forms.CheckBox();
            this.timerMainLoop = new System.Windows.Forms.Timer(this.components);
            this.splitContainerButtonDisplay = new System.Windows.Forms.SplitContainer();
            this.splitContainerGraphAndCscan = new System.Windows.Forms.SplitContainer();
            this.splitContainerAscanGraph = new System.Windows.Forms.SplitContainer();
            this.graphAScan = new ZedGraph.ZedGraphControl();
            this.flowLayoutPanelGate1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxGate1 = new System.Windows.Forms.PictureBox();
            this.splitContainerGate23 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelGate2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxGate2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelGate3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxGate3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerButtonDisplay)).BeginInit();
            this.splitContainerButtonDisplay.Panel1.SuspendLayout();
            this.splitContainerButtonDisplay.Panel2.SuspendLayout();
            this.splitContainerButtonDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGraphAndCscan)).BeginInit();
            this.splitContainerGraphAndCscan.Panel1.SuspendLayout();
            this.splitContainerGraphAndCscan.Panel2.SuspendLayout();
            this.splitContainerGraphAndCscan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAscanGraph)).BeginInit();
            this.splitContainerAscanGraph.Panel1.SuspendLayout();
            this.splitContainerAscanGraph.Panel2.SuspendLayout();
            this.splitContainerAscanGraph.SuspendLayout();
            this.flowLayoutPanelGate1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGate23)).BeginInit();
            this.splitContainerGate23.Panel1.SuspendLayout();
            this.splitContainerGate23.Panel2.SuspendLayout();
            this.splitContainerGate23.SuspendLayout();
            this.flowLayoutPanelGate2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGate2)).BeginInit();
            this.flowLayoutPanelGate3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGate3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(66, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxGate1
            // 
            this.checkBoxGate1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxGate1.AutoSize = true;
            this.checkBoxGate1.Location = new System.Drawing.Point(12, 41);
            this.checkBoxGate1.Name = "checkBoxGate1";
            this.checkBoxGate1.Size = new System.Drawing.Size(49, 23);
            this.checkBoxGate1.TabIndex = 1;
            this.checkBoxGate1.Text = "Gate 1";
            this.checkBoxGate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxGate1.UseVisualStyleBackColor = true;
            this.checkBoxGate1.CheckedChanged += new System.EventHandler(this.checkBoxGate1_CheckedChanged);
            // 
            // checkBoxGate2
            // 
            this.checkBoxGate2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxGate2.AutoSize = true;
            this.checkBoxGate2.Location = new System.Drawing.Point(12, 70);
            this.checkBoxGate2.Name = "checkBoxGate2";
            this.checkBoxGate2.Size = new System.Drawing.Size(49, 23);
            this.checkBoxGate2.TabIndex = 2;
            this.checkBoxGate2.Text = "Gate 2";
            this.checkBoxGate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxGate2.UseVisualStyleBackColor = true;
            this.checkBoxGate2.CheckedChanged += new System.EventHandler(this.checkBoxGate2_CheckedChanged);
            // 
            // checkBoxGate3
            // 
            this.checkBoxGate3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxGate3.AutoSize = true;
            this.checkBoxGate3.Location = new System.Drawing.Point(12, 99);
            this.checkBoxGate3.Name = "checkBoxGate3";
            this.checkBoxGate3.Size = new System.Drawing.Size(49, 23);
            this.checkBoxGate3.TabIndex = 3;
            this.checkBoxGate3.Text = "Gate 3";
            this.checkBoxGate3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxGate3.UseVisualStyleBackColor = true;
            // 
            // timerMainLoop
            // 
            this.timerMainLoop.Tick += new System.EventHandler(this.timerMainLoop_Tick);
            // 
            // splitContainerButtonDisplay
            // 
            this.splitContainerButtonDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerButtonDisplay.Location = new System.Drawing.Point(0, 0);
            this.splitContainerButtonDisplay.Name = "splitContainerButtonDisplay";
            // 
            // splitContainerButtonDisplay.Panel1
            // 
            this.splitContainerButtonDisplay.Panel1.Controls.Add(this.buttonStart);
            this.splitContainerButtonDisplay.Panel1.Controls.Add(this.checkBoxGate3);
            this.splitContainerButtonDisplay.Panel1.Controls.Add(this.checkBoxGate1);
            this.splitContainerButtonDisplay.Panel1.Controls.Add(this.checkBoxGate2);
            // 
            // splitContainerButtonDisplay.Panel2
            // 
            this.splitContainerButtonDisplay.Panel2.Controls.Add(this.splitContainerGraphAndCscan);
            this.splitContainerButtonDisplay.Size = new System.Drawing.Size(1792, 839);
            this.splitContainerButtonDisplay.SplitterDistance = 86;
            this.splitContainerButtonDisplay.TabIndex = 4;
            // 
            // splitContainerGraphAndCscan
            // 
            this.splitContainerGraphAndCscan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGraphAndCscan.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGraphAndCscan.Name = "splitContainerGraphAndCscan";
            this.splitContainerGraphAndCscan.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerGraphAndCscan.Panel1
            // 
            this.splitContainerGraphAndCscan.Panel1.Controls.Add(this.splitContainerAscanGraph);
            // 
            // splitContainerGraphAndCscan.Panel2
            // 
            this.splitContainerGraphAndCscan.Panel2.Controls.Add(this.splitContainerGate23);
            this.splitContainerGraphAndCscan.Size = new System.Drawing.Size(1702, 839);
            this.splitContainerGraphAndCscan.SplitterDistance = 411;
            this.splitContainerGraphAndCscan.TabIndex = 0;
            // 
            // splitContainerAscanGraph
            // 
            this.splitContainerAscanGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAscanGraph.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAscanGraph.Name = "splitContainerAscanGraph";
            // 
            // splitContainerAscanGraph.Panel1
            // 
            this.splitContainerAscanGraph.Panel1.Controls.Add(this.graphAScan);
            // 
            // splitContainerAscanGraph.Panel2
            // 
            this.splitContainerAscanGraph.Panel2.Controls.Add(this.flowLayoutPanelGate1);
            this.splitContainerAscanGraph.Size = new System.Drawing.Size(1702, 411);
            this.splitContainerAscanGraph.SplitterDistance = 851;
            this.splitContainerAscanGraph.TabIndex = 0;
            // 
            // graphAScan
            // 
            this.graphAScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphAScan.Location = new System.Drawing.Point(0, 0);
            this.graphAScan.Name = "graphAScan";
            this.graphAScan.ScrollGrace = 0D;
            this.graphAScan.ScrollMaxX = 0D;
            this.graphAScan.ScrollMaxY = 0D;
            this.graphAScan.ScrollMaxY2 = 0D;
            this.graphAScan.ScrollMinX = 0D;
            this.graphAScan.ScrollMinY = 0D;
            this.graphAScan.ScrollMinY2 = 0D;
            this.graphAScan.Size = new System.Drawing.Size(851, 411);
            this.graphAScan.TabIndex = 0;
            // 
            // flowLayoutPanelGate1
            // 
            this.flowLayoutPanelGate1.AutoScroll = true;
            this.flowLayoutPanelGate1.Controls.Add(this.pictureBoxGate1);
            this.flowLayoutPanelGate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGate1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGate1.Name = "flowLayoutPanelGate1";
            this.flowLayoutPanelGate1.Size = new System.Drawing.Size(847, 411);
            this.flowLayoutPanelGate1.TabIndex = 0;
            // 
            // pictureBoxGate1
            // 
            this.pictureBoxGate1.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxGate1.Name = "pictureBoxGate1";
            this.pictureBoxGate1.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxGate1.TabIndex = 0;
            this.pictureBoxGate1.TabStop = false;
            // 
            // splitContainerGate23
            // 
            this.splitContainerGate23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGate23.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGate23.Name = "splitContainerGate23";
            // 
            // splitContainerGate23.Panel1
            // 
            this.splitContainerGate23.Panel1.Controls.Add(this.flowLayoutPanelGate2);
            // 
            // splitContainerGate23.Panel2
            // 
            this.splitContainerGate23.Panel2.Controls.Add(this.flowLayoutPanelGate3);
            this.splitContainerGate23.Size = new System.Drawing.Size(1702, 424);
            this.splitContainerGate23.SplitterDistance = 851;
            this.splitContainerGate23.TabIndex = 0;
            // 
            // flowLayoutPanelGate2
            // 
            this.flowLayoutPanelGate2.AutoScroll = true;
            this.flowLayoutPanelGate2.Controls.Add(this.pictureBoxGate2);
            this.flowLayoutPanelGate2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGate2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGate2.Name = "flowLayoutPanelGate2";
            this.flowLayoutPanelGate2.Size = new System.Drawing.Size(851, 424);
            this.flowLayoutPanelGate2.TabIndex = 0;
            // 
            // pictureBoxGate2
            // 
            this.pictureBoxGate2.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxGate2.Name = "pictureBoxGate2";
            this.pictureBoxGate2.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxGate2.TabIndex = 0;
            this.pictureBoxGate2.TabStop = false;
            // 
            // flowLayoutPanelGate3
            // 
            this.flowLayoutPanelGate3.AutoScroll = true;
            this.flowLayoutPanelGate3.Controls.Add(this.pictureBoxGate3);
            this.flowLayoutPanelGate3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGate3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGate3.Name = "flowLayoutPanelGate3";
            this.flowLayoutPanelGate3.Size = new System.Drawing.Size(847, 424);
            this.flowLayoutPanelGate3.TabIndex = 0;
            // 
            // pictureBoxGate3
            // 
            this.pictureBoxGate3.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxGate3.Name = "pictureBoxGate3";
            this.pictureBoxGate3.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxGate3.TabIndex = 0;
            this.pictureBoxGate3.TabStop = false;
            // 
            // AScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 839);
            this.Controls.Add(this.splitContainerButtonDisplay);
            this.Name = "AScanForm";
            this.Text = "A Scan";
            this.splitContainerButtonDisplay.Panel1.ResumeLayout(false);
            this.splitContainerButtonDisplay.Panel1.PerformLayout();
            this.splitContainerButtonDisplay.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerButtonDisplay)).EndInit();
            this.splitContainerButtonDisplay.ResumeLayout(false);
            this.splitContainerGraphAndCscan.Panel1.ResumeLayout(false);
            this.splitContainerGraphAndCscan.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGraphAndCscan)).EndInit();
            this.splitContainerGraphAndCscan.ResumeLayout(false);
            this.splitContainerAscanGraph.Panel1.ResumeLayout(false);
            this.splitContainerAscanGraph.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAscanGraph)).EndInit();
            this.splitContainerAscanGraph.ResumeLayout(false);
            this.flowLayoutPanelGate1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGate1)).EndInit();
            this.splitContainerGate23.Panel1.ResumeLayout(false);
            this.splitContainerGate23.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGate23)).EndInit();
            this.splitContainerGate23.ResumeLayout(false);
            this.flowLayoutPanelGate2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGate2)).EndInit();
            this.flowLayoutPanelGate3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGate3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxGate1;
        private System.Windows.Forms.CheckBox checkBoxGate2;
        private System.Windows.Forms.CheckBox checkBoxGate3;
        private System.Windows.Forms.Timer timerMainLoop;
        private System.Windows.Forms.SplitContainer splitContainerButtonDisplay;
        private System.Windows.Forms.SplitContainer splitContainerGraphAndCscan;
        private System.Windows.Forms.SplitContainer splitContainerAscanGraph;
        private ZedGraph.ZedGraphControl graphAScan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGate1;
        private System.Windows.Forms.PictureBox pictureBoxGate1;
        private System.Windows.Forms.SplitContainer splitContainerGate23;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGate2;
        private System.Windows.Forms.PictureBox pictureBoxGate2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGate3;
        private System.Windows.Forms.PictureBox pictureBoxGate3;

    }
}