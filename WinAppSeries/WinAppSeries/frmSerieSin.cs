using System;
using System.Windows.Forms;

namespace WinAppSeries
{
    public partial class frmSerieSin : Form
    {
        private CSerie ObjSerieSin = new CSerie();
        public frmSerieSin()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjSerieSin.ReadData(txtNum, txtX);
            ObjSerieSin.SerieSin();
            ObjSerieSin.PrintData(txtResult);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSerieSin.InitializeData(txtNum, txtX, txtResult);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
