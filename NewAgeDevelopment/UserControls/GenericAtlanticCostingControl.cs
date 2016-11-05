using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engines;

namespace UserControls
{
    public partial class GenericAtlanticCostingControl : UserControl
    {
        #region Properties

        string materialID;
        DataEngine d = new DataEngine();
        Accessor.AtlanticCanvasLenght l;

        #region Label and Text Properties
        //TODO DELETE BELOW
            private TextBox frameLengthText;
            private TextBox frameWidthText;
            private TextBox noFramesText;
            private TextBox totalUsedFrameCostText;
            private TextBox frameAreaText;
            private TextBox canvasOveralapText;
            private TextBox totalCanvasAreaText;
            private TextBox totalFrameAreaText;

        public String MaterialID
        {
            get
            {
                return materialID;
            }

            set
            {
                materialID = value;
            }
        }

        public TextBox FrameLengthText
        {
            get
            {
                return frameLengthText;
            }

            set
            {
                frameLengthText = value;
            }
        }

        public TextBox FrameWidthText
        {
            get
            {
                return frameWidthText;
            }

            set
            {
                frameWidthText = value;
            }
        }

        public TextBox NoFramesText
        {
            get
            {
                return noFramesText;
            }

            set
            {
                noFramesText = value;
            }
        }

        public TextBox TotalUsedFrameCostText
        {
            get
            {
                return totalUsedFrameCostText;
            }

            set
            {
                totalUsedFrameCostText = value;
            }
        }

        public TextBox FrameAreaText
        {
            get
            {
                return frameAreaText;
            }

            set
            {
                frameAreaText = value;
            }
        }

        public TextBox CanvasOveralapText
        {
            get
            {
                return canvasOveralapText;
            }

            set
            {
                canvasOveralapText = value;
            }
        }

        public TextBox TotalCanvasAreaText
        {
            get
            {
                return totalCanvasAreaText;
            }

            set
            {
                totalCanvasAreaText = value;
            }
        }

        public TextBox TotalFrameAreaText
        {
            get
            {
                return totalFrameAreaText;
            }

            set
            {
                totalFrameAreaText = value;
            }
        }

        #endregion  Label and Text Properties

        public enum myFrameType { SquareTwoFifty, Atwo, SquareFourFifty, FourFifty, FiveFifty, Pane };   //Channel Cost Enumeration
        private myFrameType frameType = new myFrameType();
        public myFrameType FrameType
        {
            get { return frameType; }
            set { frameType = value; }
        }

        #endregion Properties

        #region Constructor

        public GenericAtlanticCostingControl()
        {
            InitializeComponent();

            frameLengthText = new TextBox();
            frameLengthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            frameLengthText.KeyDown += new KeyEventHandler(frameLengthText_Keydown);
            frameLengthText.KeyPress += new KeyPressEventHandler(frameLengthText_KeyPress);
            frameLengthText.Leave += new System.EventHandler(frameLengthText_Leave);
            frameLengthText.Hide();

            frameWidthText = new TextBox();
            frameWidthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            frameWidthText.KeyDown += new KeyEventHandler(frameWidthText_Keydown);
            frameWidthText.KeyPress += new KeyPressEventHandler(frameWidthText_KeyPress);
            frameWidthText.Leave += new System.EventHandler(frameWidthText_Leave);
            frameWidthText.Hide();

            noFramesText = new TextBox();
            noFramesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            noFramesText.KeyDown += new KeyEventHandler(noFramesText_Keydown);
            noFramesText.KeyPress += new KeyPressEventHandler(noFramesText_KeyPress);
            noFramesText.Leave += new System.EventHandler(noFramesText_Leave);
            noFramesText.Hide();


            totalUsedFrameCostText = new TextBox();
            totalUsedFrameCostText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            totalUsedFrameCostText.KeyDown += new KeyEventHandler(totalUsedFrameCostText_Keydown);
            totalUsedFrameCostText.KeyPress += new KeyPressEventHandler(totalUsedFrameCostText_KeyPress);
            totalUsedFrameCostText.Leave += new System.EventHandler(totalUsedFrameCostText_Leave);
            totalUsedFrameCostText.Hide();

            frameAreaText = new TextBox();
            frameAreaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            frameAreaText.KeyDown += new KeyEventHandler(frameAreaText_Keydown);
            frameAreaText.KeyPress += new KeyPressEventHandler(frameAreaText_KeyPress);
            frameAreaText.Leave += new System.EventHandler(frameAreaText_Leave);
            frameAreaText.Hide();

            canvasOveralapText = new TextBox();
            canvasOveralapText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            canvasOveralapText.KeyDown += new KeyEventHandler(canvasOveralapText_Keydown);
            canvasOveralapText.KeyPress += new KeyPressEventHandler(canvasOveralapText_KeyPress);
            canvasOveralapText.Leave += new System.EventHandler(canvasOveralapText_Leave);
            canvasOveralapText.Hide();

            totalCanvasAreaText = new TextBox();
            totalCanvasAreaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            totalCanvasAreaText.KeyDown += new KeyEventHandler(totalCanvasAreaText_Keydown);
            totalCanvasAreaText.KeyPress += new KeyPressEventHandler(totalCanvasAreaText_KeyPress);
            totalCanvasAreaText.Leave += new System.EventHandler(totalCanvasAreaText_Leave);
            totalCanvasAreaText.Hide();

            totalFrameAreaText = new TextBox();
            totalFrameAreaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            totalFrameAreaText.KeyDown += new KeyEventHandler(totalFrameAreaText_Keydown);
            totalFrameAreaText.KeyPress += new KeyPressEventHandler(totalFrameAreaText_KeyPress);
            totalFrameAreaText.Leave += new System.EventHandler(totalFrameAreaText_Leave);
            totalFrameAreaText.Hide();

        }

