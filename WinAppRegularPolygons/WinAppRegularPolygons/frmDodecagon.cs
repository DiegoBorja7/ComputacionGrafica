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
    public partial class frmDodecagon : Form
    {
        private CDodecagon ObjDodecagon = new CDodecagon();
  
        public frmDodecagon()
        {
            InitializeComponent();
            ObjDodecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag = ObjDodecagon.ReadData(txtSide,txtPerimeter,txtArea,picCanvas);
            if (flag)
            {
                ObjDodecagon.PerimeterDodecagon();
                ObjDodecagon.ApothemDodecagon();
                ObjDodecagon.AreaDodecagon();
                ObjDodecagon.PrintData(txtPerimeter, txtArea);
                ObjDodecagon.GraphShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDodecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
