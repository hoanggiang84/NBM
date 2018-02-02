namespace SAM.HPCncForm.DataProcessing
{
    partial class DataProcessForm
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageDataProcessing = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelASCAN = new System.Windows.Forms.FlowLayoutPanel();
            this.labelAScan = new System.Windows.Forms.Label();
            this.zedGraphControlASCAN = new ZedGraph.ZedGraphControl();
            this.flowLayoutPanelBSCAN = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBSCAN = new System.Windows.Forms.Label();
            this.zedGraphControlBSCAN = new ZedGraph.ZedGraphControl();
            this.pictureBoxCSCAN = new System.Windows.Forms.PictureBox();
            this.labelCSCAN = new System.Windows.Forms.Label();
            this.timerScan = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPageDataProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanelASCAN.SuspendLayout();
            this.flowLayoutPanelBSCAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCSCAN)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(8, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 30);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageDataProcessing);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1584, 862);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageDataProcessing
            // 
            this.tabPageDataProcessing.Controls.Add(this.splitContainer1);
            this.tabPageDataProcessing.Controls.Add(this.buttonStart);
            this.tabPageDataProcessing.Location = new System.Drawing.Point(4, 25);
            this.tabPageDataProcessing.Name = "tabPageDataProcessing";
            this.tabPageDataProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataProcessing.Size = new System.Drawing.Size(1576, 833);
            this.tabPageDataProcessing.TabIndex = 0;
            this.tabPageDataProcessing.Text = "Data Processing";
            this.tabPageDataProcessing.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(89, 6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxCSCAN);
            this.splitContainer1.Panel2.Controls.Add(this.labelCSCAN);
            this.splitContainer1.Size = new System.Drawing.Size(1570, 827);
            this.splitContainer1.SplitterDistance = 362;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanelASCAN);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanelBSCAN);
            this.splitContainer2.Size = new System.Drawing.Size(1570, 362);
            this.splitContainer2.SplitterDistance = 780;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanelASCAN
            // 
            this.flowLayoutPanelASCAN.Controls.Add(this.labelAScan);
            this.flowLayoutPanelASCAN.Controls.Add(this.zedGraphControlASCAN);
            this.flowLayoutPanelASCAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelASCAN.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelASCAN.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelASCAN.Name = "flowLayoutPanelASCAN";
            this.flowLayoutPanelASCAN.Size = new System.Drawing.Size(780, 362);
            this.flowLayoutPanelASCAN.TabIndex = 0;
            // 
            // labelAScan
            // 
            this.labelAScan.AutoSize = true;
            this.labelAScan.Location = new System.Drawing.Point(3, 0);
            this.labelAScan.Name = "labelAScan";
            this.labelAScan.Size = new System.Drawing.Size(63, 16);
            this.labelAScan.TabIndex = 0;
            this.labelAScan.Text = "A SCAN";
            // 
            // zedGraphControlASCAN
            // 
            this.zedGraphControlASCAN.Location = new System.Drawing.Point(3, 19);
            this.zedGraphControlASCAN.Name = "zedGraphControlASCAN";
            this.zedGraphControlASCAN.ScrollGrace = 0D;
            this.zedGraphControlASCAN.ScrollMaxX = 0D;
            this.zedGraphControlASCAN.ScrollMaxY = 0D;
            this.zedGraphControlASCAN.ScrollMaxY2 = 0D;
            this.zedGraphControlASCAN.ScrollMinX = 0D;
            this.zedGraphControlASCAN.ScrollMinY = 0D;
            this.zedGraphControlASCAN.ScrollMinY2 = 0D;
            this.zedGraphControlASCAN.Size = new System.Drawing.Size(774, 340);
            this.zedGraphControlASCAN.TabIndex = 1;
            // 
            // flowLayoutPanelBSCAN
            // 
            this.flowLayoutPanelBSCAN.Controls.Add(this.labelBSCAN);
            this.flowLayoutPanelBSCAN.Controls.Add(this.zedGraphControlBSCAN);
            this.flowLayoutPanelBSCAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBSCAN.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBSCAN.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBSCAN.Name = "flowLayoutPanelBSCAN";
            this.flowLayoutPanelBSCAN.Size = new System.Drawing.Size(786, 362);
            this.flowLayoutPanelBSCAN.TabIndex = 0;
            // 
            // labelBSCAN
            // 
            this.labelBSCAN.AutoSize = true;
            this.labelBSCAN.Location = new System.Drawing.Point(3, 0);
            this.labelBSCAN.Name = "labelBSCAN";
            this.labelBSCAN.Size = new System.Drawing.Size(63, 16);
            this.labelBSCAN.TabIndex = 0;
            this.labelBSCAN.Text = "B SCAN";
            // 
            // zedGraphControlBSCAN
            // 
            this.zedGraphControlBSCAN.Location = new System.Drawing.Point(3, 18);
            this.zedGraphControlBSCAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zedGraphControlBSCAN.Name = "zedGraphControlBSCAN";
            this.zedGraphControlBSCAN.ScrollGrace = 0D;
            this.zedGraphControlBSCAN.ScrollMaxX = 0D;
            this.zedGraphControlBSCAN.ScrollMaxY = 0D;
            this.zedGraphControlBSCAN.ScrollMaxY2 = 0D;
            this.zedGraphControlBSCAN.ScrollMinX = 0D;
            this.zedGraphControlBSCAN.ScrollMinY = 0D;
            this.zedGraphControlBSCAN.ScrollMinY2 = 0D;
            this.zedGraphControlBSCAN.Size = new System.Drawing.Size(692, 340);
            this.zedGraphControlBSCAN.TabIndex = 1;
            // 
            // pictureBoxCSCAN
            // 
            this.pictureBoxCSCAN.Location = new System.Drawing.Point(248, 3);
            this.pictureBoxCSCAN.Name = "pictureBoxCSCAN";
            this.pictureBoxCSCAN.Size = new System.Drawing.Size(1000, 450);
            this.pictureBoxCSCAN.TabIndex = 1;
            this.pictureBoxCSCAN.TabStop = false;
            // 
            // labelCSCAN
            // 
            this.labelCSCAN.AutoSize = true;
            this.labelCSCAN.Location = new System.Drawing.Point(3, 0);
            this.labelCSCAN.Name = "labelCSCAN";
            this.labelCSCAN.Size = new System.Drawing.Size(63, 16);
            this.labelCSCAN.TabIndex = 0;
            this.labelCSCAN.Text = "C SCAN";
            // 
            // timerScan
            // 
            this.timerScan.Interval = 1;
            this.timerScan.Tick += new System.EventHandler(this.timerScan_Tick);
            // 
            // DataProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.tabControlMain);
            this.Name = "DataProcessForm";
            this.Text = "DataProcessForm";
            this.Load += new System.EventHandler(this.DataProcessForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageDataProcessing.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanelASCAN.ResumeLayout(false);
            this.flowLayoutPanelASCAN.PerformLayout();
            this.flowLayoutPanelBSCAN.ResumeLayout(false);
            this.flowLayoutPanelBSCAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCSCAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageDataProcessing;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelASCAN;
        private System.Windows.Forms.Label labelAScan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBSCAN;
        private System.Windows.Forms.Label labelBSCAN;
        private ZedGraph.ZedGraphControl zedGraphControlASCAN;
        private ZedGraph.ZedGraphControl zedGraphControlBSCAN;
        private System.Windows.Forms.Label labelCSCAN;
        private System.Windows.Forms.PictureBox pictureBoxCSCAN;
        private System.Windows.Forms.Timer timerScan;
    }
}