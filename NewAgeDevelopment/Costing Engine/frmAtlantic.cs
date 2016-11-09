using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Engines;
using System.Configuration;
using UserControls;

namespace Costing_Engine
{
    public partial class frmAtlantic : Form
    {
        #region Config


        #endregion Config
        DataEngine d = new DataEngine();
        Accessor.AtlanticCanvasLenght l;
        List<Accessor.AtlanticCanvasLenght> atl = DataEngine.GetAtlanticLength(1);


        public frmAtlantic()
        {
            InitializeComponent();

            cmbLengthMaterial.DataSource = atl;
            costingSquareTwoFifty.FrameType = GenericAtlanticCostingControl.myFrameType.SquareTwoFifty;
            costingSquareAtwo.FrameType = GenericAtlanticCostingControl.myFrameType.Atwo;
            costingFourFifty.FrameType = GenericAtlanticCostingControl.myFrameType.FourFifty;
            costingSquareFourFifty.FrameType = GenericAtlanticCostingControl.myFrameType.SquareFourFifty;
            costingPane.FrameType = GenericAtlanticCostingControl.myFrameType.Pane;
            costingFiveFifty.FrameType = GenericAtlanticCostingControl.myFrameType.FiveFifty;



            costingSquareTwoFifty.MaterialID = "";
            costingSquareAtwo.MaterialID = "";
            costingFourFifty.MaterialID = "";
            costingSquareFourFifty.MaterialID = "";
            costingPane.MaterialID = "";
            costingFiveFifty.MaterialID = "";


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
            l = new Accessor.AtlanticCanvasLenght();
            l = cmbLengthMaterial.SelectedItem as Accessor.AtlanticCanvasLenght;

            costingSquareTwoFifty.MaterialID = l.MaterialID;
            costingSquareTwoFifty.SetDisplay();

            costingSquareAtwo.MaterialID = l.MaterialID;
            costingSquareAtwo.SetDisplay();

            costingFourFifty.MaterialID = l.MaterialID;
            costingFourFifty.SetDisplay();

            costingSquareFourFifty.MaterialID = l.MaterialID;
            costingSquareFourFifty.SetDisplay();

            costingPane.MaterialID = l.MaterialID;
            costingPane.SetDisplay();

            costingFiveFifty.MaterialID = l.MaterialID;
            costingFiveFifty.SetDisplay();

            SetDisplay();
        }
    }
}