        #endregion Constructor

        #region Methods

        private void HideTextBoxes()
        {

            frameLengthText.Hide();
            frameWidthText.Hide();
            noFramesText.Hide();
            totalUsedFrameCostText.Hide();
            FrameAreaText.Hide();
            canvasOveralapText.Hide();
            TotalCanvasAreaText.Hide();
            TotalFrameAreaText.Hide();

            lblFrameLength.Show();
            lblFrameWidth.Show();
            lblNoFrames.Show();
            lblTotalUsedFrameCost.Show();
            lblFrameArea.Show();
            lblCanvasOveralap.Show();
            lblTotalCanvasArea.Show();
            lblTotalFrameArea.Show();


        }

        /// <summary>
        /// Sets the inititial display populating all the fields with the selection
        /// </summary>
        public  void SetDisplay()
        {
            int frameTyepID =1 ; //Default

            switch (frameType)
            {
                case myFrameType.SquareTwoFifty:
                    frameTyepID = 1;
                    break;
                case myFrameType.Atwo:
                    frameTyepID = 2;
                    break;
                case myFrameType.SquareFourFifty:
                    frameTyepID = 3;
                    break;
                case myFrameType.FourFifty:
                    frameTyepID = 4;
                    break;
                case myFrameType.FiveFifty:
                    frameTyepID = 5;
                    break;
                case myFrameType.Pane:
                    frameTyepID = 6;
                    break;
                default:
                    break;
            }

            tblAtlanticCanvasLength o = DataEngine.GetAtlanticLength(frameTyepID, materialID);
            tblMaterial mat = DataEngine.GetMaterial(materialID);
            //Top Frame
            lblFrame.Text = mat.Name;
            lblMaterialID.Text = materialID;

            // Details

            string frameLength = string.Format("{0:0.00}", o.FrameLenght);
            lblFrameLength.Text = frameLength;

            string frameWidth = string.Format("{0:0.00}", o.FrameWidth);
            lblFrameWidth.Text = frameWidth;

            string noFrames = string.Format("{0:0.00}", o.NoOfFrames);
            lblNoFrames.Text = noFrames;

            string TotalUsedFrmCost = string.Format("{0:C}", o.TotalUsedFrameCost);
            lblTotalUsedFrameCost.Text = TotalUsedFrmCost;

            string frameArea = string.Format("{0:0.00}", o.FrameArea);
            lblFrameArea.Text = frameArea;

            string canvasOverlap = string.Format("{0:0.00}", o.CanvasOverlap);
            lblCanvasOveralap.Text = canvasOverlap;

            string totalCanvasArea = string.Format("{0:0.00}", o.TotalCanvasArea);
            lblTotalCanvasArea.Text = totalCanvasArea;

            string frameTotalArea = string.Format("{0:0.00}", o.TotalFrameLength);
            lblTotalFrameArea.Text = o.TotalFrameLength.ToString();


        }

