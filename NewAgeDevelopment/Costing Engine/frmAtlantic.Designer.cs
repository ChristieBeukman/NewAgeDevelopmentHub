namespace Costing_Engine
{
    partial class frmAtlantic
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
            this.cmbLengthMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupLength = new System.Windows.Forms.GroupBox();
            this.tabAtlanticCosting = new System.Windows.Forms.TabControl();
            this.tabPageSquareTwoFifty = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaterialID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFrame = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageATwo = new System.Windows.Forms.TabPage();
            this.tabPageSquareFourFifty = new System.Windows.Forms.TabPage();
            this.tabPageThreeFifty = new System.Windows.Forms.TabPage();
            this.tabPageFourFifty = new System.Windows.Forms.TabPage();
            this.tabPagePane = new System.Windows.Forms.TabPage();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblATwoFrameLength = new UserControls.MaskedEditableLabelControl();
            this.maskedEditableLabelControl2 = new UserControls.MaskedEditableLabelControl();
            this.lblATwoFrameWidth = new UserControls.MaskedEditableLabelControl();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.maskedEditableLabelControl4 = new UserControls.MaskedEditableLabelControl();
            this.maskedEditableLabelControl5 = new UserControls.MaskedEditableLabelControl();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.maskedEditableLabelControl6 = new UserControls.MaskedEditableLabelControl();
            this.maskedEditableLabelControl7 = new UserControls.MaskedEditableLabelControl();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.maskedEditableLabelControl8 = new UserControls.MaskedEditableLabelControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblFrameLength = new UserControls.MaskedEditableLabelControl();
            this.lblFrameWidth = new UserControls.MaskedEditableLabelControl();
            this.lblNoFrames = new UserControls.MaskedEditableLabelControl();
            this.lblTotalUsedFrameCost = new UserControls.MaskedEditableLabelControl();
            this.lblFrameArea = new UserControls.MaskedEditableLabelControl();
            this.lblTotalFrameArea = new UserControls.MaskedEditableLabelControl();
            this.lblTotalCanvasArea = new UserControls.MaskedEditableLabelControl();
            this.lblCanvasOveralap = new UserControls.MaskedEditableLabelControl();
            this.groupLength.SuspendLayout();
            this.tabAtlanticCosting.SuspendLayout();
            this.tabPageSquareTwoFifty.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageATwo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLengthMaterial
            // 
            this.cmbLengthMaterial.FormattingEnabled = true;
            this.cmbLengthMaterial.Location = new System.Drawing.Point(76, 37);
            this.cmbLengthMaterial.Name = "cmbLengthMaterial";
            this.cmbLengthMaterial.Size = new System.Drawing.Size(119, 21);
            this.cmbLengthMaterial.TabIndex = 0;
            this.cmbLengthMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbLengthMaterial_SelectedIndexChanged);
            this.cmbLengthMaterial.SelectionChangeCommitted += new System.EventHandler(this.cmbLengthMaterial_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Frame";
            // 
            // groupLength
            // 
            this.groupLength.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupLength.Controls.Add(this.label1);
            this.groupLength.Controls.Add(this.cmbLengthMaterial);
            this.groupLength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupLength.Location = new System.Drawing.Point(7, 5);
            this.groupLength.Name = "groupLength";
            this.groupLength.Size = new System.Drawing.Size(204, 94);
            this.groupLength.TabIndex = 3;
            this.groupLength.TabStop = false;
            this.groupLength.Text = "Lenght";
            // 
            // tabAtlanticCosting
            // 
            this.tabAtlanticCosting.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabAtlanticCosting.Controls.Add(this.tabPageSquareTwoFifty);
            this.tabAtlanticCosting.Controls.Add(this.tabPageATwo);
            this.tabAtlanticCosting.Controls.Add(this.tabPageSquareFourFifty);
            this.tabAtlanticCosting.Controls.Add(this.tabPageThreeFifty);
            this.tabAtlanticCosting.Controls.Add(this.tabPageFourFifty);
            this.tabAtlanticCosting.Controls.Add(this.tabPagePane);
            this.tabAtlanticCosting.Controls.Add(this.tabPageSummary);
            this.tabAtlanticCosting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAtlanticCosting.Location = new System.Drawing.Point(0, 0);
            this.tabAtlanticCosting.Name = "tabAtlanticCosting";
            this.tabAtlanticCosting.SelectedIndex = 0;
            this.tabAtlanticCosting.Size = new System.Drawing.Size(584, 411);
            this.tabAtlanticCosting.TabIndex = 6;
            this.tabAtlanticCosting.Visible = false;
            // 
            // tabPageSquareTwoFifty
            // 
            this.tabPageSquareTwoFifty.BackColor = System.Drawing.SystemColors.GrayText;
            this.tabPageSquareTwoFifty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageSquareTwoFifty.Controls.Add(this.panel1);
            this.tabPageSquareTwoFifty.Controls.Add(this.groupBox2);
            this.tabPageSquareTwoFifty.Controls.Add(this.groupBox1);
            this.tabPageSquareTwoFifty.Location = new System.Drawing.Point(4, 25);
            this.tabPageSquareTwoFifty.Name = "tabPageSquareTwoFifty";
            this.tabPageSquareTwoFifty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSquareTwoFifty.Size = new System.Drawing.Size(576, 382);
            this.tabPageSquareTwoFifty.TabIndex = 0;
            this.tabPageSquareTwoFifty.Text = "Square 250 X 250";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(259, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 275);
            this.panel1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblFrameLength);
            this.groupBox2.Controls.Add(this.lblTotalFrameArea);
            this.groupBox2.Controls.Add(this.lblFrameWidth);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblTotalCanvasArea);
            this.groupBox2.Controls.Add(this.lblNoFrames);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblCanvasOveralap);
            this.groupBox2.Controls.Add(this.lblTotalUsedFrameCost);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblFrameArea);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(25, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 230);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Frame Length";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Total Frame Lenght";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total Canvas Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Frame Width";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Canvas Overlap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Number of Frames";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Frame Area";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Used Frame Cost";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaterialID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblFrame);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 45);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblMaterialID
            // 
            this.lblMaterialID.AutoSize = true;
            this.lblMaterialID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMaterialID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaterialID.Location = new System.Drawing.Point(459, 17);
            this.lblMaterialID.MinimumSize = new System.Drawing.Size(70, 20);
            this.lblMaterialID.Name = "lblMaterialID";
            this.lblMaterialID.Size = new System.Drawing.Size(70, 20);
            this.lblMaterialID.TabIndex = 8;
            this.lblMaterialID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Material ID:";
            // 
            // lblFrame
            // 
            this.lblFrame.AutoSize = true;
            this.lblFrame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFrame.Location = new System.Drawing.Point(60, 16);
            this.lblFrame.MinimumSize = new System.Drawing.Size(90, 20);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(90, 20);
            this.lblFrame.TabIndex = 6;
            this.lblFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Frame:";
            // 
            // tabPageATwo
            // 
            this.tabPageATwo.BackColor = System.Drawing.SystemColors.GrayText;
            this.tabPageATwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageATwo.Controls.Add(this.panel2);
            this.tabPageATwo.Controls.Add(this.groupBox3);
            this.tabPageATwo.Controls.Add(this.groupBox4);
            this.tabPageATwo.Location = new System.Drawing.Point(4, 25);
            this.tabPageATwo.Name = "tabPageATwo";
            this.tabPageATwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageATwo.Size = new System.Drawing.Size(576, 382);
            this.tabPageATwo.TabIndex = 1;
            this.tabPageATwo.Text = "A2";
            // 
            // tabPageSquareFourFifty
            // 
            this.tabPageSquareFourFifty.Location = new System.Drawing.Point(4, 25);
            this.tabPageSquareFourFifty.Name = "tabPageSquareFourFifty";
            this.tabPageSquareFourFifty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSquareFourFifty.Size = new System.Drawing.Size(576, 382);
            this.tabPageSquareFourFifty.TabIndex = 2;
            this.tabPageSquareFourFifty.Text = "Square 450 X 450";
            this.tabPageSquareFourFifty.UseVisualStyleBackColor = true;
            // 
            // tabPageThreeFifty
            // 
            this.tabPageThreeFifty.Location = new System.Drawing.Point(4, 25);
            this.tabPageThreeFifty.Name = "tabPageThreeFifty";
            this.tabPageThreeFifty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThreeFifty.Size = new System.Drawing.Size(576, 382);
            this.tabPageThreeFifty.TabIndex = 3;
            this.tabPageThreeFifty.Text = "450 X 350";
            this.tabPageThreeFifty.UseVisualStyleBackColor = true;
            // 
            // tabPageFourFifty
            // 
            this.tabPageFourFifty.Location = new System.Drawing.Point(4, 25);
            this.tabPageFourFifty.Name = "tabPageFourFifty";
            this.tabPageFourFifty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFourFifty.Size = new System.Drawing.Size(576, 382);
            this.tabPageFourFifty.TabIndex = 4;
            this.tabPageFourFifty.Text = "550 X 450";
            this.tabPageFourFifty.UseVisualStyleBackColor = true;
            // 
            // tabPagePane
            // 
            this.tabPagePane.Location = new System.Drawing.Point(4, 25);
            this.tabPagePane.Name = "tabPagePane";
            this.tabPagePane.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePane.Size = new System.Drawing.Size(576, 382);
            this.tabPagePane.TabIndex = 5;
            this.tabPagePane.Text = "Pane";
            this.tabPagePane.UseVisualStyleBackColor = true;
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Location = new System.Drawing.Point(4, 25);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSummary.Size = new System.Drawing.Size(576, 382);
            this.tabPageSummary.TabIndex = 6;
            this.tabPageSummary.Text = "Summary";
            this.tabPageSummary.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(270, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 275);
            this.panel2.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblATwoFrameLength);
            this.groupBox3.Controls.Add(this.maskedEditableLabelControl2);
            this.groupBox3.Controls.Add(this.lblATwoFrameWidth);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.maskedEditableLabelControl4);
            this.groupBox3.Controls.Add(this.maskedEditableLabelControl5);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.maskedEditableLabelControl6);
            this.groupBox3.Controls.Add(this.maskedEditableLabelControl7);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.maskedEditableLabelControl8);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(36, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 230);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Frame Length";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Total Frame Lenght";
            // 
            // lblATwoFrameLength
            // 
            this.lblATwoFrameLength.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblATwoFrameLength.Location = new System.Drawing.Point(127, 19);
            this.lblATwoFrameLength.MinimumSize = new System.Drawing.Size(70, 20);
            this.lblATwoFrameLength.Name = "lblATwoFrameLength";
            this.lblATwoFrameLength.Size = new System.Drawing.Size(70, 20);
            this.lblATwoFrameLength.TabIndex = 5;
            // 
            // maskedEditableLabelControl2
            // 
            this.maskedEditableLabelControl2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.maskedEditableLabelControl2.Location = new System.Drawing.Point(127, 201);
            this.maskedEditableLabelControl2.MinimumSize = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl2.Name = "maskedEditableLabelControl2";
            this.maskedEditableLabelControl2.Size = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl2.TabIndex = 22;
            // 
            // lblATwoFrameWidth
            // 
            this.lblATwoFrameWidth.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblATwoFrameWidth.Location = new System.Drawing.Point(127, 45);
            this.lblATwoFrameWidth.MinimumSize = new System.Drawing.Size(70, 20);
            this.lblATwoFrameWidth.Name = "lblATwoFrameWidth";
            this.lblATwoFrameWidth.Size = new System.Drawing.Size(70, 20);
            this.lblATwoFrameWidth.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Total Canvas Area";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Frame Width";
            // 
            // maskedEditableLabelControl4
            // 
            this.maskedEditableLabelControl4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.maskedEditableLabelControl4.Location = new System.Drawing.Point(127, 175);
            this.maskedEditableLabelControl4.MinimumSize = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl4.Name = "maskedEditableLabelControl4";
            this.maskedEditableLabelControl4.Size = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl4.TabIndex = 20;
            // 
            // maskedEditableLabelControl5
            // 
            this.maskedEditableLabelControl5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.maskedEditableLabelControl5.Location = new System.Drawing.Point(127, 71);
            this.maskedEditableLabelControl5.MinimumSize = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl5.Name = "maskedEditableLabelControl5";
            this.maskedEditableLabelControl5.Size = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl5.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Canvas Overlap";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Number of Frames";
            // 
            // maskedEditableLabelControl6
            // 
            this.maskedEditableLabelControl6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.maskedEditableLabelControl6.Location = new System.Drawing.Point(127, 149);
            this.maskedEditableLabelControl6.MinimumSize = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl6.Name = "maskedEditableLabelControl6";
            this.maskedEditableLabelControl6.Size = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl6.TabIndex = 18;
            // 
            // maskedEditableLabelControl7
            // 
            this.maskedEditableLabelControl7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.maskedEditableLabelControl7.Location = new System.Drawing.Point(127, 97);
            this.maskedEditableLabelControl7.MinimumSize = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl7.Name = "maskedEditableLabelControl7";
            this.maskedEditableLabelControl7.Size = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl7.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(64, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Frame Area";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Total Used Frame Cost";
            // 
            // maskedEditableLabelControl8
            // 
            this.maskedEditableLabelControl8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.maskedEditableLabelControl8.Location = new System.Drawing.Point(127, 123);
            this.maskedEditableLabelControl8.MinimumSize = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl8.Name = "maskedEditableLabelControl8";
            this.maskedEditableLabelControl8.Size = new System.Drawing.Size(70, 20);
            this.maskedEditableLabelControl8.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(18, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 45);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(459, 17);
            this.label20.MinimumSize = new System.Drawing.Size(70, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 20);
            this.label20.TabIndex = 8;
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(398, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "Material ID:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(60, 16);
            this.label22.MinimumSize = new System.Drawing.Size(90, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 20);
            this.label22.TabIndex = 6;
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Frame:";
            // 
            // lblFrameLength
            // 
            this.lblFrameLength.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFrameLength.Location = new System.Drawing.Point(127, 19);
            this.lblFrameLength.MinimumSize = new System.Drawing.Size(70, 20);
            this.lblFrameLength.Name = "lblFrameLength";
            this.lblFrameLength.Size = new System.Drawing.Size(70, 20);
            this.lblFrameLength.TabIndex = 5;
            // 
            // lblFrameWidth
            // 
            this.lblFrameWidth.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFrameWidth.Location = new System.Drawing.Point(127, 45);
            this.lblFrameWidth.MinimumSize = new System.Drawing.Size(70, 20);
            this.lblFrameWidth.Name = "lblFrameWidth";
            this.lblFrameWidth.Size = new System.Drawing.Size(70, 20);
            this.lblFrameWidth.TabIndex = 10;
            // 
            // lblNoFrames
            // 
            this.lblNoFrames.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNoFrames.Location = new System.Drawing.Point(127, 71);
            this.lblNoFrames.MinimumSize = new System.Drawing.Size(70, 20);
            this.lblNoFrames.Name = "lblNoFrames";
            this.lblNoFrames.Size = new System.Drawing.Size(70, 20);
            this.lblNoFrames.TabIndex = 12;
            // 
            // lblTotalUsedFrameCost
            // 
            this.lblTotalUsedFrameCost.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTotalUsedFrameCost.Location = new System.Drawing.Point(127, 97);
            this.lblTotalUsedFrameCost.MinimumSize = new System.Drawing.Size(70, 20);
            this.lblTotalUsedFrameCost.Name = "lblTotalUsedFrameCost";
            this.lblTotalUsedFrameCost.Size = new System.Drawing.Size(70, 20);
            this.lblTotalUsedFrameCost.TabIndex = 14;
            // 
            // lblFrameArea
            // 
            this.lblFrameArea.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFrameArea.Location = new System.Drawing.Point(127, 123);
            this.lblFrameArea.MinimumSize = new System.Drawing.Size(70, 20);
            this.lblFrameArea.Name = "lblFrameArea";
            this.lblFrameArea.Size = new System.Drawing.Size(70, 20);
            this.lblFrameArea.TabIndex = 16;
            // 
            // lblTotalFrameArea
            // 
            this.lblTotalFrameArea.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTotalFrameArea.Location = new System.Drawing.Point(127, 201);
            this.lblTotalFrameArea.MinimumSize = new System.Drawing.Size(70, 20);
            this.lblTotalFrameArea.Name = "lblTotalFrameArea";
            this.lblTotalFrameArea.Size = new System.Drawing.Size(70, 20);
            this.lblTotalFrameArea.TabIndex = 22;
            // 
            // lblTotalCanvasArea
            // 
            this.lblTotalCanvasArea.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTotalCanvasArea.Location = new System.Drawing.Point(127, 175);
            this.lblTotalCanvasArea.MinimumSize = new System.Drawing.Size(70, 20);
            this.lblTotalCanvasArea.Name = "lblTotalCanvasArea";
            this.lblTotalCanvasArea.Size = new System.Drawing.Size(70, 20);
            this.lblTotalCanvasArea.TabIndex = 20;
            // 
            // lblCanvasOveralap
            // 
            this.lblCanvasOveralap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCanvasOveralap.Location = new System.Drawing.Point(127, 149);
            this.lblCanvasOveralap.MinimumSize = new System.Drawing.Size(70, 20);
            this.lblCanvasOveralap.Name = "lblCanvasOveralap";
            this.lblCanvasOveralap.Size = new System.Drawing.Size(70, 20);
            this.lblCanvasOveralap.TabIndex = 18;
            // 
            // frmAtlantic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.tabAtlanticCosting);
            this.Controls.Add(this.groupLength);
            this.Name = "frmAtlantic";
            this.Text = "frmAtlantic";
            this.groupLength.ResumeLayout(false);
            this.groupLength.PerformLayout();
            this.tabAtlanticCosting.ResumeLayout(false);
            this.tabPageSquareTwoFifty.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageATwo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbLengthMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupLength;
        private System.Windows.Forms.TabControl tabAtlanticCosting;
        private System.Windows.Forms.TabPage tabPageSquareTwoFifty;
        private System.Windows.Forms.TabPage tabPageATwo;
        private System.Windows.Forms.TabPage tabPageSquareFourFifty;
        private System.Windows.Forms.TabPage tabPageThreeFifty;
        private System.Windows.Forms.TabPage tabPageFourFifty;
        private System.Windows.Forms.TabPage tabPagePane;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaterialID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFrame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private UserControls.MaskedEditableLabelControl lblATwoFrameLength;
        private UserControls.MaskedEditableLabelControl maskedEditableLabelControl2;
        private UserControls.MaskedEditableLabelControl lblATwoFrameWidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private UserControls.MaskedEditableLabelControl maskedEditableLabelControl4;
        private UserControls.MaskedEditableLabelControl maskedEditableLabelControl5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private UserControls.MaskedEditableLabelControl maskedEditableLabelControl6;
        private UserControls.MaskedEditableLabelControl maskedEditableLabelControl7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private UserControls.MaskedEditableLabelControl maskedEditableLabelControl8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private UserControls.MaskedEditableLabelControl lblFrameLength;
        private UserControls.MaskedEditableLabelControl lblTotalFrameArea;
        private UserControls.MaskedEditableLabelControl lblFrameWidth;
        private UserControls.MaskedEditableLabelControl lblTotalCanvasArea;
        private UserControls.MaskedEditableLabelControl lblNoFrames;
        private UserControls.MaskedEditableLabelControl lblCanvasOveralap;
        private UserControls.MaskedEditableLabelControl lblTotalUsedFrameCost;
        private UserControls.MaskedEditableLabelControl lblFrameArea;
    }
}