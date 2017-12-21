using System;
using System.Windows.Forms;

namespace WinAppAstericsFigures
{
    public partial class frmAstericsRombus : Form
    {
        private CAstericsFigure ObjAstericsRumbus = new CAstericsFigure();
        public frmAstericsRombus()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Boolean Flag;
            Flag = ObjAstericsRumbus.ReadData(txtNum);
            if (Flag)
            {
                ObjAstericsRumbus.GraphAstericsRombus(txtNum,lstFigure);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjAstericsRumbus.InitializeData(txtNum, lstFigure);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
