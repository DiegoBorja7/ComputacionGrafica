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
    public partial class frmEquilateralTriangle : Form
    {
        private CEquilateralTriangle ObjTriangle = new CEquilateralTriangle();
        public frmEquilateralTriangle()
        {
            InitializeComponent();
            ObjTriangle.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag = ObjTriangle.ReadData(txtSide, txtPerimeter, txtArea, picCanvas);
            if (flag)
            {
                ObjTriangle.PerimeterTriangle();
                ObjTriangle.AreaTriangle();
                ObjTriangle.PrintData(txtArea,txtPerimeter,txtArea);
                ObjTriangle.GraphShape(picCanvas);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTriangle.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
