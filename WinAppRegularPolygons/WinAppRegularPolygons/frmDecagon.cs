using System;
using System.Windows.Forms;

namespace WinAppRegularPolygons
{
    public partial class frmDecagon : Form
    {
        private CDecagon ObjDecagon = new CDecagon();
        public frmDecagon()
        {
            InitializeComponent();
            ObjDecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag = ObjDecagon.ReadData(txtSide,txtPerimeter,txtArea,picCanvas);
            if (flag)
            {
                ObjDecagon.PerimeterDecagon();
                ObjDecagon.ApothemDecagon();
                ObjDecagon.AreaDecagon();
                ObjDecagon.PrintData(txtPerimeter, txtArea);
                ObjDecagon.GraphShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
