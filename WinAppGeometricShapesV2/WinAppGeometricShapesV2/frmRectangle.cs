using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppGeometricShapesV2
{
    public partial class frmRectangle : Form
    {
        private CRectangle ObjRectangle = new CRectangle();
        public frmRectangle()
        {
            InitializeComponent();
            ObjRectangle.InitializeData(txtWidth, txtLong, txtPerimeter, txtArea, picCanvas);
        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {
            ObjRectangle.InitializeData(txtWidth, txtLong, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag = ObjRectangle.ReadData(txtWidth, txtLong);
            if(Flag)
            {
                ObjRectangle.PerimeterRectangle();
                ObjRectangle.AreaRectangle();
                ObjRectangle.PrintData(txtPerimeter, txtArea);
                ObjRectangle.DrawShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRectangle.InitializeData(txtWidth, txtLong, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
