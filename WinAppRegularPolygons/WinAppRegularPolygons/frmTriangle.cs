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
    public partial class frmTriangle : Form
    {
        CTriangle ObjCTriangle = new CTriangle();

        public frmTriangle()
        {
            InitializeComponent();
        }
        private void frmTriangle_Load(object sender, EventArgs e)
        {
            ObjCTriangle.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCTriangle.ReadData(txtSide);
            ObjCTriangle.PerimeterTriangle();
            ObjCTriangle.HeightTriangle();          
            ObjCTriangle.AreaTriangle();            
            ObjCTriangle.PrintData(txtArea, txtPerimeter);
            ObjCTriangle.GraphShape(picCanvas);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCTriangle.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
