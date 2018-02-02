namespace SAM.HPCncForm.SAMControl
{
    partial class CScanForm
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
            this.pictureBoxCScan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCScan)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCScan
            // 
            this.pictureBoxCScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCScan.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCScan.Name = "pictureBoxCScan";
            this.pictureBoxCScan.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxCScan.TabIndex = 0;
            this.pictureBoxCScan.TabStop = false;
            // 
            // CScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pictureBoxCScan);
            this.Name = "CScanForm";
            this.Text = "C SCAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CScanForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCScan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxCScan;

    }
}