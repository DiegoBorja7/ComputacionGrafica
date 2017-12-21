using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    public partial class frmOctagon : Form
    {
             
        private COctagon ObjCOctagon = new COctagon();

        // Constructor del formulario.
        public frmOctagon()
        {
            InitializeComponent();
            ObjCOctagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void frmOctagon_Load(object sender, EventArgs e)
        {
            ObjCOctagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCOctagon.ReadData(txtSide);
            ObjCOctagon.PerimeterOctagon();
            ObjCOctagon.ApothemOctagon();
            ObjCOctagon.AreaOctagon();
            ObjCOctagon.PrintData(txtArea, txtPerimeter);
            ObjCOctagon.GraphShape(picCanvas);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCOctagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
