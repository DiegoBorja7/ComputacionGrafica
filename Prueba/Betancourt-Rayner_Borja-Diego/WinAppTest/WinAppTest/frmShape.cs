using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTest
{
    public partial class frmShape : Form
    {
        private CShape ObjShape = new CShape();
        public frmShape()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            frmMenu ObjMenu = new frmMenu();
            ObjMenu.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjShape.InitializeData(txtSideA, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
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
            else
            {
                MessageBox.Show("Error en el ingreso de los datos!", "Error en el ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
