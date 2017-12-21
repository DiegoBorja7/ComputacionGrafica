using System;
using System.Windows.Forms;

namespace WinAppSeries
{
    public partial class frmSucesion1 : Form
    {
        private CSerie ObjSerie = new CSerie();
        public frmSucesion1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjSerie.ReadData(txtNum);
            ObjSerie.Sum1();
            ObjSerie.PrintData(txtResult);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSerie.InitializeData(txtNum, txtResult);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
