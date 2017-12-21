using System;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    public partial class frmPentagon : Form
    {
        private CPentagon ObjPentagon = new CPentagon();
        public frmPentagon()
        {
            InitializeComponent();
            ObjPentagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag =ObjPentagon.ReadData(txtSide,txtPerimeter,txtArea,picCanvas);
            if (flag)
            {
                ObjPentagon.PerimeterPentagon();
                ObjPentagon.ApothemPentagon();
                ObjPentagon.AreaPentagon();
                ObjPentagon.PrintData(txtPerimeter, txtArea);
                ObjPentagon.GraphShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjPentagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
