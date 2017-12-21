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
    public partial class frmSquare : Form
    {
        private CSquare ObjSquare = new CSquare();
        public frmSquare()
        {
            InitializeComponent();
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag = ObjSquare.ReadData(txtSide, txtPerimeter, txtArea, picCanvas);
            if (flag)
            {
                ObjSquare.PerimeterTriangle();
                ObjSquare.AreaTriangle();
                ObjSquare.PrintData(txtArea, txtPerimeter, txtArea);
                ObjSquare.GraphShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
