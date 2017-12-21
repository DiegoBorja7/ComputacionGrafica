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
    public partial class frmEndecagon : Form
    {
        private CEndecagon ObjEndecagon = new CEndecagon();
        public frmEndecagon()
        {
            InitializeComponent();
            ObjEndecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag = ObjEndecagon.ReadData(txtSide, txtPerimeter, txtArea, picCanvas);
            if (flag)
            {
                ObjEndecagon.PerimeterEndecagon();
                ObjEndecagon.AreaEndecagono();
                ObjEndecagon.PrintData(txtSide, txtPerimeter, txtArea);
                ObjEndecagon.GraphShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjEndecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
