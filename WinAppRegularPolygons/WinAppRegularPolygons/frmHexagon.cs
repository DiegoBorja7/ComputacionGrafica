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
    public partial class frmHexagon : Form
    {
        private CHexagon ObjHexagon = new CHexagon();

        public frmHexagon()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void frmHexagon_Load(object sender, EventArgs e)
        {
            ObjHexagon.InitializeData(txtSide, txtPerimeter, txtArea,picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag = ObjHexagon.ReadData(txtSide, txtPerimeter, txtArea, picCanvas);
            if (flag)
            {
                ObjHexagon.PerimeterHexagon();
                ObjHexagon.AreaHexagon();
                ObjHexagon.PrintData(txtSide, txtPerimeter, txtArea);
                ObjHexagon.DrawShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjHexagon.InitializeData(txtSide, txtPerimeter, txtArea,picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
