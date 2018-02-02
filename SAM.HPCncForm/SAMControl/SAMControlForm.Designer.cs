namespace SAM.HPCncForm.SAMControl
{
    partial class SAMControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAMControlForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.graphAScan = new ZedGraph.ZedGraphControl();
            this.graphBScan = new ZedGraph.ZedGraphControl();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControlScan = new System.Windows.Forms.TabControl();
            this.tabPageScan = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBoxCentralFrequency = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCentralFrequency = new System.Windows.Forms.Label();
            this.checkBoxVerify = new System.Windows.Forms.CheckBox();
            this.groupBoxScanInfo = new System.Windows.Forms.GroupBox();
            this.pictureBoxRecordDone = new System.Windows.Forms.PictureBox();
            this.labelRecordDone = new System.Windows.Forms.Label();
            this.textBoxScanStatus = new System.Windows.Forms.TextBox();
            this.textBoxBScanCount = new System.Windows.Forms.TextBox();
            this.textBoxRecordNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelScanInfo = new System.Windows.Forms.TableLayoutPanel();
            this.labelScanStatus = new System.Windows.Forms.Label();
            this.labelBScanCount = new System.Windows.Forms.Label();
            this.labelRecordNumber = new System.Windows.Forms.Label();
            this.groupBoxImageSetting = new System.Windows.Forms.GroupBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.comboBoxGrayLevel = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelGrayLevel = new System.Windows.Forms.Label();
            this.buttonScanAbort = new System.Windows.Forms.Button();
            this.buttonScanStop = new System.Windows.Forms.Button();
            this.buttonScanPause = new System.Windows.Forms.Button();
            this.groupBoxScanSetup = new System.Windows.Forms.GroupBox();
            this.textBoxScanSpeed = new System.Windows.Forms.TextBox();
            this.checkBoxMotionOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxAScanDisplay = new System.Windows.Forms.CheckBox();
            this.textBoxResolution = new System.Windows.Forms.TextBox();
            this.textBoxBScanNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutScanSetup = new System.Windows.Forms.TableLayoutPanel();
            this.labelBScanNumber = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelAScanDisplay = new System.Windows.Forms.Label();
            this.labelMotionOnly = new System.Windows.Forms.Label();
            this.labelScanSpeed = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.buttonScanStart = new System.Windows.Forms.Button();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.groupBoxCncConnection = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxCncCom = new System.Windows.Forms.ComboBox();
            this.textBoxCncStatus = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCom = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.groupBoxCNCStatus = new System.Windows.Forms.GroupBox();
            this.buttonSetZeroZ = new System.Windows.Forms.Button();
            this.buttonSetZeroY = new System.Windows.Forms.Button();
            this.buttonSetZeroX = new System.Windows.Forms.Button();
            this.textBoxZa = new System.Windows.Forms.TextBox();
            this.textBoxYa = new System.Windows.Forms.TextBox();
            this.textBoxXa = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelXa = new System.Windows.Forms.Label();
            this.labelYa = new System.Windows.Forms.Label();
            this.labelZa = new System.Windows.Forms.Label();
            this.groupBoxAuto = new System.Windows.Forms.GroupBox();
            this.buttonAutoPause = new System.Windows.Forms.Button();
            this.textBoxAutoSpeed = new System.Windows.Forms.TextBox();
            this.buttonAutoStart = new System.Windows.Forms.Button();
            this.textBoxZref = new System.Windows.Forms.TextBox();
            this.textBoxYref = new System.Windows.Forms.TextBox();
            this.textBoxXref = new System.Windows.Forms.TextBox();
            this.tableLayoutAuto = new System.Windows.Forms.TableLayoutPanel();
            this.labelXref = new System.Windows.Forms.Label();
            this.labelYref = new System.Windows.Forms.Label();
            this.labelZref = new System.Windows.Forms.Label();
            this.labelAutoSpeed = new System.Windows.Forms.Label();
            this.groupBoxManual = new System.Windows.Forms.GroupBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonYplus = new System.Windows.Forms.Button();
            this.buttonYminus = new System.Windows.Forms.Button();
            this.buttonXminus = new System.Windows.Forms.Button();
            this.buttonZminus = new System.Windows.Forms.Button();
            this.buttonXplus = new System.Windows.Forms.Button();
            this.buttonZplus = new System.Windows.Forms.Button();
            this.labelFeedrate = new System.Windows.Forms.Label();
            this.numericUpDownFeedRate = new System.Windows.Forms.NumericUpDown();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.groupBoxGraphAScan = new System.Windows.Forms.GroupBox();
            this.textBoxPlotAMin = new System.Windows.Forms.TextBox();
            this.textBoxPlotAMax = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPlotAMin = new System.Windows.Forms.Label();
            this.labelPlotAMax = new System.Windows.Forms.Label();
            this.tabPageRecord = new System.Windows.Forms.TabPage();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.textBoxSaveFilePath = new System.Windows.Forms.TextBox();
            this.textBoxSaveFileName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSaveFileName = new System.Windows.Forms.Label();
            this.labelSaveFolder = new System.Windows.Forms.Label();
            this.labelSaveFilePath = new System.Windows.Forms.Label();
            this.checkBoxSaveRawData = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveSimplifiedData = new System.Windows.Forms.CheckBox();
            this.buttonSaveFolder = new System.Windows.Forms.Button();
            this.textBoxSaveFolder = new System.Windows.Forms.TextBox();
            this.tabPageTransducerVerification = new System.Windows.Forms.TabPage();
            this.groupBoxDigitizer = new System.Windows.Forms.GroupBox();
            this.textBoxRecordLength = new System.Windows.Forms.TextBox();
            this.textBoxTriggerDelay = new System.Windows.Forms.TextBox();
            this.textBoxTimeOut = new System.Windows.Forms.TextBox();
            this.comboBoxTriggerSource = new System.Windows.Forms.ComboBox();
            this.textBoxVerticalRange = new System.Windows.Forms.TextBox();
            this.textBoxTriggerLevel = new System.Windows.Forms.TextBox();
            this.comboBoxResourceName = new System.Windows.Forms.ComboBox();
            this.comboBoxSampleRate = new System.Windows.Forms.ComboBox();
            this.comboBoxChannel = new System.Windows.Forms.ComboBox();
            this.tableLayoutDigitizer = new System.Windows.Forms.TableLayoutPanel();
            this.labelRecordLength = new System.Windows.Forms.Label();
            this.labelTriggerDelay = new System.Windows.Forms.Label();
            this.labelFetchDataTimeOut = new System.Windows.Forms.Label();
            this.labelVerticalRange = new System.Windows.Forms.Label();
            this.labelTriggerLevel = new System.Windows.Forms.Label();
            this.labelSampleRate = new System.Windows.Forms.Label();
            this.labelChannel = new System.Windows.Forms.Label();
            this.labelTriggerSource = new System.Windows.Forms.Label();
            this.labelResourceName = new System.Windows.Forms.Label();
            this.timerMainLoop = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControlScan.SuspendLayout();
            this.tabPageScan.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBoxScanInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecordDone)).BeginInit();
            this.tableLayoutPanelScanInfo.SuspendLayout();
            this.groupBoxImageSetting.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBoxScanSetup.SuspendLayout();
            this.tableLayoutScanSetup.SuspendLayout();
            this.tabPageSetting.SuspendLayout();
            this.groupBoxCncConnection.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxCNCStatus.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxAuto.SuspendLayout();
            this.tableLayoutAuto.SuspendLayout();
            this.groupBoxManual.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeedRate)).BeginInit();
            this.tabPageGraph.SuspendLayout();
            this.groupBoxGraphAScan.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPageRecord.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBoxDigitizer.SuspendLayout();
            this.tableLayoutDigitizer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 682);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.graphAScan);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.graphBScan);
            this.splitContainer2.Size = new System.Drawing.Size(1264, 312);
            this.splitContainer2.SplitterDistance = 651;
            this.splitContainer2.TabIndex = 0;
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
            this.graphAScan.Size = new System.Drawing.Size(651, 312);
            this.graphAScan.TabIndex = 0;
            // 
            // graphBScan
            // 
            this.graphBScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphBScan.Location = new System.Drawing.Point(0, 0);
            this.graphBScan.Name = "graphBScan";
            this.graphBScan.ScrollGrace = 0D;
            this.graphBScan.ScrollMaxX = 0D;
            this.graphBScan.ScrollMaxY = 0D;
            this.graphBScan.ScrollMaxY2 = 0D;
            this.graphBScan.ScrollMinX = 0D;
            this.graphBScan.ScrollMinY = 0D;
            this.graphBScan.ScrollMinY2 = 0D;
            this.graphBScan.Size = new System.Drawing.Size(609, 312);
            this.graphBScan.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControlScan);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBoxDigitizer);
            this.splitContainer3.Size = new System.Drawing.Size(1264, 366);
            this.splitContainer3.SplitterDistance = 971;
            this.splitContainer3.TabIndex = 0;
            // 
            // tabControlScan
            // 
            this.tabControlScan.Controls.Add(this.tabPageScan);
            this.tabControlScan.Controls.Add(this.tabPageSetting);
            this.tabControlScan.Controls.Add(this.tabPageGraph);
            this.tabControlScan.Controls.Add(this.tabPageRecord);
            this.tabControlScan.Controls.Add(this.tabPageTransducerVerification);
            this.tabControlScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlScan.Location = new System.Drawing.Point(0, 0);
            this.tabControlScan.Name = "tabControlScan";
            this.tabControlScan.SelectedIndex = 0;
            this.tabControlScan.Size = new System.Drawing.Size(971, 366);
            this.tabControlScan.TabIndex = 0;
            // 
            // tabPageScan
            // 
            this.tabPageScan.Controls.Add(this.groupBox);
            this.tabPageScan.Controls.Add(this.groupBoxScanInfo);
            this.tabPageScan.Controls.Add(this.groupBoxImageSetting);
            this.tabPageScan.Controls.Add(this.buttonScanAbort);
            this.tabPageScan.Controls.Add(this.buttonScanStop);
            this.tabPageScan.Controls.Add(this.buttonScanPause);
            this.tabPageScan.Controls.Add(this.groupBoxScanSetup);
            this.tabPageScan.Controls.Add(this.buttonScanStart);
            this.tabPageScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageScan.Location = new System.Drawing.Point(4, 25);
            this.tabPageScan.Name = "tabPageScan";
            this.tabPageScan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScan.Size = new System.Drawing.Size(963, 337);
            this.tabPageScan.TabIndex = 0;
            this.tabPageScan.Text = "SCAN";
            this.tabPageScan.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxCentralFrequency);
            this.groupBox.Controls.Add(this.tableLayoutPanel7);
            this.groupBox.Location = new System.Drawing.Point(269, 153);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(256, 176);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Transducer";
            // 
            // textBoxCentralFrequency
            // 
            this.textBoxCentralFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCentralFrequency.Location = new System.Drawing.Point(158, 30);
            this.textBoxCentralFrequency.Name = "textBoxCentralFrequency";
            this.textBoxCentralFrequency.Size = new System.Drawing.Size(90, 24);
            this.textBoxCentralFrequency.TabIndex = 5;
            this.textBoxCentralFrequency.Text = "MHz";
            this.textBoxCentralFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.labelCentralFrequency, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.checkBoxVerify, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50001F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50001F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50001F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(149, 155);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // labelCentralFrequency
            // 
            this.labelCentralFrequency.AutoSize = true;
            this.labelCentralFrequency.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCentralFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCentralFrequency.Location = new System.Drawing.Point(3, 0);
            this.labelCentralFrequency.Name = "labelCentralFrequency";
            this.labelCentralFrequency.Size = new System.Drawing.Size(138, 51);
            this.labelCentralFrequency.TabIndex = 0;
            this.labelCentralFrequency.Text = "Central Frequency:";
            this.labelCentralFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxVerify
            // 
            this.checkBoxVerify.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxVerify.AutoSize = true;
            this.checkBoxVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVerify.Location = new System.Drawing.Point(3, 54);
            this.checkBoxVerify.Name = "checkBoxVerify";
            this.checkBoxVerify.Size = new System.Drawing.Size(60, 28);
            this.checkBoxVerify.TabIndex = 1;
            this.checkBoxVerify.Text = "Verify";
            this.checkBoxVerify.UseVisualStyleBackColor = true;
            // 
            // groupBoxScanInfo
            // 
            this.groupBoxScanInfo.Controls.Add(this.pictureBoxRecordDone);
            this.groupBoxScanInfo.Controls.Add(this.labelRecordDone);
            this.groupBoxScanInfo.Controls.Add(this.textBoxScanStatus);
            this.groupBoxScanInfo.Controls.Add(this.textBoxBScanCount);
            this.groupBoxScanInfo.Controls.Add(this.textBoxRecordNumber);
            this.groupBoxScanInfo.Controls.Add(this.tableLayoutPanelScanInfo);
            this.groupBoxScanInfo.Location = new System.Drawing.Point(531, 6);
            this.groupBoxScanInfo.Name = "groupBoxScanInfo";
            this.groupBoxScanInfo.Size = new System.Drawing.Size(426, 141);
            this.groupBoxScanInfo.TabIndex = 12;
            this.groupBoxScanInfo.TabStop = false;
            this.groupBoxScanInfo.Text = "Info";
            // 
            // pictureBoxRecordDone
            // 
            this.pictureBoxRecordDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRecordDone.BackgroundImage")));
            this.pictureBoxRecordDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRecordDone.InitialImage = null;
            this.pictureBoxRecordDone.Location = new System.Drawing.Point(332, 48);
            this.pictureBoxRecordDone.Name = "pictureBoxRecordDone";
            this.pictureBoxRecordDone.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxRecordDone.TabIndex = 18;
            this.pictureBoxRecordDone.TabStop = false;
            // 
            // labelRecordDone
            // 
            this.labelRecordDone.AutoSize = true;
            this.labelRecordDone.Location = new System.Drawing.Point(300, 29);
            this.labelRecordDone.Name = "labelRecordDone";
            this.labelRecordDone.Size = new System.Drawing.Size(100, 16);
            this.labelRecordDone.TabIndex = 16;
            this.labelRecordDone.Text = "Record Done";
            // 
            // textBoxScanStatus
            // 
            this.textBoxScanStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScanStatus.Location = new System.Drawing.Point(148, 104);
            this.textBoxScanStatus.Name = "textBoxScanStatus";
            this.textBoxScanStatus.ReadOnly = true;
            this.textBoxScanStatus.Size = new System.Drawing.Size(100, 24);
            this.textBoxScanStatus.TabIndex = 15;
            this.textBoxScanStatus.Text = "No Error";
            this.textBoxScanStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBScanCount
            // 
            this.textBoxBScanCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBScanCount.Location = new System.Drawing.Point(148, 63);
            this.textBoxBScanCount.Name = "textBoxBScanCount";
            this.textBoxBScanCount.ReadOnly = true;
            this.textBoxBScanCount.Size = new System.Drawing.Size(100, 24);
            this.textBoxBScanCount.TabIndex = 14;
            this.textBoxBScanCount.Text = "0";
            this.textBoxBScanCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxRecordNumber
            // 
            this.textBoxRecordNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecordNumber.Location = new System.Drawing.Point(148, 24);
            this.textBoxRecordNumber.Name = "textBoxRecordNumber";
            this.textBoxRecordNumber.ReadOnly = true;
            this.textBoxRecordNumber.Size = new System.Drawing.Size(100, 24);
            this.textBoxRecordNumber.TabIndex = 13;
            this.textBoxRecordNumber.Text = "0";
            this.textBoxRecordNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanelScanInfo
            // 
            this.tableLayoutPanelScanInfo.ColumnCount = 1;
            this.tableLayoutPanelScanInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelScanInfo.Controls.Add(this.labelScanStatus, 0, 2);
            this.tableLayoutPanelScanInfo.Controls.Add(this.labelBScanCount, 0, 1);
            this.tableLayoutPanelScanInfo.Controls.Add(this.labelRecordNumber, 0, 0);
            this.tableLayoutPanelScanInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelScanInfo.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanelScanInfo.Name = "tableLayoutPanelScanInfo";
            this.tableLayoutPanelScanInfo.RowCount = 3;
            this.tableLayoutPanelScanInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50001F));
            this.tableLayoutPanelScanInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50001F));
            this.tableLayoutPanelScanInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50001F));
            this.tableLayoutPanelScanInfo.Size = new System.Drawing.Size(139, 120);
            this.tableLayoutPanelScanInfo.TabIndex = 3;
            // 
            // labelScanStatus
            // 
            this.labelScanStatus.AutoSize = true;
            this.labelScanStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelScanStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScanStatus.Location = new System.Drawing.Point(3, 78);
            this.labelScanStatus.Name = "labelScanStatus";
            this.labelScanStatus.Size = new System.Drawing.Size(55, 42);
            this.labelScanStatus.TabIndex = 2;
            this.labelScanStatus.Text = "Status:";
            this.labelScanStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBScanCount
            // 
            this.labelBScanCount.AutoSize = true;
            this.labelBScanCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBScanCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBScanCount.Location = new System.Drawing.Point(3, 39);
            this.labelBScanCount.Name = "labelBScanCount";
            this.labelBScanCount.Size = new System.Drawing.Size(104, 39);
            this.labelBScanCount.TabIndex = 1;
            this.labelBScanCount.Text = "B Scan Count:";
            this.labelBScanCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecordNumber
            // 
            this.labelRecordNumber.AutoSize = true;
            this.labelRecordNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRecordNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecordNumber.Location = new System.Drawing.Point(3, 0);
            this.labelRecordNumber.Name = "labelRecordNumber";
            this.labelRecordNumber.Size = new System.Drawing.Size(121, 39);
            this.labelRecordNumber.TabIndex = 0;
            this.labelRecordNumber.Text = "Record Number:";
            this.labelRecordNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxImageSetting
            // 
            this.groupBoxImageSetting.Controls.Add(this.textBoxMin);
            this.groupBoxImageSetting.Controls.Add(this.textBoxMax);
            this.groupBoxImageSetting.Controls.Add(this.comboBoxGrayLevel);
            this.groupBoxImageSetting.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxImageSetting.Location = new System.Drawing.Point(269, 6);
            this.groupBoxImageSetting.Name = "groupBoxImageSetting";
            this.groupBoxImageSetting.Size = new System.Drawing.Size(256, 141);
            this.groupBoxImageSetting.TabIndex = 11;
            this.groupBoxImageSetting.TabStop = false;
            this.groupBoxImageSetting.Text = "Quantization Setting";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMin.Location = new System.Drawing.Point(148, 104);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 24);
            this.textBoxMin.TabIndex = 2;
            this.textBoxMin.Text = "0";
            this.textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxMin.Leave += new System.EventHandler(this.textBoxMin_Leave);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMax.Location = new System.Drawing.Point(148, 63);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 24);
            this.textBoxMax.TabIndex = 1;
            this.textBoxMax.Text = "1";
            this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxMax.Leave += new System.EventHandler(this.textBoxMax_Leave);
            // 
            // comboBoxGrayLevel
            // 
            this.comboBoxGrayLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrayLevel.FormattingEnabled = true;
            this.comboBoxGrayLevel.Items.AddRange(new object[] {
            "256"});
            this.comboBoxGrayLevel.Location = new System.Drawing.Point(148, 26);
            this.comboBoxGrayLevel.Name = "comboBoxGrayLevel";
            this.comboBoxGrayLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxGrayLevel.Size = new System.Drawing.Size(100, 24);
            this.comboBoxGrayLevel.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelMin, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelMax, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelGrayLevel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50001F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50001F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50001F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(139, 120);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(3, 78);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(36, 42);
            this.labelMin.TabIndex = 2;
            this.labelMin.Text = "Min:";
            this.labelMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(3, 39);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(40, 39);
            this.labelMax.TabIndex = 1;
            this.labelMax.Text = "MaxAmp:";
            this.labelMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGrayLevel
            // 
            this.labelGrayLevel.AutoSize = true;
            this.labelGrayLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelGrayLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrayLevel.Location = new System.Drawing.Point(3, 0);
            this.labelGrayLevel.Name = "labelGrayLevel";
            this.labelGrayLevel.Size = new System.Drawing.Size(87, 39);
            this.labelGrayLevel.TabIndex = 0;
            this.labelGrayLevel.Text = "Gray Level:";
            this.labelGrayLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonScanAbort
            // 
            this.buttonScanAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScanAbort.ForeColor = System.Drawing.Color.Red;
            this.buttonScanAbort.Location = new System.Drawing.Point(882, 301);
            this.buttonScanAbort.Name = "buttonScanAbort";
            this.buttonScanAbort.Size = new System.Drawing.Size(75, 28);
            this.buttonScanAbort.TabIndex = 10;
            this.buttonScanAbort.Text = "Abort";
            this.buttonScanAbort.UseVisualStyleBackColor = true;
            this.buttonScanAbort.Click += new System.EventHandler(this.buttonScanAbort_Click);
            // 
            // buttonScanStop
            // 
            this.buttonScanStop.BackColor = System.Drawing.Color.Red;
            this.buttonScanStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScanStop.Location = new System.Drawing.Point(801, 301);
            this.buttonScanStop.Name = "buttonScanStop";
            this.buttonScanStop.Size = new System.Drawing.Size(75, 28);
            this.buttonScanStop.TabIndex = 9;
            this.buttonScanStop.Text = "Stop";
            this.buttonScanStop.UseVisualStyleBackColor = false;
            this.buttonScanStop.Click += new System.EventHandler(this.buttonScanStop_Click);
            // 
            // buttonScanPause
            // 
            this.buttonScanPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonScanPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScanPause.Location = new System.Drawing.Point(720, 301);
            this.buttonScanPause.Name = "buttonScanPause";
            this.buttonScanPause.Size = new System.Drawing.Size(75, 28);
            this.buttonScanPause.TabIndex = 8;
            this.buttonScanPause.Text = "Pause";
            this.buttonScanPause.UseVisualStyleBackColor = false;
            // 
            // groupBoxScanSetup
            // 
            this.groupBoxScanSetup.Controls.Add(this.textBoxScanSpeed);
            this.groupBoxScanSetup.Controls.Add(this.checkBoxMotionOnly);
            this.groupBoxScanSetup.Controls.Add(this.checkBoxAScanDisplay);
            this.groupBoxScanSetup.Controls.Add(this.textBoxResolution);
            this.groupBoxScanSetup.Controls.Add(this.textBoxBScanNumber);
            this.groupBoxScanSetup.Controls.Add(this.tableLayoutScanSetup);
            this.groupBoxScanSetup.Controls.Add(this.textBoxDistance);
            this.groupBoxScanSetup.Location = new System.Drawing.Point(8, 6);
            this.groupBoxScanSetup.Name = "groupBoxScanSetup";
            this.groupBoxScanSetup.Size = new System.Drawing.Size(255, 323);
            this.groupBoxScanSetup.TabIndex = 7;
            this.groupBoxScanSetup.TabStop = false;
            this.groupBoxScanSetup.Text = "Scan Setup";
            // 
            // textBoxScanSpeed
            // 
            this.textBoxScanSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScanSpeed.Location = new System.Drawing.Point(148, 155);
            this.textBoxScanSpeed.Name = "textBoxScanSpeed";
            this.textBoxScanSpeed.Size = new System.Drawing.Size(100, 24);
            this.textBoxScanSpeed.TabIndex = 15;
            this.textBoxScanSpeed.Text = "1500";
            this.textBoxScanSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxScanSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxScanSpeed.Leave += new System.EventHandler(this.textBoxScanSpeed_Leave);
            // 
            // checkBoxMotionOnly
            // 
            this.checkBoxMotionOnly.AutoSize = true;
            this.checkBoxMotionOnly.Location = new System.Drawing.Point(148, 248);
            this.checkBoxMotionOnly.Name = "checkBoxMotionOnly";
            this.checkBoxMotionOnly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxMotionOnly.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMotionOnly.TabIndex = 17;
            this.checkBoxMotionOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxAScanDisplay
            // 
            this.checkBoxAScanDisplay.AutoSize = true;
            this.checkBoxAScanDisplay.Location = new System.Drawing.Point(148, 205);
            this.checkBoxAScanDisplay.Name = "checkBoxAScanDisplay";
            this.checkBoxAScanDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAScanDisplay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAScanDisplay.TabIndex = 16;
            this.checkBoxAScanDisplay.UseVisualStyleBackColor = true;
            // 
            // textBoxResolution
            // 
            this.textBoxResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResolution.Location = new System.Drawing.Point(148, 26);
            this.textBoxResolution.Name = "textBoxResolution";
            this.textBoxResolution.Size = new System.Drawing.Size(100, 24);
            this.textBoxResolution.TabIndex = 12;
            this.textBoxResolution.Text = "0.02";
            this.textBoxResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxResolution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxResolution.Leave += new System.EventHandler(this.textBoxResolution_Leave);
            // 
            // textBoxBScanNumber
            // 
            this.textBoxBScanNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBScanNumber.Location = new System.Drawing.Point(148, 112);
            this.textBoxBScanNumber.Name = "textBoxBScanNumber";
            this.textBoxBScanNumber.Size = new System.Drawing.Size(100, 24);
            this.textBoxBScanNumber.TabIndex = 14;
            this.textBoxBScanNumber.Text = "500";
            this.textBoxBScanNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBScanNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxBScanNumber.Leave += new System.EventHandler(this.textBoxBScanNumber_Leave);
            // 
            // tableLayoutScanSetup
            // 
            this.tableLayoutScanSetup.ColumnCount = 1;
            this.tableLayoutScanSetup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutScanSetup.Controls.Add(this.labelBScanNumber, 0, 2);
            this.tableLayoutScanSetup.Controls.Add(this.labelDistance, 0, 1);
            this.tableLayoutScanSetup.Controls.Add(this.labelResolution, 0, 0);
            this.tableLayoutScanSetup.Controls.Add(this.labelAScanDisplay, 0, 4);
            this.tableLayoutScanSetup.Controls.Add(this.labelMotionOnly, 0, 5);
            this.tableLayoutScanSetup.Controls.Add(this.labelScanSpeed, 0, 3);
            this.tableLayoutScanSetup.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutScanSetup.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutScanSetup.Name = "tableLayoutScanSetup";
            this.tableLayoutScanSetup.RowCount = 8;
            this.tableLayoutScanSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutScanSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutScanSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutScanSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutScanSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutScanSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutScanSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28565F));
            this.tableLayoutScanSetup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutScanSetup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutScanSetup.Size = new System.Drawing.Size(139, 302);
            this.tableLayoutScanSetup.TabIndex = 1;
            // 
            // labelBScanNumber
            // 
            this.labelBScanNumber.AutoSize = true;
            this.labelBScanNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBScanNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBScanNumber.Location = new System.Drawing.Point(3, 86);
            this.labelBScanNumber.Name = "labelBScanNumber";
            this.labelBScanNumber.Size = new System.Drawing.Size(119, 43);
            this.labelBScanNumber.TabIndex = 3;
            this.labelBScanNumber.Text = "B Scan Number:";
            this.labelBScanNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistance.Location = new System.Drawing.Point(3, 43);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(73, 43);
            this.labelDistance.TabIndex = 2;
            this.labelDistance.Text = "Distance:";
            this.labelDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResolution.Location = new System.Drawing.Point(3, 0);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(86, 43);
            this.labelResolution.TabIndex = 1;
            this.labelResolution.Text = "Resolution:";
            this.labelResolution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAScanDisplay
            // 
            this.labelAScanDisplay.AutoSize = true;
            this.labelAScanDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAScanDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAScanDisplay.Location = new System.Drawing.Point(3, 172);
            this.labelAScanDisplay.Name = "labelAScanDisplay";
            this.labelAScanDisplay.Size = new System.Drawing.Size(118, 43);
            this.labelAScanDisplay.TabIndex = 4;
            this.labelAScanDisplay.Text = "A Scan Display:";
            this.labelAScanDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMotionOnly
            // 
            this.labelMotionOnly.AutoSize = true;
            this.labelMotionOnly.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMotionOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotionOnly.Location = new System.Drawing.Point(3, 215);
            this.labelMotionOnly.Name = "labelMotionOnly";
            this.labelMotionOnly.Size = new System.Drawing.Size(93, 43);
            this.labelMotionOnly.TabIndex = 5;
            this.labelMotionOnly.Text = "Motion Only:";
            this.labelMotionOnly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelScanSpeed
            // 
            this.labelScanSpeed.AutoSize = true;
            this.labelScanSpeed.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelScanSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScanSpeed.Location = new System.Drawing.Point(3, 129);
            this.labelScanSpeed.Name = "labelScanSpeed";
            this.labelScanSpeed.Size = new System.Drawing.Size(58, 43);
            this.labelScanSpeed.TabIndex = 6;
            this.labelScanSpeed.Text = "Speed:";
            this.labelScanSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistance.Location = new System.Drawing.Point(148, 69);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 24);
            this.textBoxDistance.TabIndex = 13;
            this.textBoxDistance.Text = "5";
            this.textBoxDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDistance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxDistance.Leave += new System.EventHandler(this.textBoxDistance_Leave);
            // 
            // buttonScanStart
            // 
            this.buttonScanStart.BackColor = System.Drawing.Color.Lime;
            this.buttonScanStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScanStart.Location = new System.Drawing.Point(639, 301);
            this.buttonScanStart.Name = "buttonScanStart";
            this.buttonScanStart.Size = new System.Drawing.Size(75, 28);
            this.buttonScanStart.TabIndex = 0;
            this.buttonScanStart.Text = "Start";
            this.buttonScanStart.UseVisualStyleBackColor = false;
            this.buttonScanStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.Controls.Add(this.groupBoxCncConnection);
            this.tabPageSetting.Controls.Add(this.groupBoxCNCStatus);
            this.tabPageSetting.Controls.Add(this.groupBoxAuto);
            this.tabPageSetting.Controls.Add(this.groupBoxManual);
            this.tabPageSetting.Location = new System.Drawing.Point(4, 25);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetting.Size = new System.Drawing.Size(963, 337);
            this.tabPageSetting.TabIndex = 1;
            this.tabPageSetting.Text = "CNC";
            this.tabPageSetting.UseVisualStyleBackColor = true;
            // 
            // groupBoxCncConnection
            // 
            this.groupBoxCncConnection.Controls.Add(this.buttonConnect);
            this.groupBoxCncConnection.Controls.Add(this.comboBoxCncCom);
            this.groupBoxCncConnection.Controls.Add(this.textBoxCncStatus);
            this.groupBoxCncConnection.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxCncConnection.Location = new System.Drawing.Point(8, 9);
            this.groupBoxCncConnection.Name = "groupBoxCncConnection";
            this.groupBoxCncConnection.Size = new System.Drawing.Size(182, 322);
            this.groupBoxCncConnection.TabIndex = 10;
            this.groupBoxCncConnection.TabStop = false;
            this.groupBoxCncConnection.Text = "CONNECTION";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Transparent;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.Red;
            this.buttonConnect.Location = new System.Drawing.Point(6, 250);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(111, 35);
            this.buttonConnect.TabIndex = 14;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxCncCom
            // 
            this.comboBoxCncCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCncCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCncCom.FormattingEnabled = true;
            this.comboBoxCncCom.Location = new System.Drawing.Point(73, 37);
            this.comboBoxCncCom.Name = "comboBoxCncCom";
            this.comboBoxCncCom.Size = new System.Drawing.Size(97, 26);
            this.comboBoxCncCom.TabIndex = 13;
            // 
            // textBoxCncStatus
            // 
            this.textBoxCncStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCncStatus.Location = new System.Drawing.Point(70, 95);
            this.textBoxCncStatus.Multiline = true;
            this.textBoxCncStatus.Name = "textBoxCncStatus";
            this.textBoxCncStatus.ReadOnly = true;
            this.textBoxCncStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCncStatus.Size = new System.Drawing.Size(112, 146);
            this.textBoxCncStatus.TabIndex = 12;
            this.textBoxCncStatus.Text = "DISCONNECT";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelCom, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelConnectionStatus, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(61, 110);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCom.Location = new System.Drawing.Point(3, 0);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(40, 55);
            this.labelCom.TabIndex = 0;
            this.labelCom.Text = "Port:";
            this.labelCom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionStatus.Location = new System.Drawing.Point(3, 55);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(55, 55);
            this.labelConnectionStatus.TabIndex = 1;
            this.labelConnectionStatus.Text = "Status:";
            this.labelConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxCNCStatus
            // 
            this.groupBoxCNCStatus.Controls.Add(this.buttonSetZeroZ);
            this.groupBoxCNCStatus.Controls.Add(this.buttonSetZeroY);
            this.groupBoxCNCStatus.Controls.Add(this.buttonSetZeroX);
            this.groupBoxCNCStatus.Controls.Add(this.textBoxZa);
            this.groupBoxCNCStatus.Controls.Add(this.textBoxYa);
            this.groupBoxCNCStatus.Controls.Add(this.textBoxXa);
            this.groupBoxCNCStatus.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxCNCStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCNCStatus.Location = new System.Drawing.Point(686, 9);
            this.groupBoxCNCStatus.Name = "groupBoxCNCStatus";
            this.groupBoxCNCStatus.Size = new System.Drawing.Size(272, 322);
            this.groupBoxCNCStatus.TabIndex = 9;
            this.groupBoxCNCStatus.TabStop = false;
            this.groupBoxCNCStatus.Text = "Position";
            // 
            // buttonSetZeroZ
            // 
            this.buttonSetZeroZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetZeroZ.Location = new System.Drawing.Point(167, 143);
            this.buttonSetZeroZ.Name = "buttonSetZeroZ";
            this.buttonSetZeroZ.Size = new System.Drawing.Size(90, 35);
            this.buttonSetZeroZ.TabIndex = 11;
            this.buttonSetZeroZ.Text = "Set Zero";
            this.buttonSetZeroZ.UseVisualStyleBackColor = true;
            this.buttonSetZeroZ.Click += new System.EventHandler(this.buttonSetZeroZ_Click);
            // 
            // buttonSetZeroY
            // 
            this.buttonSetZeroY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetZeroY.Location = new System.Drawing.Point(167, 88);
            this.buttonSetZeroY.Name = "buttonSetZeroY";
            this.buttonSetZeroY.Size = new System.Drawing.Size(90, 35);
            this.buttonSetZeroY.TabIndex = 10;
            this.buttonSetZeroY.Text = "Set Zero";
            this.buttonSetZeroY.UseVisualStyleBackColor = true;
            this.buttonSetZeroY.Click += new System.EventHandler(this.buttonSetZeroY_Click);
            // 
            // buttonSetZeroX
            // 
            this.buttonSetZeroX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetZeroX.Location = new System.Drawing.Point(167, 33);
            this.buttonSetZeroX.Name = "buttonSetZeroX";
            this.buttonSetZeroX.Size = new System.Drawing.Size(90, 35);
            this.buttonSetZeroX.TabIndex = 9;
            this.buttonSetZeroX.Text = "Set Zero";
            this.buttonSetZeroX.UseVisualStyleBackColor = true;
            this.buttonSetZeroX.Click += new System.EventHandler(this.buttonSetZeroX_Click);
            // 
            // textBoxZa
            // 
            this.textBoxZa.Location = new System.Drawing.Point(75, 147);
            this.textBoxZa.Name = "textBoxZa";
            this.textBoxZa.ReadOnly = true;
            this.textBoxZa.Size = new System.Drawing.Size(86, 24);
            this.textBoxZa.TabIndex = 8;
            this.textBoxZa.Text = "0";
            this.textBoxZa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxYa
            // 
            this.textBoxYa.Location = new System.Drawing.Point(75, 92);
            this.textBoxYa.Name = "textBoxYa";
            this.textBoxYa.ReadOnly = true;
            this.textBoxYa.Size = new System.Drawing.Size(86, 24);
            this.textBoxYa.TabIndex = 7;
            this.textBoxYa.Text = "0";
            this.textBoxYa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxXa
            // 
            this.textBoxXa.Location = new System.Drawing.Point(75, 37);
            this.textBoxXa.Name = "textBoxXa";
            this.textBoxXa.ReadOnly = true;
            this.textBoxXa.Size = new System.Drawing.Size(86, 24);
            this.textBoxXa.TabIndex = 6;
            this.textBoxXa.Text = "0";
            this.textBoxXa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelXa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelYa, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelZa, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(63, 221);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelXa
            // 
            this.labelXa.AutoSize = true;
            this.labelXa.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelXa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXa.Location = new System.Drawing.Point(3, 0);
            this.labelXa.Name = "labelXa";
            this.labelXa.Size = new System.Drawing.Size(28, 55);
            this.labelXa.TabIndex = 0;
            this.labelXa.Text = "Xa";
            this.labelXa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYa
            // 
            this.labelYa.AutoSize = true;
            this.labelYa.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelYa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYa.Location = new System.Drawing.Point(3, 55);
            this.labelYa.Name = "labelYa";
            this.labelYa.Size = new System.Drawing.Size(27, 55);
            this.labelYa.TabIndex = 1;
            this.labelYa.Text = "Ya";
            this.labelYa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZa
            // 
            this.labelZa.AutoSize = true;
            this.labelZa.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZa.Location = new System.Drawing.Point(3, 110);
            this.labelZa.Name = "labelZa";
            this.labelZa.Size = new System.Drawing.Size(27, 55);
            this.labelZa.TabIndex = 2;
            this.labelZa.Text = "Za";
            this.labelZa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxAuto
            // 
            this.groupBoxAuto.Controls.Add(this.buttonAutoPause);
            this.groupBoxAuto.Controls.Add(this.textBoxAutoSpeed);
            this.groupBoxAuto.Controls.Add(this.buttonAutoStart);
            this.groupBoxAuto.Controls.Add(this.textBoxZref);
            this.groupBoxAuto.Controls.Add(this.textBoxYref);
            this.groupBoxAuto.Controls.Add(this.textBoxXref);
            this.groupBoxAuto.Controls.Add(this.tableLayoutAuto);
            this.groupBoxAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAuto.Location = new System.Drawing.Point(487, 9);
            this.groupBoxAuto.Name = "groupBoxAuto";
            this.groupBoxAuto.Size = new System.Drawing.Size(193, 323);
            this.groupBoxAuto.TabIndex = 8;
            this.groupBoxAuto.TabStop = false;
            this.groupBoxAuto.Text = "Auto";
            // 
            // buttonAutoPause
            // 
            this.buttonAutoPause.Location = new System.Drawing.Point(98, 249);
            this.buttonAutoPause.Name = "buttonAutoPause";
            this.buttonAutoPause.Size = new System.Drawing.Size(86, 35);
            this.buttonAutoPause.TabIndex = 6;
            this.buttonAutoPause.Text = "Pause";
            this.buttonAutoPause.UseVisualStyleBackColor = true;
            this.buttonAutoPause.Click += new System.EventHandler(this.buttonAutoPause_Click);
            // 
            // textBoxAutoSpeed
            // 
            this.textBoxAutoSpeed.Location = new System.Drawing.Point(72, 203);
            this.textBoxAutoSpeed.Name = "textBoxAutoSpeed";
            this.textBoxAutoSpeed.Size = new System.Drawing.Size(86, 24);
            this.textBoxAutoSpeed.TabIndex = 4;
            this.textBoxAutoSpeed.Text = "500";
            this.textBoxAutoSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAutoSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxAutoSpeed.Leave += new System.EventHandler(this.textBoxAutoSpeed_Leave);
            // 
            // buttonAutoStart
            // 
            this.buttonAutoStart.Location = new System.Drawing.Point(6, 249);
            this.buttonAutoStart.Name = "buttonAutoStart";
            this.buttonAutoStart.Size = new System.Drawing.Size(86, 35);
            this.buttonAutoStart.TabIndex = 5;
            this.buttonAutoStart.Text = "Start";
            this.buttonAutoStart.UseVisualStyleBackColor = true;
            this.buttonAutoStart.Click += new System.EventHandler(this.buttonAutoStart_Click);
            // 
            // textBoxZref
            // 
            this.textBoxZref.Location = new System.Drawing.Point(72, 147);
            this.textBoxZref.Name = "textBoxZref";
            this.textBoxZref.Size = new System.Drawing.Size(86, 24);
            this.textBoxZref.TabIndex = 3;
            this.textBoxZref.Text = "0";
            this.textBoxZref.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZref.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxZref.Leave += new System.EventHandler(this.textBoxZref_Leave);
            // 
            // textBoxYref
            // 
            this.textBoxYref.Location = new System.Drawing.Point(70, 92);
            this.textBoxYref.Name = "textBoxYref";
            this.textBoxYref.Size = new System.Drawing.Size(86, 24);
            this.textBoxYref.TabIndex = 2;
            this.textBoxYref.Text = "0";
            this.textBoxYref.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxYref.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxYref.Leave += new System.EventHandler(this.textBoxYref_Leave);
            // 
            // textBoxXref
            // 
            this.textBoxXref.Location = new System.Drawing.Point(70, 37);
            this.textBoxXref.Name = "textBoxXref";
            this.textBoxXref.Size = new System.Drawing.Size(86, 24);
            this.textBoxXref.TabIndex = 1;
            this.textBoxXref.Text = "0";
            this.textBoxXref.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxXref.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxXref.Leave += new System.EventHandler(this.textBoxXref_Leave);
            // 
            // tableLayoutAuto
            // 
            this.tableLayoutAuto.ColumnCount = 1;
            this.tableLayoutAuto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAuto.Controls.Add(this.labelXref, 0, 0);
            this.tableLayoutAuto.Controls.Add(this.labelYref, 0, 1);
            this.tableLayoutAuto.Controls.Add(this.labelZref, 0, 2);
            this.tableLayoutAuto.Controls.Add(this.labelAutoSpeed, 0, 3);
            this.tableLayoutAuto.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutAuto.Name = "tableLayoutAuto";
            this.tableLayoutAuto.RowCount = 4;
            this.tableLayoutAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutAuto.Size = new System.Drawing.Size(63, 221);
            this.tableLayoutAuto.TabIndex = 0;
            // 
            // labelXref
            // 
            this.labelXref.AutoSize = true;
            this.labelXref.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelXref.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXref.Location = new System.Drawing.Point(3, 0);
            this.labelXref.Name = "labelXref";
            this.labelXref.Size = new System.Drawing.Size(25, 55);
            this.labelXref.TabIndex = 0;
            this.labelXref.Text = "Xr";
            this.labelXref.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYref
            // 
            this.labelYref.AutoSize = true;
            this.labelYref.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelYref.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYref.Location = new System.Drawing.Point(3, 55);
            this.labelYref.Name = "labelYref";
            this.labelYref.Size = new System.Drawing.Size(24, 55);
            this.labelYref.TabIndex = 1;
            this.labelYref.Text = "Yr";
            this.labelYref.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZref
            // 
            this.labelZref.AutoSize = true;
            this.labelZref.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZref.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZref.Location = new System.Drawing.Point(3, 110);
            this.labelZref.Name = "labelZref";
            this.labelZref.Size = new System.Drawing.Size(24, 55);
            this.labelZref.TabIndex = 2;
            this.labelZref.Text = "Zr";
            this.labelZref.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAutoSpeed
            // 
            this.labelAutoSpeed.AutoSize = true;
            this.labelAutoSpeed.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAutoSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoSpeed.Location = new System.Drawing.Point(3, 165);
            this.labelAutoSpeed.Name = "labelAutoSpeed";
            this.labelAutoSpeed.Size = new System.Drawing.Size(55, 56);
            this.labelAutoSpeed.TabIndex = 3;
            this.labelAutoSpeed.Text = "Speed";
            this.labelAutoSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxManual
            // 
            this.groupBoxManual.Controls.Add(this.buttonHome);
            this.groupBoxManual.Controls.Add(this.buttonReset);
            this.groupBoxManual.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxManual.Controls.Add(this.labelFeedrate);
            this.groupBoxManual.Controls.Add(this.numericUpDownFeedRate);
            this.groupBoxManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxManual.Location = new System.Drawing.Point(196, 9);
            this.groupBoxManual.Name = "groupBoxManual";
            this.groupBoxManual.Size = new System.Drawing.Size(285, 323);
            this.groupBoxManual.TabIndex = 7;
            this.groupBoxManual.TabStop = false;
            this.groupBoxManual.Text = "Manual";
            // 
            // buttonHome
            // 
            this.buttonHome.ForeColor = System.Drawing.Color.Black;
            this.buttonHome.Location = new System.Drawing.Point(102, 250);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(86, 35);
            this.buttonHome.TabIndex = 12;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.ForeColor = System.Drawing.Color.Black;
            this.buttonReset.Location = new System.Drawing.Point(10, 250);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(86, 35);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonYplus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonYminus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonXminus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonZminus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonXplus, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonZplus, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 192);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // buttonYplus
            // 
            this.buttonYplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYplus.Location = new System.Drawing.Point(70, 3);
            this.buttonYplus.Name = "buttonYplus";
            this.buttonYplus.Size = new System.Drawing.Size(40, 40);
            this.buttonYplus.TabIndex = 0;
            this.buttonYplus.Text = "Y+";
            this.buttonYplus.UseVisualStyleBackColor = true;
            this.buttonYplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonYplus_Click);
            this.buttonYplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // buttonYminus
            // 
            this.buttonYminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYminus.Location = new System.Drawing.Point(70, 117);
            this.buttonYminus.Name = "buttonYminus";
            this.buttonYminus.Size = new System.Drawing.Size(40, 40);
            this.buttonYminus.TabIndex = 3;
            this.buttonYminus.Text = "Y-";
            this.buttonYminus.UseVisualStyleBackColor = true;
            this.buttonYminus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonYminus_Click);
            this.buttonYminus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // buttonXminus
            // 
            this.buttonXminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXminus.Location = new System.Drawing.Point(3, 60);
            this.buttonXminus.Name = "buttonXminus";
            this.buttonXminus.Size = new System.Drawing.Size(40, 40);
            this.buttonXminus.TabIndex = 5;
            this.buttonXminus.Text = "X-";
            this.buttonXminus.UseVisualStyleBackColor = true;
            this.buttonXminus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonXminus_Click);
            this.buttonXminus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // buttonZminus
            // 
            this.buttonZminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZminus.Location = new System.Drawing.Point(204, 117);
            this.buttonZminus.Name = "buttonZminus";
            this.buttonZminus.Size = new System.Drawing.Size(40, 40);
            this.buttonZminus.TabIndex = 7;
            this.buttonZminus.Text = "Z-";
            this.buttonZminus.UseVisualStyleBackColor = true;
            this.buttonZminus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonZminus_Click);
            this.buttonZminus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // buttonXplus
            // 
            this.buttonXplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXplus.Location = new System.Drawing.Point(137, 60);
            this.buttonXplus.Name = "buttonXplus";
            this.buttonXplus.Size = new System.Drawing.Size(40, 40);
            this.buttonXplus.TabIndex = 4;
            this.buttonXplus.Text = "X+";
            this.buttonXplus.UseVisualStyleBackColor = true;
            this.buttonXplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonXplus_Click);
            this.buttonXplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // buttonZplus
            // 
            this.buttonZplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZplus.Location = new System.Drawing.Point(204, 3);
            this.buttonZplus.Name = "buttonZplus";
            this.buttonZplus.Size = new System.Drawing.Size(40, 40);
            this.buttonZplus.TabIndex = 6;
            this.buttonZplus.Text = "Z+";
            this.buttonZplus.UseVisualStyleBackColor = true;
            this.buttonZplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonZplus_Click);
            this.buttonZplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.releaseJoggingButton);
            // 
            // labelFeedrate
            // 
            this.labelFeedrate.AutoSize = true;
            this.labelFeedrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeedrate.Location = new System.Drawing.Point(6, 22);
            this.labelFeedrate.Name = "labelFeedrate";
            this.labelFeedrate.Size = new System.Drawing.Size(90, 18);
            this.labelFeedrate.TabIndex = 9;
            this.labelFeedrate.Text = "Feed Rate:";
            // 
            // numericUpDownFeedRate
            // 
            this.numericUpDownFeedRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFeedRate.Location = new System.Drawing.Point(102, 20);
            this.numericUpDownFeedRate.Name = "numericUpDownFeedRate";
            this.numericUpDownFeedRate.Size = new System.Drawing.Size(63, 24);
            this.numericUpDownFeedRate.TabIndex = 8;
            this.numericUpDownFeedRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownFeedRate.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownFeedRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.Controls.Add(this.groupBoxGraphAScan);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 25);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Size = new System.Drawing.Size(963, 337);
            this.tabPageGraph.TabIndex = 2;
            this.tabPageGraph.Text = "Graph";
            this.tabPageGraph.UseVisualStyleBackColor = true;
            // 
            // groupBoxGraphAScan
            // 
            this.groupBoxGraphAScan.Controls.Add(this.textBoxPlotAMin);
            this.groupBoxGraphAScan.Controls.Add(this.textBoxPlotAMax);
            this.groupBoxGraphAScan.Controls.Add(this.tableLayoutPanel5);
            this.groupBoxGraphAScan.Location = new System.Drawing.Point(8, 3);
            this.groupBoxGraphAScan.Name = "groupBoxGraphAScan";
            this.groupBoxGraphAScan.Size = new System.Drawing.Size(200, 116);
            this.groupBoxGraphAScan.TabIndex = 0;
            this.groupBoxGraphAScan.TabStop = false;
            this.groupBoxGraphAScan.Text = "A Scan";
            // 
            // textBoxPlotAMin
            // 
            this.textBoxPlotAMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlotAMin.Location = new System.Drawing.Point(94, 76);
            this.textBoxPlotAMin.Name = "textBoxPlotAMin";
            this.textBoxPlotAMin.Size = new System.Drawing.Size(100, 24);
            this.textBoxPlotAMin.TabIndex = 14;
            this.textBoxPlotAMin.Text = "-0.25";
            this.textBoxPlotAMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPlotAMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxPlotAMin.Leave += new System.EventHandler(this.textBoxPlotAMin_Leave);
            // 
            // textBoxPlotAMax
            // 
            this.textBoxPlotAMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlotAMax.Location = new System.Drawing.Point(94, 28);
            this.textBoxPlotAMax.Name = "textBoxPlotAMax";
            this.textBoxPlotAMax.Size = new System.Drawing.Size(100, 24);
            this.textBoxPlotAMax.TabIndex = 13;
            this.textBoxPlotAMax.Text = "0.35";
            this.textBoxPlotAMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPlotAMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxPlotAMax.Leave += new System.EventHandler(this.textBoxPlotAMax_Leave);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.labelPlotAMin, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelPlotAMax, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(85, 95);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // labelPlotAMin
            // 
            this.labelPlotAMin.AutoSize = true;
            this.labelPlotAMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPlotAMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlotAMin.Location = new System.Drawing.Point(3, 47);
            this.labelPlotAMin.Name = "labelPlotAMin";
            this.labelPlotAMin.Size = new System.Drawing.Size(36, 48);
            this.labelPlotAMin.TabIndex = 2;
            this.labelPlotAMin.Text = "Min:";
            this.labelPlotAMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPlotAMax
            // 
            this.labelPlotAMax.AutoSize = true;
            this.labelPlotAMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPlotAMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlotAMax.Location = new System.Drawing.Point(3, 0);
            this.labelPlotAMax.Name = "labelPlotAMax";
            this.labelPlotAMax.Size = new System.Drawing.Size(40, 47);
            this.labelPlotAMax.TabIndex = 1;
            this.labelPlotAMax.Text = "MaxAmp:";
            this.labelPlotAMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageRecord
            // 
            this.tabPageRecord.Controls.Add(this.groupBoxSettings);
            this.tabPageRecord.Location = new System.Drawing.Point(4, 25);
            this.tabPageRecord.Name = "tabPageRecord";
            this.tabPageRecord.Size = new System.Drawing.Size(963, 337);
            this.tabPageRecord.TabIndex = 3;
            this.tabPageRecord.Text = "Record";
            this.tabPageRecord.UseVisualStyleBackColor = true;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.textBoxSaveFilePath);
            this.groupBoxSettings.Controls.Add(this.textBoxSaveFileName);
            this.groupBoxSettings.Controls.Add(this.tableLayoutPanel6);
            this.groupBoxSettings.Controls.Add(this.buttonSaveFolder);
            this.groupBoxSettings.Controls.Add(this.textBoxSaveFolder);
            this.groupBoxSettings.Location = new System.Drawing.Point(8, 3);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(952, 326);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // textBoxSaveFilePath
            // 
            this.textBoxSaveFilePath.Location = new System.Drawing.Point(148, 114);
            this.textBoxSaveFilePath.Multiline = true;
            this.textBoxSaveFilePath.Name = "textBoxSaveFilePath";
            this.textBoxSaveFilePath.ReadOnly = true;
            this.textBoxSaveFilePath.Size = new System.Drawing.Size(762, 22);
            this.textBoxSaveFilePath.TabIndex = 5;
            // 
            // textBoxSaveFileName
            // 
            this.textBoxSaveFileName.Location = new System.Drawing.Point(148, 71);
            this.textBoxSaveFileName.Name = "textBoxSaveFileName";
            this.textBoxSaveFileName.Size = new System.Drawing.Size(762, 22);
            this.textBoxSaveFileName.TabIndex = 4;
            this.textBoxSaveFileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxSaveFileName.Leave += new System.EventHandler(this.textBoxSaveFileName_Leave);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.labelSaveFileName, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelSaveFolder, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelSaveFilePath, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.checkBoxSaveRawData, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.checkBoxSaveSimplifiedData, 0, 4);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 8;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28573F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28565F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(139, 305);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // labelSaveFileName
            // 
            this.labelSaveFileName.AutoSize = true;
            this.labelSaveFileName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSaveFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveFileName.Location = new System.Drawing.Point(3, 43);
            this.labelSaveFileName.Name = "labelSaveFileName";
            this.labelSaveFileName.Size = new System.Drawing.Size(83, 43);
            this.labelSaveFileName.TabIndex = 2;
            this.labelSaveFileName.Text = "File Name:";
            this.labelSaveFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSaveFolder
            // 
            this.labelSaveFolder.AutoSize = true;
            this.labelSaveFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSaveFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveFolder.Location = new System.Drawing.Point(3, 0);
            this.labelSaveFolder.Name = "labelSaveFolder";
            this.labelSaveFolder.Size = new System.Drawing.Size(57, 43);
            this.labelSaveFolder.TabIndex = 1;
            this.labelSaveFolder.Text = "Folder:";
            this.labelSaveFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSaveFilePath
            // 
            this.labelSaveFilePath.AutoSize = true;
            this.labelSaveFilePath.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSaveFilePath.Location = new System.Drawing.Point(3, 86);
            this.labelSaveFilePath.Name = "labelSaveFilePath";
            this.labelSaveFilePath.Size = new System.Drawing.Size(113, 43);
            this.labelSaveFilePath.TabIndex = 3;
            this.labelSaveFilePath.Text = "Save File Path:";
            this.labelSaveFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxSaveRawData
            // 
            this.checkBoxSaveRawData.AutoSize = true;
            this.checkBoxSaveRawData.Location = new System.Drawing.Point(3, 218);
            this.checkBoxSaveRawData.Name = "checkBoxSaveRawData";
            this.checkBoxSaveRawData.Size = new System.Drawing.Size(57, 20);
            this.checkBoxSaveRawData.TabIndex = 5;
            this.checkBoxSaveRawData.Text = "Raw";
            this.checkBoxSaveRawData.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveSimplifiedData
            // 
            this.checkBoxSaveSimplifiedData.AutoSize = true;
            this.checkBoxSaveSimplifiedData.Location = new System.Drawing.Point(3, 175);
            this.checkBoxSaveSimplifiedData.Name = "checkBoxSaveSimplifiedData";
            this.checkBoxSaveSimplifiedData.Size = new System.Drawing.Size(96, 20);
            this.checkBoxSaveSimplifiedData.TabIndex = 4;
            this.checkBoxSaveSimplifiedData.Text = "Simplified";
            this.checkBoxSaveSimplifiedData.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFolder
            // 
            this.buttonSaveFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSaveFolder.BackgroundImage")));
            this.buttonSaveFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSaveFolder.Location = new System.Drawing.Point(916, 25);
            this.buttonSaveFolder.Name = "buttonSaveFolder";
            this.buttonSaveFolder.Size = new System.Drawing.Size(30, 29);
            this.buttonSaveFolder.TabIndex = 2;
            this.buttonSaveFolder.UseVisualStyleBackColor = true;
            this.buttonSaveFolder.Click += new System.EventHandler(this.buttonSaveFolder_Click);
            // 
            // textBoxSaveFolder
            // 
            this.textBoxSaveFolder.Location = new System.Drawing.Point(148, 28);
            this.textBoxSaveFolder.Multiline = true;
            this.textBoxSaveFolder.Name = "textBoxSaveFolder";
            this.textBoxSaveFolder.ReadOnly = true;
            this.textBoxSaveFolder.Size = new System.Drawing.Size(762, 20);
            this.textBoxSaveFolder.TabIndex = 0;
            // 
            // tabPageTransducerVerification
            // 
            this.tabPageTransducerVerification.Location = new System.Drawing.Point(4, 25);
            this.tabPageTransducerVerification.Name = "tabPageTransducerVerification";
            this.tabPageTransducerVerification.Size = new System.Drawing.Size(963, 337);
            this.tabPageTransducerVerification.TabIndex = 4;
            this.tabPageTransducerVerification.Text = "Transducer";
            this.tabPageTransducerVerification.UseVisualStyleBackColor = true;
            // 
            // groupBoxDigitizer
            // 
            this.groupBoxDigitizer.Controls.Add(this.textBoxRecordLength);
            this.groupBoxDigitizer.Controls.Add(this.textBoxTriggerDelay);
            this.groupBoxDigitizer.Controls.Add(this.textBoxTimeOut);
            this.groupBoxDigitizer.Controls.Add(this.comboBoxTriggerSource);
            this.groupBoxDigitizer.Controls.Add(this.textBoxVerticalRange);
            this.groupBoxDigitizer.Controls.Add(this.textBoxTriggerLevel);
            this.groupBoxDigitizer.Controls.Add(this.comboBoxResourceName);
            this.groupBoxDigitizer.Controls.Add(this.comboBoxSampleRate);
            this.groupBoxDigitizer.Controls.Add(this.comboBoxChannel);
            this.groupBoxDigitizer.Controls.Add(this.tableLayoutDigitizer);
            this.groupBoxDigitizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDigitizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDigitizer.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDigitizer.Name = "groupBoxDigitizer";
            this.groupBoxDigitizer.Size = new System.Drawing.Size(289, 366);
            this.groupBoxDigitizer.TabIndex = 0;
            this.groupBoxDigitizer.TabStop = false;
            this.groupBoxDigitizer.Text = "DIGITIZER";
            // 
            // textBoxRecordLength
            // 
            this.textBoxRecordLength.Location = new System.Drawing.Point(177, 330);
            this.textBoxRecordLength.Name = "textBoxRecordLength";
            this.textBoxRecordLength.Size = new System.Drawing.Size(100, 24);
            this.textBoxRecordLength.TabIndex = 8;
            this.textBoxRecordLength.Text = "500";
            this.textBoxRecordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxRecordLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxRecordLength.Leave += new System.EventHandler(this.textBoxRecordLength_Leave);
            // 
            // textBoxTriggerDelay
            // 
            this.textBoxTriggerDelay.Location = new System.Drawing.Point(177, 293);
            this.textBoxTriggerDelay.Name = "textBoxTriggerDelay";
            this.textBoxTriggerDelay.Size = new System.Drawing.Size(100, 24);
            this.textBoxTriggerDelay.TabIndex = 7;
            this.textBoxTriggerDelay.Text = "36.8";
            this.textBoxTriggerDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTriggerDelay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxTriggerDelay.Leave += new System.EventHandler(this.textBoxTriggerDelay_Leave);
            // 
            // textBoxTimeOut
            // 
            this.textBoxTimeOut.Location = new System.Drawing.Point(177, 254);
            this.textBoxTimeOut.Name = "textBoxTimeOut";
            this.textBoxTimeOut.Size = new System.Drawing.Size(100, 24);
            this.textBoxTimeOut.TabIndex = 6;
            this.textBoxTimeOut.Text = "5";
            this.textBoxTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTimeOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxTimeOut.Leave += new System.EventHandler(this.textBoxTimeOut_Leave);
            // 
            // comboBoxTriggerSource
            // 
            this.comboBoxTriggerSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTriggerSource.FormattingEnabled = true;
            this.comboBoxTriggerSource.Items.AddRange(new object[] {
            "None",
            "Internal",
            "External"});
            this.comboBoxTriggerSource.Location = new System.Drawing.Point(177, 64);
            this.comboBoxTriggerSource.Name = "comboBoxTriggerSource";
            this.comboBoxTriggerSource.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxTriggerSource.Size = new System.Drawing.Size(100, 26);
            this.comboBoxTriggerSource.TabIndex = 2;
            this.comboBoxTriggerSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxTriggerSource_SelectedIndexChanged);
            // 
            // textBoxVerticalRange
            // 
            this.textBoxVerticalRange.Location = new System.Drawing.Point(177, 216);
            this.textBoxVerticalRange.Name = "textBoxVerticalRange";
            this.textBoxVerticalRange.Size = new System.Drawing.Size(100, 24);
            this.textBoxVerticalRange.TabIndex = 5;
            this.textBoxVerticalRange.Text = "1.5";
            this.textBoxVerticalRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxVerticalRange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxVerticalRange.Leave += new System.EventHandler(this.textBoxVerticalRange_Leave);
            // 
            // textBoxTriggerLevel
            // 
            this.textBoxTriggerLevel.Location = new System.Drawing.Point(177, 178);
            this.textBoxTriggerLevel.Name = "textBoxTriggerLevel";
            this.textBoxTriggerLevel.Size = new System.Drawing.Size(100, 24);
            this.textBoxTriggerLevel.TabIndex = 4;
            this.textBoxTriggerLevel.Text = "2.0";
            this.textBoxTriggerLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTriggerLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leaveTextBox_whenPressEnter);
            this.textBoxTriggerLevel.Leave += new System.EventHandler(this.textBoxTriggerLevel_Leave);
            // 
            // comboBoxResourceName
            // 
            this.comboBoxResourceName.FormattingEnabled = true;
            this.comboBoxResourceName.Items.AddRange(new object[] {
            "Dev1"});
            this.comboBoxResourceName.Location = new System.Drawing.Point(177, 26);
            this.comboBoxResourceName.Name = "comboBoxResourceName";
            this.comboBoxResourceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxResourceName.Size = new System.Drawing.Size(100, 26);
            this.comboBoxResourceName.TabIndex = 1;
            this.comboBoxResourceName.SelectedIndexChanged += new System.EventHandler(this.comboBoxResourceName_SelectedIndexChanged);
            // 
            // comboBoxSampleRate
            // 
            this.comboBoxSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSampleRate.FormattingEnabled = true;
            this.comboBoxSampleRate.Items.AddRange(new object[] {
            "100M",
            "500M",
            "750M",
            "1000M",
            "1500M",
            "2000M"});
            this.comboBoxSampleRate.Location = new System.Drawing.Point(177, 140);
            this.comboBoxSampleRate.Name = "comboBoxSampleRate";
            this.comboBoxSampleRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSampleRate.Size = new System.Drawing.Size(100, 26);
            this.comboBoxSampleRate.TabIndex = 9;
            this.comboBoxSampleRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxSampleRate_SelectedIndexChanged);
            // 
            // comboBoxChannel
            // 
            this.comboBoxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChannel.FormattingEnabled = true;
            this.comboBoxChannel.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBoxChannel.Location = new System.Drawing.Point(177, 102);
            this.comboBoxChannel.Name = "comboBoxChannel";
            this.comboBoxChannel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxChannel.Size = new System.Drawing.Size(100, 26);
            this.comboBoxChannel.TabIndex = 3;
            this.comboBoxChannel.SelectedIndexChanged += new System.EventHandler(this.comboBoxChannel_SelectedIndexChanged);
            // 
            // tableLayoutDigitizer
            // 
            this.tableLayoutDigitizer.ColumnCount = 1;
            this.tableLayoutDigitizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutDigitizer.Controls.Add(this.labelRecordLength, 0, 8);
            this.tableLayoutDigitizer.Controls.Add(this.labelTriggerDelay, 0, 7);
            this.tableLayoutDigitizer.Controls.Add(this.labelFetchDataTimeOut, 0, 6);
            this.tableLayoutDigitizer.Controls.Add(this.labelVerticalRange, 0, 5);
            this.tableLayoutDigitizer.Controls.Add(this.labelTriggerLevel, 0, 4);
            this.tableLayoutDigitizer.Controls.Add(this.labelSampleRate, 0, 3);
            this.tableLayoutDigitizer.Controls.Add(this.labelChannel, 0, 2);
            this.tableLayoutDigitizer.Controls.Add(this.labelTriggerSource, 0, 1);
            this.tableLayoutDigitizer.Controls.Add(this.labelResourceName, 0, 0);
            this.tableLayoutDigitizer.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutDigitizer.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutDigitizer.Name = "tableLayoutDigitizer";
            this.tableLayoutDigitizer.RowCount = 10;
            this.tableLayoutDigitizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutDigitizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
            this.tableLayoutDigitizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
            this.tableLayoutDigitizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
            this.tableLayoutDigitizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
            this.tableLayoutDigitizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
            this.tableLayoutDigitizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
            this.tableLayoutDigitizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
            this.tableLayoutDigitizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11106F));
            this.tableLayoutDigitizer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutDigitizer.Size = new System.Drawing.Size(168, 343);
            this.tableLayoutDigitizer.TabIndex = 0;
            // 
            // labelRecordLength
            // 
            this.labelRecordLength.AutoSize = true;
            this.labelRecordLength.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRecordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecordLength.Location = new System.Drawing.Point(3, 304);
            this.labelRecordLength.Name = "labelRecordLength";
            this.labelRecordLength.Size = new System.Drawing.Size(113, 38);
            this.labelRecordLength.TabIndex = 7;
            this.labelRecordLength.Text = "Record Length:";
            this.labelRecordLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTriggerDelay
            // 
            this.labelTriggerDelay.AutoSize = true;
            this.labelTriggerDelay.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTriggerDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTriggerDelay.Location = new System.Drawing.Point(3, 266);
            this.labelTriggerDelay.Name = "labelTriggerDelay";
            this.labelTriggerDelay.Size = new System.Drawing.Size(138, 38);
            this.labelTriggerDelay.TabIndex = 6;
            this.labelTriggerDelay.Text = "Trigger Delay (us):";
            this.labelTriggerDelay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFetchDataTimeOut
            // 
            this.labelFetchDataTimeOut.AutoSize = true;
            this.labelFetchDataTimeOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFetchDataTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFetchDataTimeOut.Location = new System.Drawing.Point(3, 228);
            this.labelFetchDataTimeOut.Name = "labelFetchDataTimeOut";
            this.labelFetchDataTimeOut.Size = new System.Drawing.Size(74, 38);
            this.labelFetchDataTimeOut.TabIndex = 5;
            this.labelFetchDataTimeOut.Text = "Time Out:";
            this.labelFetchDataTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVerticalRange
            // 
            this.labelVerticalRange.AutoSize = true;
            this.labelVerticalRange.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelVerticalRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerticalRange.Location = new System.Drawing.Point(3, 190);
            this.labelVerticalRange.Name = "labelVerticalRange";
            this.labelVerticalRange.Size = new System.Drawing.Size(115, 38);
            this.labelVerticalRange.TabIndex = 4;
            this.labelVerticalRange.Text = "Vertical Range:";
            this.labelVerticalRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTriggerLevel
            // 
            this.labelTriggerLevel.AutoSize = true;
            this.labelTriggerLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTriggerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTriggerLevel.Location = new System.Drawing.Point(3, 152);
            this.labelTriggerLevel.Name = "labelTriggerLevel";
            this.labelTriggerLevel.Size = new System.Drawing.Size(105, 38);
            this.labelTriggerLevel.TabIndex = 3;
            this.labelTriggerLevel.Text = "Trigger Level:";
            this.labelTriggerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSampleRate
            // 
            this.labelSampleRate.AutoSize = true;
            this.labelSampleRate.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSampleRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleRate.Location = new System.Drawing.Point(3, 114);
            this.labelSampleRate.Name = "labelSampleRate";
            this.labelSampleRate.Size = new System.Drawing.Size(102, 38);
            this.labelSampleRate.TabIndex = 2;
            this.labelSampleRate.Text = "Sample Rate:";
            this.labelSampleRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChannel.Location = new System.Drawing.Point(3, 76);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(68, 38);
            this.labelChannel.TabIndex = 1;
            this.labelChannel.Text = "Channel:";
            this.labelChannel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTriggerSource
            // 
            this.labelTriggerSource.AutoSize = true;
            this.labelTriggerSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTriggerSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTriggerSource.Location = new System.Drawing.Point(3, 38);
            this.labelTriggerSource.Name = "labelTriggerSource";
            this.labelTriggerSource.Size = new System.Drawing.Size(116, 38);
            this.labelTriggerSource.TabIndex = 0;
            this.labelTriggerSource.Text = "Trigger Source:";
            this.labelTriggerSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelResourceName
            // 
            this.labelResourceName.AutoSize = true;
            this.labelResourceName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelResourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResourceName.Location = new System.Drawing.Point(3, 0);
            this.labelResourceName.Name = "labelResourceName";
            this.labelResourceName.Size = new System.Drawing.Size(124, 38);
            this.labelResourceName.TabIndex = 0;
            this.labelResourceName.Text = "Resource Name:";
            this.labelResourceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerMainLoop
            // 
            this.timerMainLoop.Interval = 200;
            this.timerMainLoop.Tick += new System.EventHandler(this.timerCncUpdate_Tick);
            // 
            // SAMControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SAMControlForm";
            this.Text = "SAM";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControlScan.ResumeLayout(false);
            this.tabPageScan.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBoxScanInfo.ResumeLayout(false);
            this.groupBoxScanInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecordDone)).EndInit();
            this.tableLayoutPanelScanInfo.ResumeLayout(false);
            this.tableLayoutPanelScanInfo.PerformLayout();
            this.groupBoxImageSetting.ResumeLayout(false);
            this.groupBoxImageSetting.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBoxScanSetup.ResumeLayout(false);
            this.groupBoxScanSetup.PerformLayout();
            this.tableLayoutScanSetup.ResumeLayout(false);
            this.tableLayoutScanSetup.PerformLayout();
            this.tabPageSetting.ResumeLayout(false);
            this.groupBoxCncConnection.ResumeLayout(false);
            this.groupBoxCncConnection.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBoxCNCStatus.ResumeLayout(false);
            this.groupBoxCNCStatus.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxAuto.ResumeLayout(false);
            this.groupBoxAuto.PerformLayout();
            this.tableLayoutAuto.ResumeLayout(false);
            this.tableLayoutAuto.PerformLayout();
            this.groupBoxManual.ResumeLayout(false);
            this.groupBoxManual.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeedRate)).EndInit();
            this.tabPageGraph.ResumeLayout(false);
            this.groupBoxGraphAScan.ResumeLayout(false);
            this.groupBoxGraphAScan.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPageRecord.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBoxDigitizer.ResumeLayout(false);
            this.groupBoxDigitizer.PerformLayout();
            this.tableLayoutDigitizer.ResumeLayout(false);
            this.tableLayoutDigitizer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ZedGraph.ZedGraphControl graphAScan;
        private ZedGraph.ZedGraphControl graphBScan;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button buttonScanStart;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Button buttonYplus;
        private System.Windows.Forms.Button buttonXminus;
        private System.Windows.Forms.Button buttonXplus;
        private System.Windows.Forms.Button buttonYminus;
        private System.Windows.Forms.NumericUpDown numericUpDownFeedRate;
        private System.Windows.Forms.Button buttonZminus;
        private System.Windows.Forms.Button buttonZplus;
        private System.Windows.Forms.Label labelFeedrate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxManual;
        private System.Windows.Forms.TabControl tabControlScan;
        private System.Windows.Forms.TabPage tabPageScan;
        private System.Windows.Forms.TabPage tabPageSetting;
        private System.Windows.Forms.GroupBox groupBoxAuto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAuto;
        private System.Windows.Forms.Label labelXref;
        private System.Windows.Forms.Label labelYref;
        private System.Windows.Forms.Label labelZref;
        private System.Windows.Forms.TextBox textBoxZref;
        private System.Windows.Forms.TextBox textBoxYref;
        private System.Windows.Forms.TextBox textBoxXref;
        private System.Windows.Forms.TextBox textBoxAutoSpeed;
        private System.Windows.Forms.Label labelAutoSpeed;
        private System.Windows.Forms.GroupBox groupBoxCNCStatus;
        private System.Windows.Forms.TextBox textBoxCncStatus;
        private System.Windows.Forms.Button buttonSetZeroZ;
        private System.Windows.Forms.Button buttonSetZeroY;
        private System.Windows.Forms.Button buttonSetZeroX;
        private System.Windows.Forms.TextBox textBoxZa;
        private System.Windows.Forms.TextBox textBoxYa;
        private System.Windows.Forms.TextBox textBoxXa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelXa;
        private System.Windows.Forms.Label labelYa;
        private System.Windows.Forms.Label labelZa;
        private System.Windows.Forms.Button buttonAutoPause;
        private System.Windows.Forms.Button buttonAutoStart;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBoxCncConnection;
        private System.Windows.Forms.ComboBox comboBoxCncCom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBoxDigitizer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutDigitizer;
        private System.Windows.Forms.Label labelRecordLength;
        private System.Windows.Forms.Label labelTriggerDelay;
        private System.Windows.Forms.Label labelFetchDataTimeOut;
        private System.Windows.Forms.Label labelVerticalRange;
        private System.Windows.Forms.Label labelTriggerLevel;
        private System.Windows.Forms.Label labelSampleRate;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Label labelResourceName;
        private System.Windows.Forms.TextBox textBoxVerticalRange;
        private System.Windows.Forms.TextBox textBoxTriggerLevel;
        private System.Windows.Forms.ComboBox comboBoxSampleRate;
        private System.Windows.Forms.ComboBox comboBoxChannel;
        private System.Windows.Forms.ComboBox comboBoxResourceName;
        private System.Windows.Forms.TextBox textBoxRecordLength;
        private System.Windows.Forms.TextBox textBoxTriggerDelay;
        private System.Windows.Forms.TextBox textBoxTimeOut;
        private System.Windows.Forms.Button buttonScanAbort;
        private System.Windows.Forms.Button buttonScanStop;
        private System.Windows.Forms.Button buttonScanPause;
        private System.Windows.Forms.GroupBox groupBoxScanSetup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutScanSetup;
        private System.Windows.Forms.Label labelMotionOnly;
        private System.Windows.Forms.Label labelAScanDisplay;
        private System.Windows.Forms.Label labelBScanNumber;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelTriggerSource;
        private System.Windows.Forms.TextBox textBoxResolution;
        private System.Windows.Forms.ComboBox comboBoxTriggerSource;
        private System.Windows.Forms.TextBox textBoxBScanNumber;
        private System.Windows.Forms.CheckBox checkBoxMotionOnly;
        private System.Windows.Forms.CheckBox checkBoxAScanDisplay;
        private System.Windows.Forms.GroupBox groupBoxImageSetting;
        private System.Windows.Forms.ComboBox comboBoxGrayLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelGrayLevel;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Timer timerMainLoop;
        private System.Windows.Forms.TextBox textBoxScanSpeed;
        private System.Windows.Forms.Label labelScanSpeed;
        private System.Windows.Forms.GroupBox groupBoxScanInfo;
        private System.Windows.Forms.TextBox textBoxScanStatus;
        private System.Windows.Forms.TextBox textBoxBScanCount;
        private System.Windows.Forms.TextBox textBoxRecordNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelScanInfo;
        private System.Windows.Forms.Label labelScanStatus;
        private System.Windows.Forms.Label labelBScanCount;
        private System.Windows.Forms.Label labelRecordNumber;
        private System.Windows.Forms.Label labelRecordDone;
        private System.Windows.Forms.PictureBox pictureBoxRecordDone;
        private System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.GroupBox groupBoxGraphAScan;
        private System.Windows.Forms.TextBox textBoxPlotAMin;
        private System.Windows.Forms.TextBox textBoxPlotAMax;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelPlotAMin;
        private System.Windows.Forms.Label labelPlotAMax;
        private System.Windows.Forms.TabPage tabPageRecord;
        private System.Windows.Forms.TabPage tabPageTransducerVerification;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TextBox textBoxSaveFilePath;
        private System.Windows.Forms.TextBox textBoxSaveFileName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label labelSaveFileName;
        private System.Windows.Forms.Label labelSaveFolder;
        private System.Windows.Forms.Label labelSaveFilePath;
        private System.Windows.Forms.Button buttonSaveFolder;
        private System.Windows.Forms.TextBox textBoxSaveFolder;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label labelCentralFrequency;
        private System.Windows.Forms.TextBox textBoxCentralFrequency;
        private System.Windows.Forms.CheckBox checkBoxVerify;
        private System.Windows.Forms.CheckBox checkBoxSaveRawData;
        private System.Windows.Forms.CheckBox checkBoxSaveSimplifiedData;

    }
}