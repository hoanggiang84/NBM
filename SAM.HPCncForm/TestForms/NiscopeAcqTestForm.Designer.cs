namespace SAM.HPCncForm.TestForms
{
    partial class NiscopeAcqTestForm
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
            this.textBoxResource = new System.Windows.Forms.TextBox();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxTriggerDelay = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // textBoxResource
            // 
            this.textBoxResource.Location = new System.Drawing.Point(12, 12);
            this.textBoxResource.Name = "textBoxResource";
            this.textBoxResource.Size = new System.Drawing.Size(100, 20);
            this.textBoxResource.TabIndex = 0;
            this.textBoxResource.Text = "Dev1";
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(12, 367);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(100, 23);
            this.buttonGetData.TabIndex = 1;
            this.buttonGetData.Text = "Get Data";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(118, 12);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(730, 49);
            this.textBoxStatus.TabIndex = 2;
            // 
            // textBoxTriggerDelay
            // 
            this.textBoxTriggerDelay.Location = new System.Drawing.Point(12, 38);
            this.textBoxTriggerDelay.Name = "textBoxTriggerDelay";
            this.textBoxTriggerDelay.Size = new System.Drawing.Size(100, 20);
            this.textBoxTriggerDelay.TabIndex = 3;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(118, 67);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(730, 323);
            this.zedGraphControl1.TabIndex = 4;
            // 
            // NiscopeAcqTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 402);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.textBoxTriggerDelay);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonGetData);
            this.Controls.Add(this.textBoxResource);
            this.Name = "NiscopeAcqTestForm";
            this.Text = "NiscopeAcqTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResource;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxTriggerDelay;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}