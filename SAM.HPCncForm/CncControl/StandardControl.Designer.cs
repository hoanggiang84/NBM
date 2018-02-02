namespace SAM.HPCncForm
{
    partial class FormStandardControl
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.splitContainerControl = new System.Windows.Forms.SplitContainer();
            this.tabControlModes = new System.Windows.Forms.TabControl();
            this.tabPageAuto = new System.Windows.Forms.TabPage();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.labelAutoFr = new System.Windows.Forms.Label();
            this.textBoxAutoFeedrate = new System.Windows.Forms.TextBox();
            this.trackBarAutoFeedRate = new System.Windows.Forms.TrackBar();
            this.labelGCode = new System.Windows.Forms.Label();
            this.textBoxGcode = new System.Windows.Forms.TextBox();
            this.buttonSendGcode = new System.Windows.Forms.Button();
            this.tabPageManual = new System.Windows.Forms.TabPage();
            this.labelManualFr = new System.Windows.Forms.Label();
            this.buttonZminus = new System.Windows.Forms.Button();
            this.buttonZplus = new System.Windows.Forms.Button();
            this.buttonXplus = new System.Windows.Forms.Button();
            this.buttonXminus = new System.Windows.Forms.Button();
            this.buttonYminus = new System.Windows.Forms.Button();
            this.labelJOG = new System.Windows.Forms.Label();
            this.buttonYplus = new System.Windows.Forms.Button();
            this.textBoxManualFeedrate = new System.Windows.Forms.TextBox();
            this.trackBarManualFeedrate = new System.Windows.Forms.TrackBar();
            this.panelPosition = new System.Windows.Forms.Panel();
            this.textBoxCurrentFeedRate = new System.Windows.Forms.TextBox();
            this.labelCurrentFeedRate = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelXa = new System.Windows.Forms.Label();
            this.labelYa = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxZA = new System.Windows.Forms.TextBox();
            this.textBoxYA = new System.Windows.Forms.TextBox();
            this.textBoxXA = new System.Windows.Forms.TextBox();
            this.labelZm = new System.Windows.Forms.Label();
            this.labelXm = new System.Windows.Forms.Label();
            this.labelYm = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxZm = new System.Windows.Forms.TextBox();
            this.textBoxYm = new System.Windows.Forms.TextBox();
            this.textBoxXm = new System.Windows.Forms.TextBox();
            this.buttonSetZabsZero = new System.Windows.Forms.Button();
            this.buttonSetYabsZero = new System.Windows.Forms.Button();
            this.buttonSetXabsZero = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShapePosition = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.Panel1.SuspendLayout();
            this.splitContainerControl.Panel2.SuspendLayout();
            this.splitContainerControl.SuspendLayout();
            this.tabControlModes.SuspendLayout();
            this.tabPageAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAutoFeedRate)).BeginInit();
            this.tabPageManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarManualFeedrate)).BeginInit();
            this.panelPosition.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.buttonConnect);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxStatus);
            this.splitContainerMain.Panel1.Controls.Add(this.comboBoxCOM);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerControl);
            this.splitContainerMain.Size = new System.Drawing.Size(784, 562);
            this.splitContainerMain.SplitterDistance = 78;
            this.splitContainerMain.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(12, 44);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(93, 28);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.connectButton_Clicked);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(111, 12);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(670, 60);
            this.textBoxStatus.TabIndex = 2;
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(93, 26);
            this.comboBoxCOM.TabIndex = 0;
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.IsSplitterFixed = true;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            // 
            // splitContainerControl.Panel1
            // 
            this.splitContainerControl.Panel1.Controls.Add(this.tabControlModes);
            // 
            // splitContainerControl.Panel2
            // 
            this.splitContainerControl.Panel2.Controls.Add(this.panelPosition);
            this.splitContainerControl.Size = new System.Drawing.Size(784, 480);
            this.splitContainerControl.SplitterDistance = 379;
            this.splitContainerControl.TabIndex = 0;
            // 
            // tabControlModes
            // 
            this.tabControlModes.Controls.Add(this.tabPageAuto);
            this.tabControlModes.Controls.Add(this.tabPageManual);
            this.tabControlModes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlModes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlModes.Location = new System.Drawing.Point(0, 0);
            this.tabControlModes.Name = "tabControlModes";
            this.tabControlModes.SelectedIndex = 0;
            this.tabControlModes.Size = new System.Drawing.Size(379, 480);
            this.tabControlModes.TabIndex = 0;
            // 
            // tabPageAuto
            // 
            this.tabPageAuto.Controls.Add(this.buttonStart);
            this.tabPageAuto.Controls.Add(this.buttonPause);
            this.tabPageAuto.Controls.Add(this.labelAutoFr);
            this.tabPageAuto.Controls.Add(this.textBoxAutoFeedrate);
            this.tabPageAuto.Controls.Add(this.trackBarAutoFeedRate);
            this.tabPageAuto.Controls.Add(this.labelGCode);
            this.tabPageAuto.Controls.Add(this.textBoxGcode);
            this.tabPageAuto.Controls.Add(this.buttonSendGcode);
            this.tabPageAuto.Location = new System.Drawing.Point(4, 25);
            this.tabPageAuto.Name = "tabPageAuto";
            this.tabPageAuto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuto.Size = new System.Drawing.Size(371, 451);
            this.tabPageAuto.TabIndex = 0;
            this.tabPageAuto.Text = "Auto";
            this.tabPageAuto.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(104, 79);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 29);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.Location = new System.Drawing.Point(200, 79);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(90, 29);
            this.buttonPause.TabIndex = 12;
            this.buttonPause.Text = "PAUSE";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // labelAutoFr
            // 
            this.labelAutoFr.AutoSize = true;
            this.labelAutoFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoFr.Location = new System.Drawing.Point(8, 169);
            this.labelAutoFr.Name = "labelAutoFr";
            this.labelAutoFr.Size = new System.Drawing.Size(85, 16);
            this.labelAutoFr.TabIndex = 11;
            this.labelAutoFr.Text = "Feed Rate:";
            // 
            // textBoxAutoFeedrate
            // 
            this.textBoxAutoFeedrate.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAutoFeedrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutoFeedrate.Location = new System.Drawing.Point(184, 188);
            this.textBoxAutoFeedrate.Name = "textBoxAutoFeedrate";
            this.textBoxAutoFeedrate.ReadOnly = true;
            this.textBoxAutoFeedrate.Size = new System.Drawing.Size(47, 29);
            this.textBoxAutoFeedrate.TabIndex = 10;
            this.textBoxAutoFeedrate.Text = "0";
            // 
            // trackBarAutoFeedRate
            // 
            this.trackBarAutoFeedRate.Location = new System.Drawing.Point(3, 188);
            this.trackBarAutoFeedRate.Maximum = 100;
            this.trackBarAutoFeedRate.Name = "trackBarAutoFeedRate";
            this.trackBarAutoFeedRate.Size = new System.Drawing.Size(175, 45);
            this.trackBarAutoFeedRate.TabIndex = 6;
            this.trackBarAutoFeedRate.Scroll += new System.EventHandler(this.trackBarAutoFeedRate_Scroll);
            // 
            // labelGCode
            // 
            this.labelGCode.AutoSize = true;
            this.labelGCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGCode.Location = new System.Drawing.Point(8, 23);
            this.labelGCode.Name = "labelGCode";
            this.labelGCode.Size = new System.Drawing.Size(69, 16);
            this.labelGCode.TabIndex = 4;
            this.labelGCode.Text = "G CODE:";
            // 
            // textBoxGcode
            // 
            this.textBoxGcode.Location = new System.Drawing.Point(8, 42);
            this.textBoxGcode.Multiline = true;
            this.textBoxGcode.Name = "textBoxGcode";
            this.textBoxGcode.Size = new System.Drawing.Size(357, 31);
            this.textBoxGcode.TabIndex = 2;
            this.textBoxGcode.Text = "G01X0Y0Z0F1000";
            // 
            // buttonSendGcode
            // 
            this.buttonSendGcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendGcode.Location = new System.Drawing.Point(8, 79);
            this.buttonSendGcode.Name = "buttonSendGcode";
            this.buttonSendGcode.Size = new System.Drawing.Size(90, 29);
            this.buttonSendGcode.TabIndex = 1;
            this.buttonSendGcode.Text = "SEND";
            this.buttonSendGcode.UseVisualStyleBackColor = true;
            this.buttonSendGcode.Click += new System.EventHandler(this.buttonSendGcode_Click);
            // 
            // tabPageManual
            // 
            this.tabPageManual.Controls.Add(this.labelManualFr);
            this.tabPageManual.Controls.Add(this.buttonZminus);
            this.tabPageManual.Controls.Add(this.buttonZplus);
            this.tabPageManual.Controls.Add(this.buttonXplus);
            this.tabPageManual.Controls.Add(this.buttonXminus);
            this.tabPageManual.Controls.Add(this.buttonYminus);
            this.tabPageManual.Controls.Add(this.labelJOG);
            this.tabPageManual.Controls.Add(this.buttonYplus);
            this.tabPageManual.Controls.Add(this.textBoxManualFeedrate);
            this.tabPageManual.Controls.Add(this.trackBarManualFeedrate);
            this.tabPageManual.Location = new System.Drawing.Point(4, 25);
            this.tabPageManual.Name = "tabPageManual";
            this.tabPageManual.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManual.Size = new System.Drawing.Size(371, 451);
            this.tabPageManual.TabIndex = 1;
            this.tabPageManual.Text = "Manual";
            this.tabPageManual.UseVisualStyleBackColor = true;
            // 
            // labelManualFr
            // 
            this.labelManualFr.AutoSize = true;
            this.labelManualFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManualFr.Location = new System.Drawing.Point(6, 218);
            this.labelManualFr.Name = "labelManualFr";
            this.labelManualFr.Size = new System.Drawing.Size(85, 16);
            this.labelManualFr.TabIndex = 20;
            this.labelManualFr.Text = "Feed Rate:";
            // 
            // buttonZminus
            // 
            this.buttonZminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZminus.Location = new System.Drawing.Point(215, 153);
            this.buttonZminus.Name = "buttonZminus";
            this.buttonZminus.Size = new System.Drawing.Size(45, 45);
            this.buttonZminus.TabIndex = 19;
            this.buttonZminus.Text = "Z-";
            this.buttonZminus.UseVisualStyleBackColor = true;
            this.buttonZminus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonZminus_Click);
            this.buttonZminus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // buttonZplus
            // 
            this.buttonZplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZplus.Location = new System.Drawing.Point(215, 50);
            this.buttonZplus.Name = "buttonZplus";
            this.buttonZplus.Size = new System.Drawing.Size(45, 45);
            this.buttonZplus.TabIndex = 18;
            this.buttonZplus.Text = "Z+";
            this.buttonZplus.UseVisualStyleBackColor = true;
            this.buttonZplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonZplus_Click);
            this.buttonZplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // buttonXplus
            // 
            this.buttonXplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXplus.Location = new System.Drawing.Point(128, 103);
            this.buttonXplus.Name = "buttonXplus";
            this.buttonXplus.Size = new System.Drawing.Size(45, 45);
            this.buttonXplus.TabIndex = 17;
            this.buttonXplus.Text = "X+";
            this.buttonXplus.UseVisualStyleBackColor = true;
            this.buttonXplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonXplus_Click);
            this.buttonXplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // buttonXminus
            // 
            this.buttonXminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXminus.Location = new System.Drawing.Point(9, 103);
            this.buttonXminus.Name = "buttonXminus";
            this.buttonXminus.Size = new System.Drawing.Size(45, 45);
            this.buttonXminus.TabIndex = 16;
            this.buttonXminus.Text = "X-";
            this.buttonXminus.UseVisualStyleBackColor = true;
            this.buttonXminus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonXminus_Click);
            this.buttonXminus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // buttonYminus
            // 
            this.buttonYminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYminus.Location = new System.Drawing.Point(66, 153);
            this.buttonYminus.Name = "buttonYminus";
            this.buttonYminus.Size = new System.Drawing.Size(45, 45);
            this.buttonYminus.TabIndex = 15;
            this.buttonYminus.Text = "Y-";
            this.buttonYminus.UseVisualStyleBackColor = true;
            this.buttonYminus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonYminus_Click);
            this.buttonYminus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // labelJOG
            // 
            this.labelJOG.AutoSize = true;
            this.labelJOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJOG.Location = new System.Drawing.Point(6, 23);
            this.labelJOG.Name = "labelJOG";
            this.labelJOG.Size = new System.Drawing.Size(42, 16);
            this.labelJOG.TabIndex = 14;
            this.labelJOG.Text = "JOG:";
            // 
            // buttonYplus
            // 
            this.buttonYplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYplus.Location = new System.Drawing.Point(66, 50);
            this.buttonYplus.Name = "buttonYplus";
            this.buttonYplus.Size = new System.Drawing.Size(45, 45);
            this.buttonYplus.TabIndex = 13;
            this.buttonYplus.Text = "Y+";
            this.buttonYplus.UseVisualStyleBackColor = true;
            this.buttonYplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonYplus_Click);
            this.buttonYplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // textBoxManualFeedrate
            // 
            this.textBoxManualFeedrate.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxManualFeedrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxManualFeedrate.Location = new System.Drawing.Point(190, 237);
            this.textBoxManualFeedrate.Name = "textBoxManualFeedrate";
            this.textBoxManualFeedrate.ReadOnly = true;
            this.textBoxManualFeedrate.Size = new System.Drawing.Size(47, 29);
            this.textBoxManualFeedrate.TabIndex = 12;
            this.textBoxManualFeedrate.Text = "0";
            // 
            // trackBarManualFeedrate
            // 
            this.trackBarManualFeedrate.Location = new System.Drawing.Point(9, 237);
            this.trackBarManualFeedrate.Maximum = 100;
            this.trackBarManualFeedrate.Name = "trackBarManualFeedrate";
            this.trackBarManualFeedrate.Size = new System.Drawing.Size(175, 45);
            this.trackBarManualFeedrate.TabIndex = 11;
            this.trackBarManualFeedrate.Scroll += new System.EventHandler(this.trackBarManualFeedrate_Scroll);
            // 
            // panelPosition
            // 
            this.panelPosition.Controls.Add(this.textBoxCurrentFeedRate);
            this.panelPosition.Controls.Add(this.labelCurrentFeedRate);
            this.panelPosition.Controls.Add(this.buttonHome);
            this.panelPosition.Controls.Add(this.buttonReset);
            this.panelPosition.Controls.Add(this.label1);
            this.panelPosition.Controls.Add(this.labelXa);
            this.panelPosition.Controls.Add(this.labelYa);
            this.panelPosition.Controls.Add(this.tableLayoutPanel2);
            this.panelPosition.Controls.Add(this.labelZm);
            this.panelPosition.Controls.Add(this.labelXm);
            this.panelPosition.Controls.Add(this.labelYm);
            this.panelPosition.Controls.Add(this.tableLayoutPanel1);
            this.panelPosition.Controls.Add(this.buttonSetZabsZero);
            this.panelPosition.Controls.Add(this.buttonSetYabsZero);
            this.panelPosition.Controls.Add(this.buttonSetXabsZero);
            this.panelPosition.Controls.Add(this.shapeContainer1);
            this.panelPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPosition.Location = new System.Drawing.Point(0, 0);
            this.panelPosition.Name = "panelPosition";
            this.panelPosition.Size = new System.Drawing.Size(401, 480);
            this.panelPosition.TabIndex = 11;
            // 
            // textBoxCurrentFeedRate
            // 
            this.textBoxCurrentFeedRate.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCurrentFeedRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentFeedRate.Location = new System.Drawing.Point(69, 382);
            this.textBoxCurrentFeedRate.Name = "textBoxCurrentFeedRate";
            this.textBoxCurrentFeedRate.ReadOnly = true;
            this.textBoxCurrentFeedRate.Size = new System.Drawing.Size(100, 29);
            this.textBoxCurrentFeedRate.TabIndex = 9;
            // 
            // labelCurrentFeedRate
            // 
            this.labelCurrentFeedRate.AutoSize = true;
            this.labelCurrentFeedRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentFeedRate.Location = new System.Drawing.Point(15, 363);
            this.labelCurrentFeedRate.Name = "labelCurrentFeedRate";
            this.labelCurrentFeedRate.Size = new System.Drawing.Size(138, 16);
            this.labelCurrentFeedRate.TabIndex = 13;
            this.labelCurrentFeedRate.Text = "Current Feed Rate:";
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(123, 439);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(99, 29);
            this.buttonHome.TabIndex = 12;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(18, 439);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(99, 29);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ZA:";
            // 
            // labelXa
            // 
            this.labelXa.AutoSize = true;
            this.labelXa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXa.Location = new System.Drawing.Point(15, 225);
            this.labelXa.Name = "labelXa";
            this.labelXa.Size = new System.Drawing.Size(31, 16);
            this.labelXa.TabIndex = 7;
            this.labelXa.Text = "XA:";
            // 
            // labelYa
            // 
            this.labelYa.AutoSize = true;
            this.labelYa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYa.Location = new System.Drawing.Point(15, 268);
            this.labelYa.Name = "labelYa";
            this.labelYa.Size = new System.Drawing.Size(32, 16);
            this.labelYa.TabIndex = 8;
            this.labelYa.Text = "YA:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.66129F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxZA, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxYA, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxXA, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(66, 213);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(109, 136);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // textBoxZA
            // 
            this.textBoxZA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxZA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZA.Location = new System.Drawing.Point(3, 89);
            this.textBoxZA.Name = "textBoxZA";
            this.textBoxZA.ReadOnly = true;
            this.textBoxZA.Size = new System.Drawing.Size(100, 29);
            this.textBoxZA.TabIndex = 8;
            // 
            // textBoxYA
            // 
            this.textBoxYA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxYA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYA.Location = new System.Drawing.Point(3, 46);
            this.textBoxYA.Name = "textBoxYA";
            this.textBoxYA.ReadOnly = true;
            this.textBoxYA.Size = new System.Drawing.Size(100, 29);
            this.textBoxYA.TabIndex = 7;
            // 
            // textBoxXA
            // 
            this.textBoxXA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxXA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXA.Location = new System.Drawing.Point(3, 3);
            this.textBoxXA.Name = "textBoxXA";
            this.textBoxXA.ReadOnly = true;
            this.textBoxXA.Size = new System.Drawing.Size(100, 29);
            this.textBoxXA.TabIndex = 6;
            // 
            // labelZm
            // 
            this.labelZm.AutoSize = true;
            this.labelZm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZm.Location = new System.Drawing.Point(15, 143);
            this.labelZm.Name = "labelZm";
            this.labelZm.Size = new System.Drawing.Size(33, 16);
            this.labelZm.TabIndex = 5;
            this.labelZm.Text = "ZM:";
            // 
            // labelXm
            // 
            this.labelXm.AutoSize = true;
            this.labelXm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXm.Location = new System.Drawing.Point(15, 57);
            this.labelXm.Name = "labelXm";
            this.labelXm.Size = new System.Drawing.Size(33, 16);
            this.labelXm.TabIndex = 3;
            this.labelXm.Text = "XM:";
            // 
            // labelYm
            // 
            this.labelYm.AutoSize = true;
            this.labelYm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYm.Location = new System.Drawing.Point(14, 100);
            this.labelYm.Name = "labelYm";
            this.labelYm.Size = new System.Drawing.Size(34, 16);
            this.labelYm.TabIndex = 4;
            this.labelYm.Text = "YM:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.66129F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxZm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxYm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxXm, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(109, 136);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // textBoxZm
            // 
            this.textBoxZm.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxZm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZm.Location = new System.Drawing.Point(3, 89);
            this.textBoxZm.Name = "textBoxZm";
            this.textBoxZm.ReadOnly = true;
            this.textBoxZm.Size = new System.Drawing.Size(100, 29);
            this.textBoxZm.TabIndex = 8;
            // 
            // textBoxYm
            // 
            this.textBoxYm.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxYm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYm.Location = new System.Drawing.Point(3, 46);
            this.textBoxYm.Name = "textBoxYm";
            this.textBoxYm.ReadOnly = true;
            this.textBoxYm.Size = new System.Drawing.Size(100, 29);
            this.textBoxYm.TabIndex = 7;
            // 
            // textBoxXm
            // 
            this.textBoxXm.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxXm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxXm.Location = new System.Drawing.Point(3, 3);
            this.textBoxXm.Name = "textBoxXm";
            this.textBoxXm.ReadOnly = true;
            this.textBoxXm.Size = new System.Drawing.Size(100, 29);
            this.textBoxXm.TabIndex = 6;
            // 
            // buttonSetZabsZero
            // 
            this.buttonSetZabsZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetZabsZero.Location = new System.Drawing.Point(199, 305);
            this.buttonSetZabsZero.Name = "buttonSetZabsZero";
            this.buttonSetZabsZero.Size = new System.Drawing.Size(99, 29);
            this.buttonSetZabsZero.TabIndex = 2;
            this.buttonSetZabsZero.Text = "Set Z Zero";
            this.buttonSetZabsZero.UseVisualStyleBackColor = true;
            this.buttonSetZabsZero.Click += new System.EventHandler(this.buttonSetZabsZero_Click);
            // 
            // buttonSetYabsZero
            // 
            this.buttonSetYabsZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetYabsZero.Location = new System.Drawing.Point(199, 262);
            this.buttonSetYabsZero.Name = "buttonSetYabsZero";
            this.buttonSetYabsZero.Size = new System.Drawing.Size(99, 29);
            this.buttonSetYabsZero.TabIndex = 1;
            this.buttonSetYabsZero.Text = "Set Y Zero";
            this.buttonSetYabsZero.UseVisualStyleBackColor = true;
            this.buttonSetYabsZero.Click += new System.EventHandler(this.buttonSetYabsZero_Click);
            // 
            // buttonSetXabsZero
            // 
            this.buttonSetXabsZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetXabsZero.Location = new System.Drawing.Point(199, 219);
            this.buttonSetXabsZero.Name = "buttonSetXabsZero";
            this.buttonSetXabsZero.Size = new System.Drawing.Size(99, 29);
            this.buttonSetXabsZero.TabIndex = 0;
            this.buttonSetXabsZero.Text = "Set X Zero";
            this.buttonSetXabsZero.UseVisualStyleBackColor = true;
            this.buttonSetXabsZero.Click += new System.EventHandler(this.buttonSetXabsZero_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShapePosition});
            this.shapeContainer1.Size = new System.Drawing.Size(401, 480);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShapePosition
            // 
            this.rectangleShapePosition.Location = new System.Drawing.Point(5, 5);
            this.rectangleShapePosition.Name = "rectangleShapePosition";
            this.rectangleShapePosition.Size = new System.Drawing.Size(389, 469);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // FormStandardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "FormStandardControl";
            this.Text = "HPCNC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStandardControl_FormClosing);
            this.Load += new System.EventHandler(this.FormStandardControl_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerControl.Panel1.ResumeLayout(false);
            this.splitContainerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            this.tabControlModes.ResumeLayout(false);
            this.tabPageAuto.ResumeLayout(false);
            this.tabPageAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAutoFeedRate)).EndInit();
            this.tabPageManual.ResumeLayout(false);
            this.tabPageManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarManualFeedrate)).EndInit();
            this.panelPosition.ResumeLayout(false);
            this.panelPosition.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.SplitContainer splitContainerControl;
        private System.Windows.Forms.TabControl tabControlModes;
        private System.Windows.Forms.TabPage tabPageAuto;
        private System.Windows.Forms.TabPage tabPageManual;
        private System.Windows.Forms.Panel panelPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelXa;
        private System.Windows.Forms.Label labelYa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxZA;
        private System.Windows.Forms.TextBox textBoxYA;
        private System.Windows.Forms.TextBox textBoxXA;
        private System.Windows.Forms.Label labelZm;
        private System.Windows.Forms.Label labelXm;
        private System.Windows.Forms.Label labelYm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxZm;
        private System.Windows.Forms.TextBox textBoxYm;
        private System.Windows.Forms.TextBox textBoxXm;
        private System.Windows.Forms.Button buttonSetZabsZero;
        private System.Windows.Forms.Button buttonSetYabsZero;
        private System.Windows.Forms.Button buttonSetXabsZero;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShapePosition;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxAutoFeedrate;
        private System.Windows.Forms.TrackBar trackBarAutoFeedRate;
        private System.Windows.Forms.Label labelGCode;
        private System.Windows.Forms.TextBox textBoxGcode;
        private System.Windows.Forms.Button buttonSendGcode;
        private System.Windows.Forms.TextBox textBoxManualFeedrate;
        private System.Windows.Forms.TrackBar trackBarManualFeedrate;
        private System.Windows.Forms.TextBox textBoxCurrentFeedRate;
        private System.Windows.Forms.Label labelCurrentFeedRate;
        private System.Windows.Forms.Button buttonZminus;
        private System.Windows.Forms.Button buttonZplus;
        private System.Windows.Forms.Button buttonXplus;
        private System.Windows.Forms.Button buttonXminus;
        private System.Windows.Forms.Button buttonYminus;
        private System.Windows.Forms.Label labelJOG;
        private System.Windows.Forms.Button buttonYplus;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelAutoFr;
        private System.Windows.Forms.Label labelManualFr;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStart;
    }
}