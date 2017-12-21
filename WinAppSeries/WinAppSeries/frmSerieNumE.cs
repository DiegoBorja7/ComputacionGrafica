using System;
using System.Windows.Forms;

namespace WinAppSeries
{
    public partial class frmSerieNumE : Form
    {
        private CSerie ObjSerieNumE = new CSerie();
        public frmSerieNumE()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjSerieNumE.ReadData(txtNum,txtX);
            ObjSerieNumE.SerieNumE();
            ObjSerieNumE.PrintData(txtResult);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSerieNumE.InitializeData(txtNum, txtX, txtResult);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

