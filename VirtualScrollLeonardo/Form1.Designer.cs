namespace WindowsFormsApplication1
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxLeftMouse = new System.Windows.Forms.ComboBox();
            this.comboBoxRightmouse = new System.Windows.Forms.ComboBox();
            this.comboBoxMiddlemouse = new System.Windows.Forms.ComboBox();
            this.comboBoxCtrl = new System.Windows.Forms.ComboBox();
            this.comboBoxAlt = new System.Windows.Forms.ComboBox();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownDragIntensity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownDragImpulse = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSwipe = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CtrlDesactiveLeftMouseButton = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.BypassContextMenu = new System.Windows.Forms.CheckBox();
            this.MsToForceBypas = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ByassContextMenuDeadZone = new System.Windows.Forms.NumericUpDown();
            this.VanishingPointX = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.VanishingPointY = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownStartPointX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartPointY = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownEndPointX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEndPointY = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDragIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDragImpulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSwipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MsToForceBypas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ByassContextMenuDeadZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanishingPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanishingPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPointY)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLeftMouse
            // 
            this.comboBoxLeftMouse.DisplayMember = "2";
            this.comboBoxLeftMouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeftMouse.Items.AddRange(new object[] {
            "None",
            "Drag",
            "Swipe"});
            this.comboBoxLeftMouse.Location = new System.Drawing.Point(138, 91);
            this.comboBoxLeftMouse.Name = "comboBoxLeftMouse";
            this.comboBoxLeftMouse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLeftMouse.TabIndex = 10;
            this.comboBoxLeftMouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeftMouse_SelectedIndexChanged);
            // 
            // comboBoxRightmouse
            // 
            this.comboBoxRightmouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRightmouse.Items.AddRange(new object[] {
            "None",
            "Drag",
            "Swipe"});
            this.comboBoxRightmouse.Location = new System.Drawing.Point(138, 118);
            this.comboBoxRightmouse.Name = "comboBoxRightmouse";
            this.comboBoxRightmouse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRightmouse.TabIndex = 17;
            this.comboBoxRightmouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxRightmouse_SelectedIndexChanged);
            // 
            // comboBoxMiddlemouse
            // 
            this.comboBoxMiddlemouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMiddlemouse.Items.AddRange(new object[] {
            "None",
            "Drag",
            "Swipe"});
            this.comboBoxMiddlemouse.Location = new System.Drawing.Point(138, 145);
            this.comboBoxMiddlemouse.Name = "comboBoxMiddlemouse";
            this.comboBoxMiddlemouse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMiddlemouse.TabIndex = 18;
            this.comboBoxMiddlemouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxMiddlemouse_SelectedIndexChanged);
            // 
            // comboBoxCtrl
            // 
            this.comboBoxCtrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCtrl.Items.AddRange(new object[] {
            "None",
            "Drag",
            "Swipe"});
            this.comboBoxCtrl.Location = new System.Drawing.Point(138, 172);
            this.comboBoxCtrl.Name = "comboBoxCtrl";
            this.comboBoxCtrl.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCtrl.TabIndex = 19;
            this.comboBoxCtrl.SelectedIndexChanged += new System.EventHandler(this.comboBoxCtrl_SelectedIndexChanged);
            // 
            // comboBoxAlt
            // 
            this.comboBoxAlt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlt.Items.AddRange(new object[] {
            "None",
            "Drag",
            "Swipe"});
            this.comboBoxAlt.Location = new System.Drawing.Point(138, 199);
            this.comboBoxAlt.Name = "comboBoxAlt";
            this.comboBoxAlt.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlt.TabIndex = 20;
            this.comboBoxAlt.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlt_SelectedIndexChanged_1);
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShift.Items.AddRange(new object[] {
            "None",
            "Drag",
            "Swipe"});
            this.comboBoxShift.Location = new System.Drawing.Point(138, 226);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShift.TabIndex = 21;
            this.comboBoxShift.SelectedIndexChanged += new System.EventHandler(this.comboBoxShift_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDownDragIntensity
            // 
            this.numericUpDownDragIntensity.Location = new System.Drawing.Point(138, 12);
            this.numericUpDownDragIntensity.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownDragIntensity.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownDragIntensity.Name = "numericUpDownDragIntensity";
            this.numericUpDownDragIntensity.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownDragIntensity.TabIndex = 3;
            this.numericUpDownDragIntensity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDragIntensity.ValueChanged += new System.EventHandler(this.numericUpDownDragIntensity_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drag intensity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Swipe intensity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Drag impulse";
            // 
            // numericUpDownDragImpulse
            // 
            this.numericUpDownDragImpulse.Location = new System.Drawing.Point(138, 38);
            this.numericUpDownDragImpulse.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownDragImpulse.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownDragImpulse.Name = "numericUpDownDragImpulse";
            this.numericUpDownDragImpulse.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownDragImpulse.TabIndex = 7;
            this.numericUpDownDragImpulse.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDragImpulse.ValueChanged += new System.EventHandler(this.numericUpDownDragImpulse_ValueChanged);
            // 
            // numericUpDownSwipe
            // 
            this.numericUpDownSwipe.Location = new System.Drawing.Point(138, 64);
            this.numericUpDownSwipe.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownSwipe.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownSwipe.Name = "numericUpDownSwipe";
            this.numericUpDownSwipe.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownSwipe.TabIndex = 8;
            this.numericUpDownSwipe.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSwipe.ValueChanged += new System.EventHandler(this.numericUpDownSwipe_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Left mouse button";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Right mouse button";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Middle mouse button";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Keyboard Alt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Keyboard Control";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Keyboard Shift";
            // 
            // CtrlDesactiveLeftMouseButton
            // 
            this.CtrlDesactiveLeftMouseButton.AutoSize = true;
            this.CtrlDesactiveLeftMouseButton.Location = new System.Drawing.Point(23, 253);
            this.CtrlDesactiveLeftMouseButton.Name = "CtrlDesactiveLeftMouseButton";
            this.CtrlDesactiveLeftMouseButton.Size = new System.Drawing.Size(187, 17);
            this.CtrlDesactiveLeftMouseButton.TabIndex = 16;
            this.CtrlDesactiveLeftMouseButton.Text = "Ctrl desactivate Left mouse button";
            this.CtrlDesactiveLeftMouseButton.UseVisualStyleBackColor = true;
            this.CtrlDesactiveLeftMouseButton.UseWaitCursor = true;
            this.CtrlDesactiveLeftMouseButton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Super Fast Virtual Scroll 0.1";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // BypassContextMenu
            // 
            this.BypassContextMenu.AutoSize = true;
            this.BypassContextMenu.Checked = true;
            this.BypassContextMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BypassContextMenu.Location = new System.Drawing.Point(23, 276);
            this.BypassContextMenu.Name = "BypassContextMenu";
            this.BypassContextMenu.Size = new System.Drawing.Size(182, 17);
            this.BypassContextMenu.TabIndex = 22;
            this.BypassContextMenu.Text = "Bypass Right click Context Menu";
            this.BypassContextMenu.UseVisualStyleBackColor = true;
            this.BypassContextMenu.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // MsToForceBypas
            // 
            this.MsToForceBypas.Location = new System.Drawing.Point(159, 298);
            this.MsToForceBypas.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.MsToForceBypas.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.MsToForceBypas.Name = "MsToForceBypas";
            this.MsToForceBypas.Size = new System.Drawing.Size(51, 20);
            this.MsToForceBypas.TabIndex = 23;
            this.MsToForceBypas.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.MsToForceBypas.ValueChanged += new System.EventHandler(this.MsToForceBypas_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ms to force Bypass:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Bypass Dead Zone:";
            // 
            // ByassContextMenuDeadZone
            // 
            this.ByassContextMenuDeadZone.Location = new System.Drawing.Point(159, 324);
            this.ByassContextMenuDeadZone.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ByassContextMenuDeadZone.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.ByassContextMenuDeadZone.Name = "ByassContextMenuDeadZone";
            this.ByassContextMenuDeadZone.Size = new System.Drawing.Size(51, 20);
            this.ByassContextMenuDeadZone.TabIndex = 26;
            this.ByassContextMenuDeadZone.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ByassContextMenuDeadZone.ValueChanged += new System.EventHandler(this.ByassContextMenuDeadZone_ValueChanged);
            // 
            // VanishingPointX
            // 
            this.VanishingPointX.Location = new System.Drawing.Point(159, 350);
            this.VanishingPointX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.VanishingPointX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.VanishingPointX.Name = "VanishingPointX";
            this.VanishingPointX.Size = new System.Drawing.Size(51, 20);
            this.VanishingPointX.TabIndex = 27;
            this.VanishingPointX.ValueChanged += new System.EventHandler(this.VanishingPoint_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Vanishing Point:";
            // 
            // VanishingPointY
            // 
            this.VanishingPointY.Location = new System.Drawing.Point(216, 350);
            this.VanishingPointY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.VanishingPointY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.VanishingPointY.Name = "VanishingPointY";
            this.VanishingPointY.Size = new System.Drawing.Size(51, 20);
            this.VanishingPointY.TabIndex = 29;
            this.VanishingPointY.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.VanishingPointY.ValueChanged += new System.EventHandler(this.VanishingPointY_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 469);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Press Alt + Ctrl do Enable/Disable";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Included scope:";
            // 
            // numericUpDownStartPointX
            // 
            this.numericUpDownStartPointX.Location = new System.Drawing.Point(159, 397);
            this.numericUpDownStartPointX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownStartPointX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownStartPointX.Name = "numericUpDownStartPointX";
            this.numericUpDownStartPointX.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownStartPointX.TabIndex = 32;
            this.numericUpDownStartPointX.ValueChanged += new System.EventHandler(this.numericUpDownStartPointX_ValueChanged);
            // 
            // numericUpDownStartPointY
            // 
            this.numericUpDownStartPointY.Location = new System.Drawing.Point(216, 397);
            this.numericUpDownStartPointY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownStartPointY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownStartPointY.Name = "numericUpDownStartPointY";
            this.numericUpDownStartPointY.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownStartPointY.TabIndex = 33;
            this.numericUpDownStartPointY.ValueChanged += new System.EventHandler(this.numericUpDownStartPointY_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 399);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Start point:";
            // 
            // numericUpDownEndPointX
            // 
            this.numericUpDownEndPointX.Location = new System.Drawing.Point(159, 423);
            this.numericUpDownEndPointX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownEndPointX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownEndPointX.Name = "numericUpDownEndPointX";
            this.numericUpDownEndPointX.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownEndPointX.TabIndex = 35;
            this.numericUpDownEndPointX.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numericUpDownEndPointX.ValueChanged += new System.EventHandler(this.numericUpDownEndPointX_ValueChanged);
            // 
            // numericUpDownEndPointY
            // 
            this.numericUpDownEndPointY.Location = new System.Drawing.Point(216, 423);
            this.numericUpDownEndPointY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownEndPointY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownEndPointY.Name = "numericUpDownEndPointY";
            this.numericUpDownEndPointY.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownEndPointY.TabIndex = 36;
            this.numericUpDownEndPointY.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDownEndPointY.ValueChanged += new System.EventHandler(this.numericUpDownEndPointY_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(95, 425);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "End point:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 491);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numericUpDownEndPointY);
            this.Controls.Add(this.numericUpDownEndPointX);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numericUpDownStartPointY);
            this.Controls.Add(this.numericUpDownStartPointX);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.VanishingPointY);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.VanishingPointX);
            this.Controls.Add(this.ByassContextMenuDeadZone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MsToForceBypas);
            this.Controls.Add(this.BypassContextMenu);
            this.Controls.Add(this.comboBoxShift);
            this.Controls.Add(this.comboBoxAlt);
            this.Controls.Add(this.comboBoxCtrl);
            this.Controls.Add(this.comboBoxMiddlemouse);
            this.Controls.Add(this.comboBoxRightmouse);
            this.Controls.Add(this.CtrlDesactiveLeftMouseButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxLeftMouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSwipe);
            this.Controls.Add(this.numericUpDownDragImpulse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDragIntensity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDragIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDragImpulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSwipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MsToForceBypas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ByassContextMenuDeadZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanishingPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VanishingPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndPointY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDownDragIntensity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownDragImpulse;
        private System.Windows.Forms.NumericUpDown numericUpDownSwipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox CtrlDesactiveLeftMouseButton;
        protected System.Windows.Forms.ComboBox comboBoxLeftMouse;
        protected System.Windows.Forms.ComboBox comboBoxRightmouse;
        protected System.Windows.Forms.ComboBox comboBoxMiddlemouse;
        protected System.Windows.Forms.ComboBox comboBoxCtrl;
        protected System.Windows.Forms.ComboBox comboBoxAlt;
        protected System.Windows.Forms.ComboBox comboBoxShift;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox BypassContextMenu;
        private System.Windows.Forms.NumericUpDown MsToForceBypas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown ByassContextMenuDeadZone;
        private System.Windows.Forms.NumericUpDown VanishingPointX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown VanishingPointY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownStartPointX;
        private System.Windows.Forms.NumericUpDown numericUpDownStartPointY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownEndPointX;
        private System.Windows.Forms.NumericUpDown numericUpDownEndPointY;
        private System.Windows.Forms.Label label16;
    }
}

