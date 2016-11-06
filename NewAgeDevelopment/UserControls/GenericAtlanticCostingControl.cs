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
        int atlanticID;
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

        }

        #endregion Constructor

        #region Methods

        private void HideTextBoxes()
        {

            frameLengthText.Hide();
            frameWidthText.Hide();
            noFramesText.Hide();
           
            lblFrameLength.Show();
            lblFrameWidth.Show();
            lblNoFrames.Show();

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
            tblLengthCost length= DataEngine.GetLengthPricePerMeter(materialID);
            //Top Frame
            lblFrame.Text = mat.Name;
            lblMaterialID.Text = materialID;
            string pricePerMeter = string.Format("{0:C}", length.PricePerMeter);
            lblPricePerMeter.Text = pricePerMeter;

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

            atlanticID = o.AtlanticCanvasLenID;

        }


        /// <summary>
        /// Updates the db
        /// </summary>
        private void ApplyEdit()
        {
            l = new Accessor.AtlanticCanvasLenght();

            l.FrameLenght = Convert.ToDecimal(lblFrameLength.Text);
            l.FrameWidth = Convert.ToDecimal(lblFrameWidth.Text);
            l.NoOfFrames = Convert.ToDecimal(lblNoFrames.Text);
            l.TotalUsedFrameCost = decimal.Parse(lblTotalUsedFrameCost.Text, System.Globalization.NumberStyles.Currency);
            l.TotalArea = Convert.ToDecimal(lblFrameArea.Text);
            l.CanvasOverlap =  Convert.ToDecimal(lblCanvasOveralap.Text);
            l.TotalCanvasArea =  Convert.ToDecimal(lblTotalCanvasArea.Text);
            l.TotalFrameLength =  Convert.ToDecimal(lblTotalFrameArea.Text);

            d.SaveAtlanticLength(atlanticID, l);
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
                decimal formating;
                formating = decimal.Parse(noFramesText.Text);
                noFramesText.Text = string.Format("{0:0.00}", formating);

                lblNoFrames.Text = noFramesText.Text;
                noFramesText.Hide();
                lblNoFrames.Show();
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


        #endregion Leave

        #region Double Click

        private void lblFrameLength_DoubleClick(Object sender, EventArgs e)
        {


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
            this.groupBox2.Controls.Add(NoFramesText);

            NoFramesText.Size = lblNoFrames.Size;
            NoFramesText.Location = lblNoFrames.Location;
            NoFramesText.Text = lblNoFrames.Text;
            lblNoFrames.Hide();
            NoFramesText.Show();
            NoFramesText.Focus();
        }

        #endregion Double Click

        private void btnApply_Click(Object sender, EventArgs e)
        {
            switch (MessageBox.Show("Save to Database?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    ApplyEdit();
                    MessageBox.Show("Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //SetDisplay(false);
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(Object sender, EventArgs e)
        {

        }
        #endregion Events


    }
}
