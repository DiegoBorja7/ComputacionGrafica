using System;
using System.Windows.Forms;

namespace WinAppAstericsFigures
{
    public partial class frmAstericsTriangle : Form
    {
        private CAstericsFigure ObjAstericsTriangle = new CAstericsFigure();
        public frmAstericsTriangle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag = ObjAstericsTriangle.ReadData(txtNum);
            if(Flag)
            {
                ObjAstericsTriangle.GraphAstericsTriangle(lstFigure);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjAstericsTriangle.InitializeData(txtNum, lstFigure);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
