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
    public partial class frmHeptagon : Form
    {
        private CHeptagon ObjHeptagon = new CHeptagon();
        public frmHeptagon()
        {
            InitializeComponent();
            ObjHeptagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag =ObjHeptagon.ReadData(txtSide,txtPerimeter,txtArea,picCanvas);
            if (flag)
            {
                ObjHeptagon.PerimeterHeptagon();
                ObjHeptagon.ApothemHeptagon();
                ObjHeptagon.AreaHeptagon();
                ObjHeptagon.PrintData(txtPerimeter, txtArea);
                ObjHeptagon.GraphShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjHeptagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