        #endregion Methods

        #region Events

        #region Keydown

        private void frameLengthText_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                decimal formating;
                formating = decimal.Parse(frameLengthText.Text);
                frameLengthText.Text = string.Format("{0:0.00}", formating);

                lblFrameLength.Text = FrameLengthText.Text;
                FrameLengthText.Hide();
                lblFrameLength.Show();
            }
        }

        private void frameWidthText_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal formating;
                formating = decimal.Parse(frameWidthText.Text);
                frameWidthText.Text = string.Format("{0:0.00}", formating);

                lblFrameWidth.Text = frameWidthText.Text;
                frameWidthText.Hide();
                lblFrameWidth.Show();
            }
        }

        private void noFramesText_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblNoFrames.Text = noFramesText.Text;
                noFramesText.Hide();
                lblNoFrames.Show();
            }
        }

        private void totalUsedFrameCostText_Keydown(object sender, KeyEventArgs e)
        {
           

            if (e.KeyCode == Keys.Enter)
            {
                decimal formating;
                formating = decimal.Parse(totalUsedFrameCostText.Text, System.Globalization.NumberStyles.Currency);
                totalUsedFrameCostText.Text = string.Format("{0:C}", formating);

                lblTotalUsedFrameCost.Text = totalUsedFrameCostText.Text;
                totalUsedFrameCostText.Hide();
                lblTotalUsedFrameCost.Show();
            }
        }

        private void frameAreaText_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblTotalUsedFrameCost.Text = totalUsedFrameCostText.Text;
                totalUsedFrameCostText.Hide();
                lblTotalUsedFrameCost.Show();
            }
        }

        private void canvasOveralapText_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblCanvasOveralap.Text = canvasOveralapText.Text;
                canvasOveralapText.Hide();
                lblCanvasOveralap.Show();
            }
        }

        private void totalCanvasAreaText_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblTotalUsedFrameCost.Text = totalCanvasAreaText.Text;
                totalUsedFrameCostText.Hide();
                lblTotalUsedFrameCost.Show();
            }
        }

        private void totalFrameAreaText_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblTotalFrameArea.Text = totalFrameAreaText.Text;
                totalFrameAreaText.Hide();
                lblTotalFrameArea.Show();
            }
        }

        #endregion Keydown

        #region KeyPress

        private void frameLengthText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && frameLengthText.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void frameWidthText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && frameWidthText.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void noFramesText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && noFramesText.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void totalUsedFrameCostText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && totalUsedFrameCostText.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void frameAreaText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && frameAreaText.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void canvasOveralapText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && canvasOveralapText.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void totalCanvasAreaText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && totalCanvasAreaText.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void totalFrameAreaText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && totalFrameAreaText.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        #endregion KeyPress

        #region Leave

        private void frameLengthText_Leave(Object sender, EventArgs e)
        {
            decimal formating;
            formating = decimal.Parse(frameLengthText.Text);
            lblFrameLength.Text = string.Format("{0:0.00}", formating);
        }

        private void frameWidthText_Leave(Object sender, EventArgs e)
        {
            decimal formating;
            formating = decimal.Parse(frameWidthText.Text);
            lblFrameWidth.Text = string.Format("{0:0.00}", formating);
        }

        private void noFramesText_Leave(Object sender, EventArgs e)
        {

        }

        private void totalUsedFrameCostText_Leave(Object sender, EventArgs e)
        {

        }

        private void frameAreaText_Leave(Object sender, EventArgs e)
        {

        }

        private void canvasOveralapText_Leave(Object sender, EventArgs e)
        {

        }

        private void totalCanvasAreaText_Leave(Object sender, EventArgs e)
        {

        }

        private void totalFrameAreaText_Leave(Object sender, EventArgs e)
        {

        }

        #endregion Leave

        #region Double Click

        private void lblFrameLength_DoubleClick(Object sender, EventArgs e)
        {
            HideTextBoxes();

            this.groupBox2.Controls.Add(FrameLengthText);

            FrameLengthText.Size = lblFrameLength.Size;
            FrameLengthText.Location = lblFrameLength.Location;
            FrameLengthText.Text = lblFrameLength.Text;
            lblFrameLength.Hide();
            FrameLengthText.Show();
            FrameLengthText.Focus();
        }

        private void lblFrameWidth_DoubleClick(Object sender, EventArgs e)
        {
            HideTextBoxes();

            this.groupBox2.Controls.Add(FrameWidthText);

            FrameWidthText.Size = lblFrameWidth.Size;
            FrameWidthText.Location = lblFrameWidth.Location;
            FrameWidthText.Text = lblFrameWidth.Text;
            lblFrameWidth.Hide();
            FrameWidthText.Show();
            FrameWidthText.Focus();
        }

        private void lblNoFrames_DoubleClick(Object sender, EventArgs e)
        {
            HideTextBoxes();
            this.groupBox2.Controls.Add(NoFramesText);

            NoFramesText.Size = lblNoFrames.Size;
            NoFramesText.Location = lblNoFrames.Location;
            NoFramesText.Text = lblNoFrames.Text;
            lblNoFrames.Hide();
            NoFramesText.Show();
            NoFramesText.Focus();
        }

        private void lblTotalUsedFrameCost_DoubleClick(Object sender, EventArgs e)
        {
            HideTextBoxes();
            this.groupBox2.Controls.Add(TotalUsedFrameCostText);

            TotalUsedFrameCostText.Size = lblTotalUsedFrameCost.Size;
            TotalUsedFrameCostText.Location = lblTotalUsedFrameCost.Location;
            TotalUsedFrameCostText.Text = lblTotalUsedFrameCost.Text;
            lblTotalUsedFrameCost.Hide();
            TotalUsedFrameCostText.Show();
            TotalUsedFrameCostText.Focus();
        }

        private void lblFrameArea_DoubleClick(Object sender, EventArgs e)
        {
            HideTextBoxes();
            this.groupBox2.Controls.Add(FrameAreaText);

            FrameAreaText.Size = lblFrameArea.Size;
            FrameAreaText.Location = lblFrameArea.Location;
            FrameAreaText.Text = lblFrameArea.Text;
            lblFrameArea.Hide();
            FrameAreaText.Show();
            FrameAreaText.Focus();
        }

        private void lblCanvasOveralap_DoubleClick(Object sender, EventArgs e)
        {
            HideTextBoxes();
            this.groupBox2.Controls.Add(CanvasOveralapText);

            CanvasOveralapText.Size = lblCanvasOveralap.Size;
            CanvasOveralapText.Location = lblCanvasOveralap.Location;
            CanvasOveralapText.Text = lblCanvasOveralap.Text;
            lblCanvasOveralap.Hide();
            CanvasOveralapText.Show();
            CanvasOveralapText.Focus();
        }

        private void lblTotalCanvasArea_DoubleClick(Object sender, EventArgs e)
        {
            HideTextBoxes();
            this.groupBox2.Controls.Add(TotalCanvasAreaText);

            TotalCanvasAreaText.Size = lblTotalCanvasArea.Size;
            TotalCanvasAreaText.Location = lblTotalCanvasArea.Location;
            TotalCanvasAreaText.Text = lblTotalCanvasArea.Text;
            lblTotalCanvasArea.Hide();
            TotalCanvasAreaText.Show();
            TotalCanvasAreaText.Focus();
        }

        private void lblTotalFrameArea_DoubleClick(Object sender, EventArgs e)
        {
            HideTextBoxes();
            this.groupBox2.Controls.Add(TotalFrameAreaText);

            TotalFrameAreaText.Size = lblTotalFrameArea.Size;
            TotalFrameAreaText.Location = lblTotalFrameArea.Location;
            TotalFrameAreaText.Text = lblTotalFrameArea.Text;
            lblTotalFrameArea.Hide();
            TotalFrameAreaText.Show();
            TotalFrameAreaText.Focus();
        }
        #endregion Double Click

        private void btnApply_Click(Object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(Object sender, EventArgs e)
        {

        }
        #endregion Events


    }
}
