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

namespace Test
{
    public partial class Form1 : Form
    {
        DataEngine d = new DataEngine();
        Accessor.AtlanticCanvasLenght a;
        public Form1()
        {
            InitializeComponent();
 //           dataGridView1.DataSource = d.GetAtlanticLength("1", 1);
        }
    }
}
