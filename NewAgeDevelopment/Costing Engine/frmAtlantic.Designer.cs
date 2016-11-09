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
            this.costingSquareTwoFifty = new UserControls.GenericAtlanticCostingControl();
            this.tabPageATwo = new System.Windows.Forms.TabPage();
            this.costingSquareAtwo = new UserControls.GenericAtlanticCostingControl();
            this.tabPageSquareFourFifty = new System.Windows.Forms.TabPage();
            this.tabPageThreeFifty = new System.Windows.Forms.TabPage();
            this.tabPageFourFifty = new System.Windows.Forms.TabPage();
            this.tabPagePane = new System.Windows.Forms.TabPage();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.costingSquareFourFifty = new UserControls.GenericAtlanticCostingControl();
            this.costingFourFifty = new UserControls.GenericAtlanticCostingControl();
            this.costingFiveFifty = new UserControls.GenericAtlanticCostingControl();
            this.costingPane = new UserControls.GenericAtlanticCostingControl();
            this.groupLength.SuspendLayout();
            this.tabAtlanticCosting.SuspendLayout();
            this.tabPageSquareTwoFifty.SuspendLayout();
            this.tabPageATwo.SuspendLayout();
            this.tabPageSquareFourFifty.SuspendLayout();
            this.tabPageThreeFifty.SuspendLayout();
            this.tabPageFourFifty.SuspendLayout();
            this.tabPagePane.SuspendLayout();
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
            this.tabPageSquareTwoFifty.Controls.Add(this.costingSquareTwoFifty);
            this.tabPageSquareTwoFifty.Location = new System.Drawing.Point(4, 25);
            this.tabPageSquareTwoFifty.Name = "tabPageSquareTwoFifty";
            this.tabPageSquareTwoFifty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSquareTwoFifty.Size = new System.Drawing.Size(576, 382);
            this.tabPageSquareTwoFifty.TabIndex = 0;
            this.tabPageSquareTwoFifty.Text = "Square 250 X 250";
            // 
            // costingSquareTwoFifty
            // 
            this.costingSquareTwoFifty.BackColor = System.Drawing.SystemColors.GrayText;
            this.costingSquareTwoFifty.FrameType = UserControls.GenericAtlanticCostingControl.myFrameType.SquareTwoFifty;
            this.costingSquareTwoFifty.Location = new System.Drawing.Point(0, 0);
            this.costingSquareTwoFifty.MaterialID = null;
            this.costingSquareTwoFifty.Name = "costingSquareTwoFifty";
            this.costingSquareTwoFifty.Size = new System.Drawing.Size(550, 392);
            this.costingSquareTwoFifty.TabIndex = 0;
            // 
            // tabPageATwo
            // 
            this.tabPageATwo.BackColor = System.Drawing.SystemColors.GrayText;
            this.tabPageATwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageATwo.Controls.Add(this.costingSquareAtwo);
            this.tabPageATwo.Location = new System.Drawing.Point(4, 25);
            this.tabPageATwo.Name = "tabPageATwo";
            this.tabPageATwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageATwo.Size = new System.Drawing.Size(576, 382);
            this.tabPageATwo.TabIndex = 1;
            this.tabPageATwo.Text = "A2";
            // 
            // costingSquareAtwo
            // 
            this.costingSquareAtwo.BackColor = System.Drawing.SystemColors.GrayText;
            this.costingSquareAtwo.FrameType = UserControls.GenericAtlanticCostingControl.myFrameType.Atwo;
            this.costingSquareAtwo.Location = new System.Drawing.Point(0, 0);
            this.costingSquareAtwo.MaterialID = null;
            this.costingSquareAtwo.Name = "costingSquareAtwo";
            this.costingSquareAtwo.Size = new System.Drawing.Size(550, 392);
            this.costingSquareAtwo.TabIndex = 0;
            // 
            // tabPageSquareFourFifty
            // 
            this.tabPageSquareFourFifty.Controls.Add(this.costingSquareFourFifty);
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
            this.tabPageThreeFifty.Controls.Add(this.costingFourFifty);
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
            this.tabPageFourFifty.Controls.Add(this.costingFiveFifty);
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
            this.tabPagePane.Controls.Add(this.costingPane);
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
            // costingSquareFourFifty
            // 
            this.costingSquareFourFifty.BackColor = System.Drawing.SystemColors.GrayText;
            this.costingSquareFourFifty.FrameType = UserControls.GenericAtlanticCostingControl.myFrameType.SquareTwoFifty;
            this.costingSquareFourFifty.Location = new System.Drawing.Point(0, 0);
            this.costingSquareFourFifty.MaterialID = null;
            this.costingSquareFourFifty.Name = "costingSquareFourFifty";
            this.costingSquareFourFifty.Size = new System.Drawing.Size(550, 392);
            this.costingSquareFourFifty.TabIndex = 0;
            // 
            // costingFourFifty
            // 
            this.costingFourFifty.BackColor = System.Drawing.SystemColors.GrayText;
            this.costingFourFifty.FrameType = UserControls.GenericAtlanticCostingControl.myFrameType.SquareTwoFifty;
            this.costingFourFifty.Location = new System.Drawing.Point(0, 0);
            this.costingFourFifty.MaterialID = null;
            this.costingFourFifty.Name = "costingFourFifty";
            this.costingFourFifty.Size = new System.Drawing.Size(550, 392);
            this.costingFourFifty.TabIndex = 0;
            // 
            // costingFiveFifty
            // 
            this.costingFiveFifty.BackColor = System.Drawing.SystemColors.GrayText;
            this.costingFiveFifty.FrameType = UserControls.GenericAtlanticCostingControl.myFrameType.SquareTwoFifty;
            this.costingFiveFifty.Location = new System.Drawing.Point(0, 0);
            this.costingFiveFifty.MaterialID = null;
            this.costingFiveFifty.Name = "costingFiveFifty";
            this.costingFiveFifty.Size = new System.Drawing.Size(550, 392);
            this.costingFiveFifty.TabIndex = 0;
            // 
            // costingPane
            // 
            this.costingPane.BackColor = System.Drawing.SystemColors.GrayText;
            this.costingPane.FrameType = UserControls.GenericAtlanticCostingControl.myFrameType.SquareTwoFifty;
            this.costingPane.Location = new System.Drawing.Point(0, 0);
            this.costingPane.MaterialID = null;
            this.costingPane.Name = "costingPane";
            this.costingPane.Size = new System.Drawing.Size(550, 392);
            this.costingPane.TabIndex = 0;
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
            this.tabPageATwo.ResumeLayout(false);
            this.tabPageSquareFourFifty.ResumeLayout(false);
            this.tabPageThreeFifty.ResumeLayout(false);
            this.tabPageFourFifty.ResumeLayout(false);
            this.tabPagePane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbLengthMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupLength;
        private System.Windows.Forms.TabControl tabAtlanticCosting;
        private System.Windows.Forms.TabPage tabPageSquareFourFifty;
        private System.Windows.Forms.TabPage tabPageThreeFifty;
        private System.Windows.Forms.TabPage tabPageFourFifty;
        private System.Windows.Forms.TabPage tabPagePane;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.TabPage tabPageSquareTwoFifty;
        private System.Windows.Forms.TabPage tabPageATwo;
        private UserControls.GenericAtlanticCostingControl costingSquareTwoFifty;
        private UserControls.GenericAtlanticCostingControl costingSquareAtwo;
        private UserControls.GenericAtlanticCostingControl costingSquareFourFifty;
        private UserControls.GenericAtlanticCostingControl costingFourFifty;
        private UserControls.GenericAtlanticCostingControl costingFiveFifty;
        private UserControls.GenericAtlanticCostingControl costingPane;
    }
}