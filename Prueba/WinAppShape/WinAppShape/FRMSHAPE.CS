using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppShape
{
    public partial class frmShape : Form
    {
        private CShape ObjShape = new CShape();

        public frmShape()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag = ObjShape.ReadData(txtSideA);
            if (Flag)
            {
                ObjShape.PerimeterHexagon();
                ObjShape.ApothemHexagon();
                ObjShape.AreaHexagon();
                ObjShape.PrintData(txtPerimeter, txtArea);
                ObjShape.GraphShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjShape.InitializeData(txtSideA, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
