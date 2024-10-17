namespace AutoClicker
{
    partial class MainForm
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
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.grpClickType = new System.Windows.Forms.GroupBox();
            this.rdbClickDoubleRight = new System.Windows.Forms.RadioButton();
            this.rdbClickDoubleMiddle = new System.Windows.Forms.RadioButton();
            this.rdbClickDoubleLeft = new System.Windows.Forms.RadioButton();
            this.rdbClickSingleRight = new System.Windows.Forms.RadioButton();
            this.rdbClickSingleMiddle = new System.Windows.Forms.RadioButton();
            this.rdbClickSingleLeft = new System.Windows.Forms.RadioButton();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHotkeyRemove = new System.Windows.Forms.Button();
            this.txtHotkey = new System.Windows.Forms.TextBox();
            this.grpCount = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.rdbCount = new System.Windows.Forms.RadioButton();
            this.rdbUntilStopped = new System.Windows.Forms.RadioButton();
            this.grpDelay = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numDelayFixed = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numDelayRangeMax = new System.Windows.Forms.NumericUpDown();
            this.numDelayRangeMin = new System.Windows.Forms.NumericUpDown();
            this.rdbDelayRange = new System.Windows.Forms.RadioButton();
            this.rdbDelayFixed = new System.Windows.Forms.RadioButton();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numRandomHeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numRandomWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numRandomY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numRandomX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numFixedY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numFixedX = new System.Windows.Forms.NumericUpDown();
            this.rdbLocationRandomArea = new System.Windows.Forms.RadioButton();
            this.rdbLocationFixed = new System.Windows.Forms.RadioButton();
            this.rdbLocationRandom = new System.Windows.Forms.RadioButton();
            this.rdbLocationMouse = new System.Windows.Forms.RadioButton();
            this.btnToggle = new System.Windows.Forms.Button();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownGameBoxGap = new System.Windows.Forms.NumericUpDown();
            this.groupBoxOpenGameReward = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownWheelRoll = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownTaskUnitCount = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownRollDelayMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRollDelayMax = new System.Windows.Forms.NumericUpDown();
            this.grpMain.SuspendLayout();
            this.grpClickType.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.grpCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.grpDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayFixed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMin)).BeginInit();
            this.grpLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedX)).BeginInit();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGameBoxGap)).BeginInit();
            this.groupBoxOpenGameReward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWheelRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaskUnitCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRollDelayMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRollDelayMax)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.grpClickType);
            this.grpMain.Controls.Add(this.grpControls);
            this.grpMain.Controls.Add(this.grpCount);
            this.grpMain.Controls.Add(this.grpDelay);
            this.grpMain.Controls.Add(this.grpLocation);
            this.grpMain.Location = new System.Drawing.Point(16, 15);
            this.grpMain.Margin = new System.Windows.Forms.Padding(4);
            this.grpMain.Name = "grpMain";
            this.grpMain.Padding = new System.Windows.Forms.Padding(4);
            this.grpMain.Size = new System.Drawing.Size(699, 359);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Click details";
            // 
            // grpClickType
            // 
            this.grpClickType.Controls.Add(this.rdbClickDoubleRight);
            this.grpClickType.Controls.Add(this.rdbClickDoubleMiddle);
            this.grpClickType.Controls.Add(this.rdbClickDoubleLeft);
            this.grpClickType.Controls.Add(this.rdbClickSingleRight);
            this.grpClickType.Controls.Add(this.rdbClickSingleMiddle);
            this.grpClickType.Controls.Add(this.rdbClickSingleLeft);
            this.grpClickType.Location = new System.Drawing.Point(343, 121);
            this.grpClickType.Margin = new System.Windows.Forms.Padding(4);
            this.grpClickType.Name = "grpClickType";
            this.grpClickType.Padding = new System.Windows.Forms.Padding(4);
            this.grpClickType.Size = new System.Drawing.Size(335, 129);
            this.grpClickType.TabIndex = 2;
            this.grpClickType.TabStop = false;
            this.grpClickType.Text = "Click type";
            // 
            // rdbClickDoubleRight
            // 
            this.rdbClickDoubleRight.AutoSize = true;
            this.rdbClickDoubleRight.Location = new System.Drawing.Point(133, 78);
            this.rdbClickDoubleRight.Margin = new System.Windows.Forms.Padding(4);
            this.rdbClickDoubleRight.Name = "rdbClickDoubleRight";
            this.rdbClickDoubleRight.Size = new System.Drawing.Size(124, 19);
            this.rdbClickDoubleRight.TabIndex = 5;
            this.rdbClickDoubleRight.Text = "Right Double";
            this.rdbClickDoubleRight.UseVisualStyleBackColor = true;
            this.rdbClickDoubleRight.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickDoubleMiddle
            // 
            this.rdbClickDoubleMiddle.AutoSize = true;
            this.rdbClickDoubleMiddle.Location = new System.Drawing.Point(133, 50);
            this.rdbClickDoubleMiddle.Margin = new System.Windows.Forms.Padding(4);
            this.rdbClickDoubleMiddle.Name = "rdbClickDoubleMiddle";
            this.rdbClickDoubleMiddle.Size = new System.Drawing.Size(132, 19);
            this.rdbClickDoubleMiddle.TabIndex = 4;
            this.rdbClickDoubleMiddle.Text = "Middle Double";
            this.rdbClickDoubleMiddle.UseVisualStyleBackColor = true;
            this.rdbClickDoubleMiddle.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickDoubleLeft
            // 
            this.rdbClickDoubleLeft.AutoSize = true;
            this.rdbClickDoubleLeft.Location = new System.Drawing.Point(133, 22);
            this.rdbClickDoubleLeft.Margin = new System.Windows.Forms.Padding(4);
            this.rdbClickDoubleLeft.Name = "rdbClickDoubleLeft";
            this.rdbClickDoubleLeft.Size = new System.Drawing.Size(116, 19);
            this.rdbClickDoubleLeft.TabIndex = 3;
            this.rdbClickDoubleLeft.Text = "Left Double";
            this.rdbClickDoubleLeft.UseVisualStyleBackColor = true;
            this.rdbClickDoubleLeft.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickSingleRight
            // 
            this.rdbClickSingleRight.AutoSize = true;
            this.rdbClickSingleRight.Location = new System.Drawing.Point(8, 78);
            this.rdbClickSingleRight.Margin = new System.Windows.Forms.Padding(4);
            this.rdbClickSingleRight.Name = "rdbClickSingleRight";
            this.rdbClickSingleRight.Size = new System.Drawing.Size(68, 19);
            this.rdbClickSingleRight.TabIndex = 2;
            this.rdbClickSingleRight.Text = "Right";
            this.rdbClickSingleRight.UseVisualStyleBackColor = true;
            this.rdbClickSingleRight.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickSingleMiddle
            // 
            this.rdbClickSingleMiddle.AutoSize = true;
            this.rdbClickSingleMiddle.Location = new System.Drawing.Point(8, 50);
            this.rdbClickSingleMiddle.Margin = new System.Windows.Forms.Padding(4);
            this.rdbClickSingleMiddle.Name = "rdbClickSingleMiddle";
            this.rdbClickSingleMiddle.Size = new System.Drawing.Size(76, 19);
            this.rdbClickSingleMiddle.TabIndex = 1;
            this.rdbClickSingleMiddle.Text = "Middle";
            this.rdbClickSingleMiddle.UseVisualStyleBackColor = true;
            this.rdbClickSingleMiddle.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // rdbClickSingleLeft
            // 
            this.rdbClickSingleLeft.AutoSize = true;
            this.rdbClickSingleLeft.Checked = true;
            this.rdbClickSingleLeft.Location = new System.Drawing.Point(8, 22);
            this.rdbClickSingleLeft.Margin = new System.Windows.Forms.Padding(4);
            this.rdbClickSingleLeft.Name = "rdbClickSingleLeft";
            this.rdbClickSingleLeft.Size = new System.Drawing.Size(60, 19);
            this.rdbClickSingleLeft.TabIndex = 0;
            this.rdbClickSingleLeft.TabStop = true;
            this.rdbClickSingleLeft.Text = "Left";
            this.rdbClickSingleLeft.UseVisualStyleBackColor = true;
            this.rdbClickSingleLeft.CheckedChanged += new System.EventHandler(this.ClickTypeHandler);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.label11);
            this.grpControls.Controls.Add(this.btnHotkeyRemove);
            this.grpControls.Controls.Add(this.txtHotkey);
            this.grpControls.Location = new System.Drawing.Point(343, 22);
            this.grpControls.Margin = new System.Windows.Forms.Padding(4);
            this.grpControls.Name = "grpControls";
            this.grpControls.Padding = new System.Windows.Forms.Padding(4);
            this.grpControls.Size = new System.Drawing.Size(335, 91);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Hotkey";
            // 
            // btnHotkeyRemove
            // 
            this.btnHotkeyRemove.Location = new System.Drawing.Point(145, 17);
            this.btnHotkeyRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnHotkeyRemove.Name = "btnHotkeyRemove";
            this.btnHotkeyRemove.Size = new System.Drawing.Size(120, 29);
            this.btnHotkeyRemove.TabIndex = 2;
            this.btnHotkeyRemove.Text = "Clear Hotkey";
            this.btnHotkeyRemove.UseVisualStyleBackColor = true;
            this.btnHotkeyRemove.Click += new System.EventHandler(this.btnHotkeyRemove_Click);
            // 
            // txtHotkey
            // 
            this.txtHotkey.Location = new System.Drawing.Point(11, 52);
            this.txtHotkey.Margin = new System.Windows.Forms.Padding(4);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.Size = new System.Drawing.Size(254, 25);
            this.txtHotkey.TabIndex = 0;
            this.txtHotkey.Text = "None";
            this.txtHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHotkey_KeyDown);
            // 
            // grpCount
            // 
            this.grpCount.Controls.Add(this.label1);
            this.grpCount.Controls.Add(this.numCount);
            this.grpCount.Controls.Add(this.rdbCount);
            this.grpCount.Controls.Add(this.rdbUntilStopped);
            this.grpCount.Location = new System.Drawing.Point(8, 258);
            this.grpCount.Margin = new System.Windows.Forms.Padding(4);
            this.grpCount.Name = "grpCount";
            this.grpCount.Padding = new System.Windows.Forms.Padding(4);
            this.grpCount.Size = new System.Drawing.Size(308, 86);
            this.grpCount.TabIndex = 1;
            this.grpCount.TabStop = false;
            this.grpCount.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "clicks";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(139, 51);
            this.numCount.Margin = new System.Windows.Forms.Padding(4);
            this.numCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(80, 25);
            this.numCount.TabIndex = 2;
            this.numCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCount.ValueChanged += new System.EventHandler(this.CountHandler);
            // 
            // rdbCount
            // 
            this.rdbCount.AutoSize = true;
            this.rdbCount.Checked = true;
            this.rdbCount.Location = new System.Drawing.Point(8, 51);
            this.rdbCount.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCount.Name = "rdbCount";
            this.rdbCount.Size = new System.Drawing.Size(124, 19);
            this.rdbCount.TabIndex = 1;
            this.rdbCount.TabStop = true;
            this.rdbCount.Text = "Fixed number";
            this.rdbCount.UseVisualStyleBackColor = true;
            this.rdbCount.CheckedChanged += new System.EventHandler(this.CountHandler);
            // 
            // rdbUntilStopped
            // 
            this.rdbUntilStopped.AutoSize = true;
            this.rdbUntilStopped.Location = new System.Drawing.Point(8, 24);
            this.rdbUntilStopped.Margin = new System.Windows.Forms.Padding(4);
            this.rdbUntilStopped.Name = "rdbUntilStopped";
            this.rdbUntilStopped.Size = new System.Drawing.Size(132, 19);
            this.rdbUntilStopped.TabIndex = 0;
            this.rdbUntilStopped.Text = "Until stopped";
            this.rdbUntilStopped.UseVisualStyleBackColor = true;
            this.rdbUntilStopped.CheckedChanged += new System.EventHandler(this.CountHandler);
            // 
            // grpDelay
            // 
            this.grpDelay.Controls.Add(this.label10);
            this.grpDelay.Controls.Add(this.label9);
            this.grpDelay.Controls.Add(this.numDelayFixed);
            this.grpDelay.Controls.Add(this.label8);
            this.grpDelay.Controls.Add(this.numDelayRangeMax);
            this.grpDelay.Controls.Add(this.numDelayRangeMin);
            this.grpDelay.Controls.Add(this.rdbDelayRange);
            this.grpDelay.Controls.Add(this.rdbDelayFixed);
            this.grpDelay.Location = new System.Drawing.Point(343, 258);
            this.grpDelay.Margin = new System.Windows.Forms.Padding(4);
            this.grpDelay.Name = "grpDelay";
            this.grpDelay.Padding = new System.Windows.Forms.Padding(4);
            this.grpDelay.Size = new System.Drawing.Size(335, 86);
            this.grpDelay.TabIndex = 1;
            this.grpDelay.TabStop = false;
            this.grpDelay.Text = "Delay";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "ms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "ms";
            // 
            // numDelayFixed
            // 
            this.numDelayFixed.Location = new System.Drawing.Point(89, 18);
            this.numDelayFixed.Margin = new System.Windows.Forms.Padding(4);
            this.numDelayFixed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDelayFixed.Name = "numDelayFixed";
            this.numDelayFixed.Size = new System.Drawing.Size(80, 25);
            this.numDelayFixed.TabIndex = 11;
            this.numDelayFixed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDelayFixed.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "-";
            // 
            // numDelayRangeMax
            // 
            this.numDelayRangeMax.Location = new System.Drawing.Point(205, 52);
            this.numDelayRangeMax.Margin = new System.Windows.Forms.Padding(4);
            this.numDelayRangeMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDelayRangeMax.Name = "numDelayRangeMax";
            this.numDelayRangeMax.Size = new System.Drawing.Size(80, 25);
            this.numDelayRangeMax.TabIndex = 9;
            this.numDelayRangeMax.Value = new decimal(new int[] {
            620,
            0,
            0,
            0});
            this.numDelayRangeMax.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // numDelayRangeMin
            // 
            this.numDelayRangeMin.Location = new System.Drawing.Point(89, 52);
            this.numDelayRangeMin.Margin = new System.Windows.Forms.Padding(4);
            this.numDelayRangeMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDelayRangeMin.Name = "numDelayRangeMin";
            this.numDelayRangeMin.Size = new System.Drawing.Size(80, 25);
            this.numDelayRangeMin.TabIndex = 8;
            this.numDelayRangeMin.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.numDelayRangeMin.ValueChanged += new System.EventHandler(this.DelayHandler);
            // 
            // rdbDelayRange
            // 
            this.rdbDelayRange.AutoSize = true;
            this.rdbDelayRange.Checked = true;
            this.rdbDelayRange.Location = new System.Drawing.Point(8, 54);
            this.rdbDelayRange.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDelayRange.Name = "rdbDelayRange";
            this.rdbDelayRange.Size = new System.Drawing.Size(68, 19);
            this.rdbDelayRange.TabIndex = 1;
            this.rdbDelayRange.TabStop = true;
            this.rdbDelayRange.Text = "Range";
            this.rdbDelayRange.UseVisualStyleBackColor = true;
            this.rdbDelayRange.CheckedChanged += new System.EventHandler(this.DelayHandler);
            // 
            // rdbDelayFixed
            // 
            this.rdbDelayFixed.AutoSize = true;
            this.rdbDelayFixed.Location = new System.Drawing.Point(8, 22);
            this.rdbDelayFixed.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDelayFixed.Name = "rdbDelayFixed";
            this.rdbDelayFixed.Size = new System.Drawing.Size(68, 19);
            this.rdbDelayFixed.TabIndex = 0;
            this.rdbDelayFixed.Text = "Fixed";
            this.rdbDelayFixed.UseVisualStyleBackColor = true;
            this.rdbDelayFixed.CheckedChanged += new System.EventHandler(this.DelayHandler);
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.btnSelect);
            this.grpLocation.Controls.Add(this.label6);
            this.grpLocation.Controls.Add(this.numRandomHeight);
            this.grpLocation.Controls.Add(this.label7);
            this.grpLocation.Controls.Add(this.numRandomWidth);
            this.grpLocation.Controls.Add(this.label4);
            this.grpLocation.Controls.Add(this.numRandomY);
            this.grpLocation.Controls.Add(this.label5);
            this.grpLocation.Controls.Add(this.numRandomX);
            this.grpLocation.Controls.Add(this.label3);
            this.grpLocation.Controls.Add(this.numFixedY);
            this.grpLocation.Controls.Add(this.label2);
            this.grpLocation.Controls.Add(this.numFixedX);
            this.grpLocation.Controls.Add(this.rdbLocationRandomArea);
            this.grpLocation.Controls.Add(this.rdbLocationFixed);
            this.grpLocation.Controls.Add(this.rdbLocationRandom);
            this.grpLocation.Controls.Add(this.rdbLocationMouse);
            this.grpLocation.Location = new System.Drawing.Point(8, 22);
            this.grpLocation.Margin = new System.Windows.Forms.Padding(4);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Padding = new System.Windows.Forms.Padding(4);
            this.grpLocation.Size = new System.Drawing.Size(308, 228);
            this.grpLocation.TabIndex = 0;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(136, 130);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 29);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "Select...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Height";
            // 
            // numRandomHeight
            // 
            this.numRandomHeight.Location = new System.Drawing.Point(204, 195);
            this.numRandomHeight.Margin = new System.Windows.Forms.Padding(4);
            this.numRandomHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomHeight.Name = "numRandomHeight";
            this.numRandomHeight.Size = new System.Drawing.Size(80, 25);
            this.numRandomHeight.TabIndex = 14;
            this.numRandomHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRandomHeight.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Width";
            // 
            // numRandomWidth
            // 
            this.numRandomWidth.Location = new System.Drawing.Point(60, 195);
            this.numRandomWidth.Margin = new System.Windows.Forms.Padding(4);
            this.numRandomWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomWidth.Name = "numRandomWidth";
            this.numRandomWidth.Size = new System.Drawing.Size(80, 25);
            this.numRandomWidth.TabIndex = 12;
            this.numRandomWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numRandomWidth.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y";
            // 
            // numRandomY
            // 
            this.numRandomY.Location = new System.Drawing.Point(204, 164);
            this.numRandomY.Margin = new System.Windows.Forms.Padding(4);
            this.numRandomY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomY.Name = "numRandomY";
            this.numRandomY.Size = new System.Drawing.Size(80, 25);
            this.numRandomY.TabIndex = 10;
            this.numRandomY.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // numRandomX
            // 
            this.numRandomX.Location = new System.Drawing.Point(60, 164);
            this.numRandomX.Margin = new System.Windows.Forms.Padding(4);
            this.numRandomX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRandomX.Name = "numRandomX";
            this.numRandomX.Size = new System.Drawing.Size(80, 25);
            this.numRandomX.TabIndex = 8;
            this.numRandomX.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // numFixedY
            // 
            this.numFixedY.Location = new System.Drawing.Point(204, 85);
            this.numFixedY.Margin = new System.Windows.Forms.Padding(4);
            this.numFixedY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFixedY.Name = "numFixedY";
            this.numFixedY.Size = new System.Drawing.Size(80, 25);
            this.numFixedY.TabIndex = 6;
            this.numFixedY.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            // 
            // numFixedX
            // 
            this.numFixedX.Location = new System.Drawing.Point(60, 85);
            this.numFixedX.Margin = new System.Windows.Forms.Padding(4);
            this.numFixedX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFixedX.Name = "numFixedX";
            this.numFixedX.Size = new System.Drawing.Size(80, 25);
            this.numFixedX.TabIndex = 4;
            this.numFixedX.ValueChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationRandomArea
            // 
            this.rdbLocationRandomArea.AutoSize = true;
            this.rdbLocationRandomArea.Checked = true;
            this.rdbLocationRandomArea.Location = new System.Drawing.Point(8, 136);
            this.rdbLocationRandomArea.Margin = new System.Windows.Forms.Padding(4);
            this.rdbLocationRandomArea.Name = "rdbLocationRandomArea";
            this.rdbLocationRandomArea.Size = new System.Drawing.Size(116, 19);
            this.rdbLocationRandomArea.TabIndex = 3;
            this.rdbLocationRandomArea.TabStop = true;
            this.rdbLocationRandomArea.Text = "Random area";
            this.rdbLocationRandomArea.UseVisualStyleBackColor = true;
            this.rdbLocationRandomArea.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationFixed
            // 
            this.rdbLocationFixed.AutoSize = true;
            this.rdbLocationFixed.Location = new System.Drawing.Point(8, 58);
            this.rdbLocationFixed.Margin = new System.Windows.Forms.Padding(4);
            this.rdbLocationFixed.Name = "rdbLocationFixed";
            this.rdbLocationFixed.Size = new System.Drawing.Size(140, 19);
            this.rdbLocationFixed.TabIndex = 2;
            this.rdbLocationFixed.Text = "Fixed location";
            this.rdbLocationFixed.UseVisualStyleBackColor = true;
            this.rdbLocationFixed.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationRandom
            // 
            this.rdbLocationRandom.AutoSize = true;
            this.rdbLocationRandom.Location = new System.Drawing.Point(180, 22);
            this.rdbLocationRandom.Margin = new System.Windows.Forms.Padding(4);
            this.rdbLocationRandom.Name = "rdbLocationRandom";
            this.rdbLocationRandom.Size = new System.Drawing.Size(76, 19);
            this.rdbLocationRandom.TabIndex = 1;
            this.rdbLocationRandom.Text = "Random";
            this.rdbLocationRandom.UseVisualStyleBackColor = true;
            this.rdbLocationRandom.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // rdbLocationMouse
            // 
            this.rdbLocationMouse.AutoSize = true;
            this.rdbLocationMouse.Location = new System.Drawing.Point(8, 22);
            this.rdbLocationMouse.Margin = new System.Windows.Forms.Padding(4);
            this.rdbLocationMouse.Name = "rdbLocationMouse";
            this.rdbLocationMouse.Size = new System.Drawing.Size(140, 19);
            this.rdbLocationMouse.TabIndex = 0;
            this.rdbLocationMouse.Text = "Mouse location";
            this.rdbLocationMouse.UseVisualStyleBackColor = true;
            this.rdbLocationMouse.CheckedChanged += new System.EventHandler(this.LocationHandler);
            // 
            // btnToggle
            // 
            this.btnToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggle.Location = new System.Drawing.Point(594, 553);
            this.btnToggle.Margin = new System.Windows.Forms.Padding(4);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(100, 29);
            this.btnToggle.TabIndex = 3;
            this.btnToggle.Text = "Start";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 597);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStripMain.Size = new System.Drawing.Size(729, 25);
            this.statusStripMain.TabIndex = 1;
            // 
            // tslStatus
            // 
            this.tslStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tslStatus.ForeColor = System.Drawing.Color.Tomato;
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(41, 19);
            this.tslStatus.Text = "msg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Box vertical gap";
            // 
            // numericUpDownGameBoxGap
            // 
            this.numericUpDownGameBoxGap.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownGameBoxGap.Location = new System.Drawing.Point(188, 25);
            this.numericUpDownGameBoxGap.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownGameBoxGap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGameBoxGap.Name = "numericUpDownGameBoxGap";
            this.numericUpDownGameBoxGap.Size = new System.Drawing.Size(80, 25);
            this.numericUpDownGameBoxGap.TabIndex = 5;
            this.numericUpDownGameBoxGap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxOpenGameReward
            // 
            this.groupBoxOpenGameReward.Controls.Add(this.numericUpDownRollDelayMax);
            this.groupBoxOpenGameReward.Controls.Add(this.numericUpDownRollDelayMin);
            this.groupBoxOpenGameReward.Controls.Add(this.label15);
            this.groupBoxOpenGameReward.Controls.Add(this.numericUpDownTaskUnitCount);
            this.groupBoxOpenGameReward.Controls.Add(this.label14);
            this.groupBoxOpenGameReward.Controls.Add(this.numericUpDownWheelRoll);
            this.groupBoxOpenGameReward.Controls.Add(this.label13);
            this.groupBoxOpenGameReward.Controls.Add(this.numericUpDownGameBoxGap);
            this.groupBoxOpenGameReward.Controls.Add(this.label12);
            this.groupBoxOpenGameReward.Location = new System.Drawing.Point(16, 386);
            this.groupBoxOpenGameReward.Name = "groupBoxOpenGameReward";
            this.groupBoxOpenGameReward.Size = new System.Drawing.Size(699, 143);
            this.groupBoxOpenGameReward.TabIndex = 6;
            this.groupBoxOpenGameReward.TabStop = false;
            this.groupBoxOpenGameReward.Text = "Open reward box";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Click unit count";
            // 
            // numericUpDownWheelRoll
            // 
            this.numericUpDownWheelRoll.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownWheelRoll.Location = new System.Drawing.Point(188, 65);
            this.numericUpDownWheelRoll.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWheelRoll.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownWheelRoll.Name = "numericUpDownWheelRoll";
            this.numericUpDownWheelRoll.Size = new System.Drawing.Size(80, 25);
            this.numericUpDownWheelRoll.TabIndex = 7;
            this.numericUpDownWheelRoll.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Wheel roll value";
            // 
            // numericUpDownTaskUnitCount
            // 
            this.numericUpDownTaskUnitCount.Location = new System.Drawing.Point(188, 103);
            this.numericUpDownTaskUnitCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTaskUnitCount.Name = "numericUpDownTaskUnitCount";
            this.numericUpDownTaskUnitCount.Size = new System.Drawing.Size(80, 25);
            this.numericUpDownTaskUnitCount.TabIndex = 9;
            this.numericUpDownTaskUnitCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(340, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "Roll delay ms";
            // 
            // numericUpDownRollDelayMin
            // 
            this.numericUpDownRollDelayMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRollDelayMin.Location = new System.Drawing.Point(476, 24);
            this.numericUpDownRollDelayMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRollDelayMin.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRollDelayMin.Name = "numericUpDownRollDelayMin";
            this.numericUpDownRollDelayMin.Size = new System.Drawing.Size(80, 25);
            this.numericUpDownRollDelayMin.TabIndex = 11;
            this.numericUpDownRollDelayMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownRollDelayMax
            // 
            this.numericUpDownRollDelayMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRollDelayMax.Location = new System.Drawing.Point(578, 24);
            this.numericUpDownRollDelayMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRollDelayMax.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownRollDelayMax.Name = "numericUpDownRollDelayMax";
            this.numericUpDownRollDelayMax.Size = new System.Drawing.Size(80, 25);
            this.numericUpDownRollDelayMax.TabIndex = 12;
            this.numericUpDownRollDelayMax.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 622);
            this.Controls.Add(this.groupBoxOpenGameReward);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Auto Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.grpMain.ResumeLayout(false);
            this.grpClickType.ResumeLayout(false);
            this.grpClickType.PerformLayout();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.grpCount.ResumeLayout(false);
            this.grpCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.grpDelay.ResumeLayout(false);
            this.grpDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayFixed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRangeMin)).EndInit();
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRandomX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedX)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGameBoxGap)).EndInit();
            this.groupBoxOpenGameReward.ResumeLayout(false);
            this.groupBoxOpenGameReward.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWheelRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaskUnitCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRollDelayMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRollDelayMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.GroupBox grpClickType;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnHotkeyRemove;
        private System.Windows.Forms.TextBox txtHotkey;
        private System.Windows.Forms.GroupBox grpCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.RadioButton rdbCount;
        private System.Windows.Forms.RadioButton rdbUntilStopped;
        private System.Windows.Forms.GroupBox grpDelay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDelayFixed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numDelayRangeMax;
        private System.Windows.Forms.NumericUpDown numDelayRangeMin;
        private System.Windows.Forms.RadioButton rdbDelayRange;
        private System.Windows.Forms.RadioButton rdbDelayFixed;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numRandomHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numRandomWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numRandomY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numRandomX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numFixedY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFixedX;
        private System.Windows.Forms.RadioButton rdbLocationRandomArea;
        private System.Windows.Forms.RadioButton rdbLocationFixed;
        private System.Windows.Forms.RadioButton rdbLocationRandom;
        private System.Windows.Forms.RadioButton rdbLocationMouse;
        private System.Windows.Forms.RadioButton rdbClickDoubleRight;
        private System.Windows.Forms.RadioButton rdbClickDoubleMiddle;
        private System.Windows.Forms.RadioButton rdbClickDoubleLeft;
        private System.Windows.Forms.RadioButton rdbClickSingleRight;
        private System.Windows.Forms.RadioButton rdbClickSingleMiddle;
        private System.Windows.Forms.RadioButton rdbClickSingleLeft;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownGameBoxGap;
        private System.Windows.Forms.GroupBox groupBoxOpenGameReward;
        private System.Windows.Forms.NumericUpDown numericUpDownWheelRoll;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownTaskUnitCount;
        private System.Windows.Forms.NumericUpDown numericUpDownRollDelayMin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownRollDelayMax;
    }
}

