namespace SAM.HPCncForm
{
    partial class FormTestCnc
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
            this.comboBoxSerial = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGetInfo = new System.Windows.Forms.Button();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.checkBoxConnect = new System.Windows.Forms.CheckBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonJogYplus = new System.Windows.Forms.Button();
            this.buttonJogXminus = new System.Windows.Forms.Button();
            this.buttonJogZminus = new System.Windows.Forms.Button();
            this.buttonJogYminus = new System.Windows.Forms.Button();
            this.buttonJogXplus = new System.Windows.Forms.Button();
            this.buttonJogZplus = new System.Windows.Forms.Button();
            this.trackBarFeedrate = new System.Windows.Forms.TrackBar();
            this.textBoxFeedRate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFeedrate)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSerial
            // 
            this.comboBoxSerial.FormattingEnabled = true;
            this.comboBoxSerial.Location = new System.Drawing.Point(8, 8);
            this.comboBoxSerial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(88, 21);
            this.comboBoxSerial.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(563, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonGetInfo
            // 
            this.buttonGetInfo.Location = new System.Drawing.Point(99, 129);
            this.buttonGetInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetInfo.Name = "buttonGetInfo";
            this.buttonGetInfo.Size = new System.Drawing.Size(97, 23);
            this.buttonGetInfo.TabIndex = 2;
            this.buttonGetInfo.Text = "Info/Stop Jogging";
            this.buttonGetInfo.UseVisualStyleBackColor = true;
            this.buttonGetInfo.Click += new System.EventHandler(this.buttonGetInfo_Click);
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Location = new System.Drawing.Point(99, 31);
            this.textBoxReceive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ReadOnly = true;
            this.textBoxReceive.Size = new System.Drawing.Size(563, 94);
            this.textBoxReceive.TabIndex = 3;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 1;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // checkBoxConnect
            // 
            this.checkBoxConnect.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxConnect.Location = new System.Drawing.Point(8, 33);
            this.checkBoxConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxConnect.Name = "checkBoxConnect";
            this.checkBoxConnect.Size = new System.Drawing.Size(87, 23);
            this.checkBoxConnect.TabIndex = 4;
            this.checkBoxConnect.Text = "Connect";
            this.checkBoxConnect.UseVisualStyleBackColor = true;
            this.checkBoxConnect.CheckedChanged += new System.EventHandler(this.checkBoxConnect_CheckedChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(479, 129);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(87, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(570, 129);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(87, 23);
            this.buttonHome.TabIndex = 6;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonJogYplus
            // 
            this.buttonJogYplus.Location = new System.Drawing.Point(269, 127);
            this.buttonJogYplus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonJogYplus.Name = "buttonJogYplus";
            this.buttonJogYplus.Size = new System.Drawing.Size(37, 19);
            this.buttonJogYplus.TabIndex = 7;
            this.buttonJogYplus.Text = "Y+";
            this.buttonJogYplus.UseVisualStyleBackColor = true;
            this.buttonJogYplus.Click += new System.EventHandler(this.buttonJogYplus_Click);
            // 
            // buttonJogXminus
            // 
            this.buttonJogXminus.Location = new System.Drawing.Point(218, 168);
            this.buttonJogXminus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonJogXminus.Name = "buttonJogXminus";
            this.buttonJogXminus.Size = new System.Drawing.Size(37, 19);
            this.buttonJogXminus.TabIndex = 8;
            this.buttonJogXminus.Text = "X-";
            this.buttonJogXminus.UseVisualStyleBackColor = true;
            this.buttonJogXminus.Click += new System.EventHandler(this.buttonJogXminus_Click);
            // 
            // buttonJogZminus
            // 
            this.buttonJogZminus.Location = new System.Drawing.Point(387, 211);
            this.buttonJogZminus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonJogZminus.Name = "buttonJogZminus";
            this.buttonJogZminus.Size = new System.Drawing.Size(37, 19);
            this.buttonJogZminus.TabIndex = 9;
            this.buttonJogZminus.Text = "Z-";
            this.buttonJogZminus.UseVisualStyleBackColor = true;
            this.buttonJogZminus.Click += new System.EventHandler(this.buttonJogZminus_Click);
            // 
            // buttonJogYminus
            // 
            this.buttonJogYminus.Location = new System.Drawing.Point(269, 211);
            this.buttonJogYminus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonJogYminus.Name = "buttonJogYminus";
            this.buttonJogYminus.Size = new System.Drawing.Size(37, 19);
            this.buttonJogYminus.TabIndex = 10;
            this.buttonJogYminus.Text = "Y-";
            this.buttonJogYminus.UseVisualStyleBackColor = true;
            this.buttonJogYminus.Click += new System.EventHandler(this.buttonJogYminus_Click);
            // 
            // buttonJogXplus
            // 
            this.buttonJogXplus.Location = new System.Drawing.Point(322, 168);
            this.buttonJogXplus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonJogXplus.Name = "buttonJogXplus";
            this.buttonJogXplus.Size = new System.Drawing.Size(37, 19);
            this.buttonJogXplus.TabIndex = 11;
            this.buttonJogXplus.Text = "X+";
            this.buttonJogXplus.UseVisualStyleBackColor = true;
            this.buttonJogXplus.Click += new System.EventHandler(this.buttonJogXplus_Click);
            // 
            // buttonJogZplus
            // 
            this.buttonJogZplus.Location = new System.Drawing.Point(387, 127);
            this.buttonJogZplus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonJogZplus.Name = "buttonJogZplus";
            this.buttonJogZplus.Size = new System.Drawing.Size(37, 19);
            this.buttonJogZplus.TabIndex = 12;
            this.buttonJogZplus.Text = "Z+";
            this.buttonJogZplus.UseVisualStyleBackColor = true;
            this.buttonJogZplus.Click += new System.EventHandler(this.buttonJogZplus_Click);
            // 
            // trackBarFeedrate
            // 
            this.trackBarFeedrate.Location = new System.Drawing.Point(254, 271);
            this.trackBarFeedrate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarFeedrate.Maximum = 100;
            this.trackBarFeedrate.Name = "trackBarFeedrate";
            this.trackBarFeedrate.Size = new System.Drawing.Size(160, 45);
            this.trackBarFeedrate.TabIndex = 14;
            this.trackBarFeedrate.Scroll += new System.EventHandler(this.trackBarFeedrate_Scroll);
            // 
            // textBoxFeedRate
            // 
            this.textBoxFeedRate.Location = new System.Drawing.Point(418, 271);
            this.textBoxFeedRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFeedRate.Name = "textBoxFeedRate";
            this.textBoxFeedRate.ReadOnly = true;
            this.textBoxFeedRate.Size = new System.Drawing.Size(51, 20);
            this.textBoxFeedRate.TabIndex = 15;
            // 
            // FormTestCnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 463);
            this.Controls.Add(this.textBoxFeedRate);
            this.Controls.Add(this.trackBarFeedrate);
            this.Controls.Add(this.buttonJogZplus);
            this.Controls.Add(this.buttonJogXplus);
            this.Controls.Add(this.buttonJogYminus);
            this.Controls.Add(this.buttonJogZminus);
            this.Controls.Add(this.buttonJogXminus);
            this.Controls.Add(this.buttonJogYplus);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.checkBoxConnect);
            this.Controls.Add(this.textBoxReceive);
            this.Controls.Add(this.buttonGetInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxSerial);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTestCnc";
            this.Text = "HP CNC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHPCnc_FormClosed);
            this.Load += new System.EventHandler(this.FormHPCnc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFeedrate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSerial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGetInfo;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.CheckBox checkBoxConnect;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonJogYplus;
        private System.Windows.Forms.Button buttonJogZplus;
        private System.Windows.Forms.Button buttonJogXplus;
        private System.Windows.Forms.Button buttonJogYminus;
        private System.Windows.Forms.Button buttonJogZminus;
        private System.Windows.Forms.Button buttonJogXminus;
        private System.Windows.Forms.TrackBar trackBarFeedrate;
        private System.Windows.Forms.TextBox textBoxFeedRate;
    }
}

