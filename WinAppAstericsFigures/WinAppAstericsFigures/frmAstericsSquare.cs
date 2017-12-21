using System;
using System.Windows.Forms;

namespace WinAppAstericsFigures
{
    public partial class frmAstericsSquare : Form
    {
        private CAstericsFigure ObjAstericsSquare = new CAstericsFigure();
        public frmAstericsSquare()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag = ObjAstericsSquare.ReadData(txtNum);
            if (Flag)
            {
                ObjAstericsSquare.GraphAstericsSquare(lstFigure);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjAstericsSquare.InitializeData(txtNum, lstFigure);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
