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
    public partial class frmOctogon : Form
    {
        private COctogon ObjOctogon = new COctogon();
        public frmOctogon()
        {
            CenterToScreen();
            InitializeComponent();
        }

        private void frmOctogon_Load(object sender, EventArgs e)
        {
            ObjOctogon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag = ObjOctogon.ReadData(txtSide, txtPerimeter, txtArea, picCanvas);
            if (flag)
            {
                ObjOctogon.PerimeterOctogon();
                ObjOctogon.AreaOctogon();
                ObjOctogon.PrintData(txtSide, txtPerimeter, txtArea);
                ObjOctogon.DrawShape(picCanvas);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjOctogon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
