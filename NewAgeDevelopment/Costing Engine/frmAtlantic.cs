using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engines;

namespace Costing_Engine
{
    public partial class frmAtlantic : Form
    {
        DataEngine d = new DataEngine();
        Accessor.AtlanticCanvasLenght l;
        List<Accessor.AtlanticCanvasLenght> atl = DataEngine.GetAtlanticLength(1);


        public frmAtlantic()
        {
            InitializeComponent();

            cmbLengthMaterial.DataSource = atl;

            this.Size = new System.Drawing.Size(230, 140);
        }

        private void SetDisplay()
        {
            l = new Accessor.AtlanticCanvasLenght();
            l = cmbLengthMaterial.SelectedItem as Accessor.AtlanticCanvasLenght;
            this.Size = new System.Drawing.Size(600, 450);
            string id = l.MaterialID;
            tblAtlanticCanvasLength o = DataEngine.GetAtlanticLength(1, id);
            tblMaterial mat = DataEngine.GetMaterial(id);
            //Top Frame
            lblFrame.Text = mat.Name;
            lblMaterialID.Text = id;

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


            cmbLengthMaterial.Hide();
            tabAtlanticCosting.Show();
        }

        private void cmbLengthMaterial_SelectedIndexChanged(Object sender, EventArgs e)
        {
            l = new Accessor.AtlanticCanvasLenght();
            l = cmbLengthMaterial.SelectedItem as Accessor.AtlanticCanvasLenght;

        }

        private void cmbLengthMaterial_SelectionChangeCommitted(Object sender, EventArgs e)
        {
            
        }
    }
}
