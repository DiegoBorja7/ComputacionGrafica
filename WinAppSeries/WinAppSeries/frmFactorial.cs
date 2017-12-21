using System;
using System.Windows.Forms;

namespace WinAppSeries
{
    public partial class frmFactorial : Form
    {
        private CSerie ObjFactorial = new CSerie();
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjFactorial.ReadData(txtNum);
            ObjFactorial.Factorial();
            ObjFactorial.PrintData(txtResult);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjFactorial.InitializeData(txtNum, txtResult);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
