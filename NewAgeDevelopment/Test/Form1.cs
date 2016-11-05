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
using UserControls;

namespace Test
{
    public partial class Form1 : Form
    {
        DataEngine d = new DataEngine();
        Accessor.AtlanticCanvasLenght l;

        public Form1()
        {
            InitializeComponent();
            List<Accessor.AtlanticCanvasLenght> atl = DataEngine.GetAtlanticLength(1);
            comboBox1.DataSource = atl;

        }

        private void comboBox1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            l = new Accessor.AtlanticCanvasLenght();
            l = comboBox1.SelectedItem as Accessor.AtlanticCanvasLenght;
        }

        private void comboBox1_SelectionChangeCommitted(Object sender, EventArgs e)
        {
            
            this.genericAtlanticCostingControl1.FrameType = GenericAtlanticCostingControl.myFrameType.SquareTwoFifty;
            l = new Accessor.AtlanticCanvasLenght();
            l = comboBox1.SelectedItem as Accessor.AtlanticCanvasLenght;
            genericAtlanticCostingControl1.MatertialID.Text = l.MaterialID;
        }
    }
}
