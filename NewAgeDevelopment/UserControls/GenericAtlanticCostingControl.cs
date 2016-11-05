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

        public enum myFrameType { SquareTwoFifty, Atwo, SquareFourFifty, FourFifty, FiveFifty, Pane };   //Channel Cost Enumeration
        private myFrameType frameType = new myFrameType();
        public myFrameType FrameType
        {
            get { return frameType; }
            set { frameType = value; }
        }

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


        #endregion Properties

        #region Constructor

        public GenericAtlanticCostingControl()
        {
            InitializeComponent();
            
        }

        #endregion Constructor

        #region Methods

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
    }
}
